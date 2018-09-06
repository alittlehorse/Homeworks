using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCMLIB
{
    public abstract class TransferSyntax
    {
        public Boolean isBE;

        public Boolean isExplicit;

        public string name;

        public string uid;

        protected VR vrdecoder;

        private DicomDictionary dictionary;

        protected VRFactory vrfactory;

        public TransferSyntax()
        {
            //初始化数据字典类对象
            dictionary = new DicomDictionary();

            vrfactory = new VRFactory(this);

            vrdecoder = new UL(this);
        }
        private string encodeVR(ushort gtag,ushort etag)
        {
            DicomDictonaryEntry dd = new DicomDictonaryEntry();
            DicomDictionary dde = new DicomDictionary();
            dd = dde.GetEntry(gtag,etag);
            string vr = dd.VR;
            return vr;
        }

        public virtual DCMAbstractType Decode(byte[] data, ref uint idx)
        {
            DCMDataElement element = new DCMDataElement();
            //读取TAG
            element.gtag = vrdecoder.GetGroupTag(data, ref idx);
            element.etag = vrdecoder.GetElementTag(data, ref idx);
            //这一项仅仅只用于测试容易看出，Reference==0；
            string tag = "(" + element.gtag.ToString("X4") + "," + element.etag.ToString("X4") + ")";

            if (element.gtag == 0xfffe && element.etag == 0xe000)
            {
                DCMDataItem sqitem = new DCMDataItem(this);
                sqitem.gtag = element.gtag;
                sqitem.etag = element.etag;
                uint length = vrdecoder.GetUInt32(data, ref idx);
                sqitem.length = length;
                uint offset = idx;
                //idx小于value长度时,不断地调用Decode方法来解锁;
                while (idx - offset < length)
                {
                    //递归,不断地解码
                    //解出Tag不为DataElemt类型时,重复的递归
                    DCMAbstractType sqelem = Decode(data, ref idx);
                    if (sqelem.gtag == 0xfffe && sqelem.etag == 0xe00d) break;
                    sqitem[0] = sqelem;
                }
                return sqitem;
            }
            else if (element.gtag == 0xfffe && element.etag == 0xe00d)  //序列结束标记
            {
                element.vr = "UL";//回归初始状态
                element.length = vrdecoder.GetUInt32(data, ref idx);
                //不能用GetLength
                //且不用解出Value
                return element;
            }
            else if (element.gtag == 0xfffe && element.etag == 0xe0dd)
            {
                element.vr = "UL";//回归初始状态
                element.length = vrdecoder.GetUInt32(data, ref idx);
                //不能用GetLength
                //不用解出Value类了;
                return element;
            }

            //查数据字典得到VR,Name,VM
            element.vr = vrdecoder.GetVR(data, ref idx);
            //0002系类文件头并没有在DicomDirationay内有定义
            DicomDictonaryEntry entry = dictionary.GetEntry(element.gtag, element.etag);
            if (entry != null)
            {
                element.vr = entry.VR;
                element.name = entry.Keyword;
                element.vm = entry.VM;
            }
            else if (element.vr == "" && element.etag == 0)
                element.vr = "US";

            if (element.vr == "OB or OW")
            {
                //在上一层找items[DicomTags.BitsAllocated];但是上层对下层是完全不透明的;怎么办
                element.vr = "OW";
            }
            try
            {
                vrdecoder = vrfactory.GetVR(element.vr);
                element.vrparser = vrdecoder;
                //读取值长度
                element.length = vrdecoder.GetLength(data, ref idx, element.vr);
                //读取值
                element.value = vrdecoder.GetValue(data, ref idx, element.length);
                return element;
            }
            catch
            {
                throw;
            }
           
        }
    }




    public class TransferSyntaxes
    {
        public List<TransferSyntax> TSs = new List<TransferSyntax>();
        public TransferSyntaxes()
        {
            TSs.Add(new ImplicitVRLittleEndian());
            TSs.Add( new ExplicitVRLittleEndian());
            TSs.Add( new ExplicitVRBigEndian());
        }
        /// <summary>
        /// TransferSyntaxs的索引,用来通过uid返回对应的TransferSyntax类型
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        public TransferSyntax this[String uid]
        {
            get {
                TransferSyntax syn = TSs.Find(tsyn => tsyn.uid == uid);
                return syn;
            }
        }
    }




    public class ImplicitVRLittleEndian : TransferSyntax
    {
        public ImplicitVRLittleEndian()
        {
            isExplicit = false;
            isBE = false;
            uid = "1.2.840.10008.1.2";
            name = "implicitVRLittleEndian";
        }
    }



    public class ExplicitVRLittleEndian : TransferSyntax
    {
        public ExplicitVRLittleEndian()
        {
            isExplicit = true;
            isBE = false;
            uid = "1.2.840.10008.1.2.1";
            name = "ExplicitVRLittleEndian";
        }
    }


    public class ExplicitVRBigEndian : TransferSyntax
    {
        public ExplicitVRBigEndian()
        {
            isExplicit = true;
            isBE = true;
            uid = "1.2.840.10008.1.2.2";
            name = "ExplicitVRBigEndian";
        }
    }


}

