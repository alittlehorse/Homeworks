using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DCMLIB
{
    
    public abstract class DCMAbstractType
    { 
        public ushort etag;
        public ushort gtag;
        public uint length;
        public string name;
        public String vr;
        public byte[] value;
        public string vm;
        /// <summary>
        /// 值表示法
        /// </summary>
        
        public VR vrparser ;
        public abstract string ToString(string head);
        public virtual void WriteValue<T>(T[] val)
        {
            value = vrparser.WriteValue<T>(val);
            length = (uint)value.Length;
        }

        public virtual T[] ReadValue<T>()
        {
            return vrparser.ReadValue<T>(value);
        }
    }

    public class DCMDataElement : DCMAbstractType
    {

        public override string ToString(string head)
        {
            string str = head;
            str += gtag.ToString("X4") + "," + etag.ToString("X4") + "\t";
            str += vr + "\t";
            str += name + "\t";
            str += length.ToString();
            str += '\t';
            String Value = vrparser.GetString(value,head);
            str += Value;
            str += '\n';
            
            return str; 

        }
    }

    public class DCMDataSet : DCMAbstractType
    {
        /// <summary>
        /// 所容纳的数据元素或条目
        /// </summary>
        /// 
        //每一个DataSet的无论子类还是父类,都内置items属性;
        protected List<DCMAbstractType> items ;
        protected TransferSyntax syntax;
        public DCMDataSet(TransferSyntax ts)   //传输语法由构造函数传入
        {
            syntax = ts;
            items = new List<DCMAbstractType>();
        }


        /// <summary>
        /// DCMDataset类的索引,将List<DCMAbstractType>和Dataset联系起来
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public virtual DCMAbstractType this[uint idx]
        {
            get
            {
                //拉姆达表达式(匿名函数)比较tag与索引idx是否相等，返回索引结果
                DCMAbstractType item = items.Find(elem => (uint)(elem.gtag << 16) + (elem.etag) == idx); 
                return item;
            }
            set
            {
                DCMAbstractType val = (DCMAbstractType)value;
                DCMAbstractType item = items.Find(elem => (uint)(elem.gtag << 16 + (elem.etag)) == idx);
                if (item == null)  //not exists
                    items.Add(val);
                else
                {
                    item.length = val.length;
                    item.value = val.value;
                }
            }
        }


        public override string ToString(string head)
        {
            string str = "";
            foreach (DCMAbstractType item in items)
            {
                if (item != null)
                {
                    if (str != "") str += "\n";  //两个数据元素之间用换行符分割
                    str += item.ToString(head);
                }
            }
            
            return str;
        }

        /// <summary>
        /// 当中调用传输语法类对象从data[idx]开始解码一条数据元素，添加到items, 循环将整个数据集解码，返回items, 同时变化后的idx通过引用(ref)返回。
        /// </summary>
        public virtual List<DCMAbstractType> Decode(byte[] data, ref uint idx)
        {

            while (idx < data.Length)
            {
                DCMAbstractType item = null;
                item = syntax.Decode(data, ref idx);
                items.Add(item);
            }
            return items;
        }
    }

    public class DCMDataSequence : DCMDataSet
    {
        public DCMDataSequence(TransferSyntax syntax) : base(syntax) { }
        public override string ToString(string head)
        {
            string str = "";
            int i = 1;
            foreach (DCMAbstractType item in items)
            {
                str += "\n" + head + "ITEM" + i.ToString() + "\n";
                str += item.ToString(head);
                i++;
            }
            
            return str;
        }
    }
    public class DCMDataItem : DCMDataSet
    {
        public DCMDataItem(TransferSyntax syntax) : base(syntax) { }
        public override string ToString(string head)
        {
            string str = "";
            foreach (DCMAbstractType item in items)
            {
                if (item != null)
                {
                    if (str != "") str += "\n";  //两个数据元素之间用换行符分割
                    str += item.ToString(head);
                }
            }
            
            return str;
        }
    }
    public class DCMFileMeta : DCMDataSet
    {
        public DCMFileMeta(TransferSyntax syntax) : base(syntax) { }
        public override List<DCMAbstractType> Decode(byte[] data, ref uint idx)
        {
            uint temp_idx = 0;
            while (idx < data.Length)
            {

                DCMAbstractType item = null;
                try
                {
                    item = syntax.Decode(data, ref idx);
                    if (item != null && item.gtag == 0x0002)
                    {
                        items.Add(item);
                        temp_idx = idx;
                    }
                    else
                    {
                        //但要注意最后那条数据元素必须通过修改idx退回到缓冲区
                        idx = temp_idx;
                        break;
                    }
                }
                catch (Exception e)
                {
                    if (e.GetType()==typeof(NullReferenceException))
                    {
                        idx = temp_idx;
                        break;
                    } 
                }

            }          
            return items;
        }
        //文件头ToString方法；
        public override string ToString(string head)
        {
            string str = "";
            int i = 1;
            foreach (DCMAbstractType item in items)
            {
                if (item.gtag != 0x0002)
                {
                    break;
                }
                str += "\n" + head + "Head" + i.ToString() + "\n";
                str += item.ToString(head);
                i++;
            }

            return str;
        }
    }
    public class DCMFile : DCMDataSet
    {
        protected String filename;
        protected DCMFileMeta filemeta;
        protected TransferSyntaxes tsFactory;
        public DCMFile(String filename) : base(new ImplicitVRLittleEndian()) {
            this.filename = filename;
            tsFactory = new TransferSyntaxes();
        }
        public override List<DCMAbstractType> Decode(byte[] data, ref uint idx)
        {
            //打开filename文件，将文件内容读到缓冲区byte[] data
            using (FileStream fs = File.OpenRead(filename))
            {
                data = new byte[fs.Length];
                fs.Read(data, 0, (int)fs.Length);
            }

                //跳过128字节前导符(idx=128)，读取4字节的”DICM”
                idx = 128;
            //***
            idx += 4;
            //用ExplicitVRLittleEndian对象实例化filemeta对象，通过其Decode方法从data中读取头元素
            syntax = new ExplicitVRLittleEndian();
            filemeta= new DCMFileMeta(syntax);
            filemeta.Decode(data,ref idx);
            //读取(0002,0010)头元素即filemeta[DicomTags.TransferSyntaxUid]的值，
            //在tsFactory中找到对应的数据集传输语法对象赋给基类的syntax字段
            DCMDataElement synelem = (DCMDataElement)filemeta[DicomTags.TransferSyntaxUid];
            syntax = tsFactory[synelem.ReadValue<String>()[0].Replace("\0","")];

            
            //调用base.Decode方法解码数据集
            base.Decode(data, ref idx);
            return items;
        }
        //注意,这里可能要修改方法
        public override string ToString(string head)
        {
            //调用文件头的ToString
            String headstr = filemeta.ToString("");
            String str = base.ToString("");
            return headstr+ str;
        }
    }
     

}
