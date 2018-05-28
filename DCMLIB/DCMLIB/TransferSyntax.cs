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
        private string encodeVR(string s)
        {
            DicomDictonaryEntry dd = new DicomDictonaryEntry();
            DicomDictionary dde = new DicomDictionary();
            dd = dde.GetEntry(s);
            string vr = dd.VR;
            return vr;
        }

        public virtual DCMAbstractType Decode(byte[] data, ref uint idx)
        {
            DCMDataElement element = new DCMDataElement();
            //读取TAG
            element.gtag = vrdecoder.GetGroupTag(data, ref idx);
            element.etag = vrdecoder.GetElementTag(data, ref idx);
            string tag = "(" + element.gtag.ToString("X4") + "," + element.etag.ToString("X4") + ")";
            if (tag == "(FFFE,E000)")
            {
                DCMDataItem sqitem = new DCMDataItem(this);
                uint length = vrdecoder.GetUInt32(data, ref idx);
                //element.length = length;
                //想了一下这句,还是不要了吧,因为谁知道是个什么鬼呢?
                uint offset = idx;
                //idx小于value长度时,不断地调用Decode方法来解锁;
                while (idx - offset < length)
                {
                    //递归,不断地解码
                    //解出Tag不为DataElemt类型时,重复的递归
                    DCMAbstractType sqelem = Decode(data, ref idx);
                    if (sqelem.gtag == 0xfffe && sqelem.etag == 0xe00d) break;//这句有问题
                    sqitem.items.Add(sqelem);
                }
                return sqitem;
            }
            else if (tag == "(FFFE,E00D)")  //序列结束标记
            {
                element.vr = "UL";//回归初始状态
                element.length = vrdecoder.GetUInt32(data, ref idx); 
                //不能用GetLength
                //且不用解出Value
                return element;
            }
            else if (tag == "(FFFE,E0DD)")
            {
                element.vr = "UL";//回归初始状态
                element.length = vrdecoder.GetUInt32(data, ref idx); 
                //不能用GetLength
                //不用解出Value类了;
                return element;
            }


            //查数据字典得到VR,Name,VM
            element.vr = vrdecoder.GetVR(data, ref idx);
            DicomDictonaryEntry entry = dictionary.GetEntry(tag);
            if (entry != null)
            {
                element.vr = entry.VR;
                element.name = entry.Keyword;
                element.vm = entry.VM;
            }
            else if (element.vr == "" && element.etag == 0)
                element.vr = "US";
            //
            vrdecoder = vrfactory.GetVR(element.vr);
            element.vrparser = vrdecoder;
            //读取值长度
            element.length = vrdecoder.GetLength(data, ref idx,element.vr);
            //读取值
            element.value = vrdecoder.GetValue(data, ref idx, element.length);
            return element;
        }
    }




    public class TransferSyntaxes
    {
        public TransferSyntax[] TSs = new TransferSyntax[3];
        public TransferSyntaxes()
        {
            TSs[0] = new ImplicitVRLittleEndian();
            TSs[1] = new ExplicitVRLittleEndian();
            TSs[2] = new ExplicitVRBigEndian();
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

