using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCMLIB
{
    public abstract class DCMAbstractType
    {
        public ushort etag;
        public ushort gtag;
        public uint length;
        public string name;
        public byte[] value;
        public string vm;
        /// <summary>
        /// 值表示法
        /// </summary>
        public String vr;
        public VR vrparser ;
        public abstract string ToString(string head);
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
        public List<DCMAbstractType> items ;
        protected TransferSyntax syntax;
        public DCMDataSet(TransferSyntax ts)   //传输语法由构造函数传入
        {
            syntax = ts;
            items = new List<DCMAbstractType>();
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
}
