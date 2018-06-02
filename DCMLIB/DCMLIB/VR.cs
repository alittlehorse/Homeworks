using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace DCMLIB
{/// <summary>
/// 抽象享元类
/// </summary>
    public abstract class VR
    {
        protected TransferSyntax syntax;
        public VR(TransferSyntax syntax)
        {
            this.syntax = syntax;
        }

        /// <summary>
        /// 传递来传输语法,来根据不同的值解码
        /// </summary>
        /// <param name="data"></param>
        /// <param name="idx"></param>
        /// <returns></returns>
        public ushort GetGroupTag(byte[] data, ref uint idx)
        {
            ushort gtag = 0;
            if (syntax.isBE == false)
            {
                gtag = (ushort)(data[idx] + data[idx + 1] * 256);
            }
            if (syntax.isBE == true)
            {
                gtag = (ushort)(data[idx ] * 256 + data[idx+1]);
            }
            idx += 2;
            return gtag;
        }
        public ushort GetElementTag(byte[] data, ref uint idx)
        {
            ushort etag = 0;
            if (syntax.isBE == false)
            {
                etag = (ushort)(data[idx] + data[idx + 1] * 256);
            }
            if (syntax.isBE == true)
            {
                etag = (ushort)(data[idx ] * 256 + data[idx+1]);
            }
            idx += 2;
            return etag;
        }


        /// <summary>
        /// 取得value的字节数
        /// </summary>
        /// <param name="data">原始数组</param>
        /// <param name="idx">数组指针</param>
        /// <returns></returns>
        public virtual uint GetLength(byte[] data, ref uint idx, string vrstring)
        {
            uint len = 0;
            //默认语法
            if (syntax.isExplicit == false && syntax.isBE == false)
            {
                len = GetUInt32(data, ref idx);
            }
            //BE,隐式VR
            else if (syntax.isExplicit == false && syntax.isBE == true)
            {
                len = GetUInt32(data, ref idx);
            }
            //LE,显示VR
            else if (syntax.isExplicit == true && syntax.isBE == false)
            {

                len = GetUInt16(data, ref idx);

            }
            //BE,显示VR
            else
            {

                len = len = GetUInt16(data, ref idx);

            }
            return len;
        }

        /// <summary>
        /// GetValue 取对应长度的byte[]
        /// 此方法在SQ里面虚写
        /// </summary>
        /// <param name="data">原始数组</param>
        /// <param name="idx"></param>
        /// <param name="lenth"></param>
        /// <returns>返回切割数组值为Value,并且指针指向长度结束处</returns>
        public virtual byte[] GetValue(byte[] data, ref uint idx, uint lenth)
        {

            byte[] buff = ArrayHelper.SplitArray(data, idx, lenth + idx - 1);
            idx += lenth;
            return buff;
        }
        /// <summary>
        /// 这些Get系列的方法,传递进来的byte[]是已经切割好的只剩下Value未解出的原数组
        /// </summary>
        /// <param name="data">已经切割后的byte[]数组</param>
        /// <returns></returns>
        public abstract String GetString(byte[] data, String head);
        public UInt16 GetUInt16(byte[] data)
        {
            UInt16 number = 0;
            if (syntax.isBE == false) { number = BitConverter.ToUInt16(data, 0); }
            else
            {
                Array.Reverse(data);
                number = BitConverter.ToUInt16(data, 0);
            }
            return number;
        }
        public UInt32 GetUInt32(byte[] data)
        {
            UInt32 number = 0;
            if (syntax.isBE == false) { number = BitConverter.ToUInt32(data, 0); }
            else
            {
                Array.Reverse(data);
                number = BitConverter.ToUInt32(data, 0);
            }
            return number;
        }
        public Double GetDouble(byte[] data)
        {
            Double number = 0;
            if (syntax.isBE == false) { number = BitConverter.ToDouble(data, 0); }
            else
            {
                Array.Reverse(data);
                number = BitConverter.ToDouble(data, 0);
            }
            return number;
        }
        public Int16 GetInt16(byte[] data)
        {
            Int16 number = 0;
            if (syntax.isBE == false) { number = BitConverter.ToInt16(data, 0); }
            else
            {
                Array.Reverse(data);
                number = BitConverter.ToInt16(data, 0);
            }
            return number;
        }
        public Single GetSingle(byte[] data)
        {
            Single number = 0;
            if (syntax.isBE == false) { number = BitConverter.ToSingle(data, 0); }
            else
            {
                Array.Reverse(data);
                number = BitConverter.ToSingle(data, 0);
            }
            return number;
        }
        public Int32 GetInt32(byte[] data)
        {
            Int32 number = 0;
            if (syntax.isBE == false) { number = BitConverter.ToInt32(data, 0); }
            else
            {
                Array.Reverse(data);
                number = BitConverter.ToInt32(data, 0);
            }
            return number;
        }
        public String GetVR(byte[] data, ref uint idx)
        {
            if (syntax.isExplicit == true)
            {
                String str = Encoding.Default.GetString(data, (int)idx, 2);
                idx += 2;
                return str;
            }
            else
            {
                return " ";
            }
        }
        /// <summary>
        /// 解码2字节length时用到此方法
        /// </summary>
        /// <param name="data"></param>
        /// <param name="idx">结束后idx会加上2</param>
        /// <returns></returns>
        public UInt16 GetUInt16(byte[] data,ref uint idx)
        {
            UInt16 number = 0;
            Int32 temp_idx = int.Parse(idx.ToString());
            if (syntax.isBE == false) { number = BitConverter.ToUInt16(data, temp_idx); }
            else
            {
               byte[] buff =  ArrayHelper.SplitArray(data, idx, idx + 1);
                Array.Reverse(buff);
                number = BitConverter.ToUInt16(buff, 0);
            }
            idx += 2;
            return number;
        }
        /// <summary>
        /// 用于解码6字节length是用到此方法
        /// </summary>
        /// <param name="data"></param>
        /// <param name="idx">内部处理会加上6</param>
        /// <returns></returns>
        public UInt64 GetUInt64(byte[] data, ref uint idx)
        {
            UInt64 number = 0;
            Int32 temp_idx = int.Parse(idx.ToString());
            if (syntax.isBE == false) { number = BitConverter.ToUInt64(data, temp_idx); }
            else
            {
                byte[] buff = ArrayHelper.SplitArray(data, idx, idx + 5);
                Array.Reverse(buff);
                number = BitConverter.ToUInt64(buff, 0);
            }
            idx += 6;
            return number;
        }
        /// <summary>
        /// 用于解码4字节length是用到此方法
        /// </summary>
        /// <param name="data"></param>
        /// <param name="idx">内部处理会加上4</param>
        /// <returns></returns>
        public UInt32 GetUInt32(byte[] data, ref uint idx)
        {
            UInt32 number = 0;
            Int32 temp_idx = int.Parse(idx.ToString());
            if (syntax.isBE == false) { number = BitConverter.ToUInt32(data, temp_idx); }
            else
            {
                byte[] buff = ArrayHelper.SplitArray(data, idx, idx + 3);
                Array.Reverse(buff);
                number = BitConverter.ToUInt32(buff, 0);
            }
            idx += 4;
            return number;
        }
        
    }







    /// <summary>
    /// longVR继承自VR,作为OB OF OW SQ UT UN等具体vr子类的直接基类
    /// </summary>
    /// 
    public abstract class LongVR : VR
    {
        public LongVR(TransferSyntax syntax) : base(syntax) { }

        public override uint GetLength(byte[] data, ref uint idx, string vrstring)
        {
            uint len = 0;
            //默认语法
            if (syntax.isExplicit == false && syntax.isBE == false)
            {
                len = GetUInt32(data, ref idx);

            }
            //BE,隐式VR
            else if (syntax.isExplicit == false && syntax.isBE == true)
            {
                len = GetUInt32(data, ref idx);

            }
            //LE,显示VR
            else if (syntax.isExplicit == true && syntax.isBE == false)
            {

                idx += 2;
                len = GetUInt32(data, ref idx);


            }
            //BE,显示VR
            else
            {
                idx += 2;
                len = GetUInt32(data,ref idx);

            }
            return len;
        }

    }
    public class UL : VR
    {
        public UL(TransferSyntax syntax) : base(syntax) { }
        public override string GetString(byte[] data, String head)
        {
            String str = GetUInt32(data).ToString();
            return head + str;
        }
    }
    public class US : VR
    {
        public US(TransferSyntax syntax) : base(syntax) { }
        public override string GetString(byte[] data, String head)
        {
            String str = GetUInt16(data).ToString();
            return head + str;
        }

    }

    public class AS : VR
    {
        public AS(TransferSyntax syntax) : base(syntax) { }
        public override string GetString(byte[] data, String head)
        {
            String str = Encoding.Default.GetString(data, 0, data.Length);
            return head + str;
        }

    }

    public class DA : VR
    {
        public DA(TransferSyntax syntax) : base(syntax) { }
        public override string GetString(byte[] data, String head)
        {
            String s = Encoding.Default.GetString(data, 0, data.Length);
            int year = int.Parse(s.Substring(0, 4));
            int month = int.Parse(s.Substring(4, 2));
            int day = int.Parse(s.Substring(6, 2));
            string resualt = year + "-" + month + "-" + day;
            return head + resualt;
        }

    }

    public class DS : VR
    {
        public DS(TransferSyntax syntax) : base(syntax) { }
        public override string GetString(byte[] data, String head)
        {
            String str = Encoding.Default.GetString(data, 0, data.Length);
            return head + str;
        }
    }

    public class FD : VR
    {
        public FD(TransferSyntax syntax) : base(syntax) { }
        public override string GetString(byte[] data, String head)
        {
            return head+GetDouble(data).ToString();

        }
    }
    public class DT : VR
    {
        public DT(TransferSyntax syntax) : base(syntax) { }
        public override string GetString(byte[] data, String head)
        {
            String s = Encoding.Default.GetString(data, 0, data.Length);
            int year = int.Parse(s.Substring(0, 4));
            int month = int.Parse(s.Substring(4, 2));
            int day = int.Parse(s.Substring(6, 2));
            int hour = int.Parse(s.Substring(8, 2));
            int minute = int.Parse(s.Substring(10, 2));
            int second = int.Parse(s.Substring(12, 2));
            string resualt = year + "-" + month + "-" + day + ":" + hour + ":" + minute + ":" + second;
            return head + resualt;
        }

    }
    public class SS : VR
    {
        public SS(TransferSyntax syntax) : base(syntax) { }
        public override string GetString(byte[] data, String head)
        {
            return head+GetInt16(data).ToString();
        }
    }
    /// <summary>
    /// 解码解得单浮点Single
    /// </summary>
    public class FS : VR
    {
        public FS(TransferSyntax syntax) : base(syntax) { }
        public override string GetString(byte[] data, String head)
        {
            return head+GetSingle(data).ToString();
        }
    }
    //OB,OW,OF,写的方法有问题
    /// <summary>
    /// 解码解得byte
    /// </summary>
    public class OB : LongVR
    {
        public OB(TransferSyntax syntax) : base(syntax) { }
        public override string GetString(byte[] data, String head)
        {
            return head+ Encoding.Default.GetString(data, 0, data.Length);
        }
    }
    /// <summary>
    /// 解Value的得到Single
    /// </summary>
    public class OF : LongVR
    {
        public OF(TransferSyntax syntax) : base(syntax) { }
        public override string GetString(byte[] data, String head)
        {
            return head+GetSingle(data).ToString();
        }
    }
    public class OW : LongVR
    {
        public OW(TransferSyntax syntax) : base(syntax) { }
        public override string GetString(byte[] data, String head)
        {
            return head+GetDouble(data).ToString();
        }
    }
    public class UN : LongVR
    {
        public UN(TransferSyntax syntax) : base(syntax) { }
        public override string GetString(byte[] data, String head)
        {
            return head+ Encoding.Default.GetString(data, 0, data.Length);
        }
    }
    public class UT : LongVR
    {
        public UT(TransferSyntax syntax) : base(syntax) { }
        public override string GetString(byte[] data, String head)
        {
            return head+Encoding.Default.GetString(data, 0, data.Length);
        }
    }
    public class SH : VR
    {
        public SH(TransferSyntax syntax) : base(syntax) { }
        public override string GetString(byte[] data, String head)
        {
            return head+Encoding.Default.GetString(data, 0, data.Length);
        }
    }

    public class ST : VR
    {
        public ST(TransferSyntax syntax) : base(syntax) { }
        public override string GetString(byte[] data, String head)
        {
            return head+Encoding.Default.GetString(data, 0, data.Length);
        }
    }

    public class LT : VR
    {
        public LT(TransferSyntax syntax) : base(syntax) { }
        public override string GetString(byte[] data, String head)
        {
            return head+Encoding.Default.GetString(data, 0, data.Length);
        }
    }
   
    public class AE : VR
    {
        public AE(TransferSyntax syntax) : base(syntax) { }
        public override string GetString(byte[] data, String head)
        {
            return head+Encoding.Default.GetString(data, 0, data.Length);
        }
    }
    
    public class CS : VR
    {
        public CS(TransferSyntax syntax) : base(syntax) { }
        public override string GetString(byte[] data, String head)
        {
            return head+Encoding.Default.GetString(data, 0, data.Length);
        }
    }
    public class IS : VR
    {
        public IS(TransferSyntax syntax) : base(syntax) { }
        public override string GetString(byte[] data, String head)
        {
            String str = Encoding.Default.GetString(data, 0, data.Length);
            return head + str;
        }
    }

    public class SL : VR
    {
        public SL(TransferSyntax syntax) : base(syntax) { }
        public override string GetString(byte[] data, String head)
        {
            return head+GetInt32(data).ToString();
        }
    }

    public class SQ : LongVR
    {
        public SQ(TransferSyntax syntax) : base(syntax) { }
        /// <summary>
        /// SQ必须重写GetValue方法,因为传进来的参数length是由前边的Getlength方法获取的
        /// 而SQ可能取值FFFF
        /// </summary>
        /// <param name="data"></param>
        /// <param name="idx"></param>
        /// <param name="length">传入长度数值</param>
        /// <returns></returns>
        public override byte[] GetValue(byte[] data, ref uint idx, uint length)
        {
            uint offset = idx;
            DCMDataSequence sq = new DCMDataSequence(syntax);
            while (idx - offset < length)
            {
                DCMAbstractType item = syntax.Decode(data, ref idx);
                string tag = "(" + item.gtag.ToString("X4") + "," + item.etag.ToString("X4") + ")";
                if (tag== "(FFFE,E0DD)")
                    break;
                else
                    sq[0]= (DCMDataItem)item;
            }
            GCHandle handle = GCHandle.Alloc(sq);
            IntPtr ptr = GCHandle.ToIntPtr(handle);
            return BitConverter.GetBytes(ptr.ToInt64());
        }
        public override string GetString(byte[] data, String head)
        {
            IntPtr ptr = new IntPtr(BitConverter.ToInt64(data, 0));
            GCHandle handle = GCHandle.FromIntPtr(ptr);
            DCMDataSequence sq = (DCMDataSequence)handle.Target;
            return sq.ToString(head + ">");
        }



    }
    public class TM : VR
    {
        public TM(TransferSyntax syntax) : base(syntax) { }
        public override string GetString(byte[] data, String head)
        {
            String s = Encoding.Default.GetString(data, 0, data.Length);
            int hour = int.Parse(s.Substring(0, 2));
            int minute = int.Parse(s.Substring(2, 2));
            int second = int.Parse(s.Substring(4, 2));
            string resualt = hour + "-" + minute + "-" + second;
            return head + resualt;
        }
    }

    public class UI : VR
    {
        public UI(TransferSyntax syntax) : base(syntax) { }
        public override string GetString(byte[] data, String head)
        {
            return head+Encoding.Default.GetString(data, 0, data.Length);
        }
    }
    public class LO : VR
    {
        public LO(TransferSyntax syntax) : base(syntax)
        {

        }
        public override string GetString(byte[] data, String head)
        {
            return head+Encoding.Default.GetString(data, 0, data.Length);
        }
    }
    public class TS:VR
    {
        public TS(TransferSyntax syntax) : base(syntax)
        {

        }
        public override string GetString(byte[] data, String head)
        {
                return head+Encoding.Default.GetString(data, 0, data.Length);

        }
    }
    public class PN : VR
    {
        public PN(TransferSyntax syntax) : base(syntax)
        {

        }
        public override string GetString(byte[] data, String head)
        {
            return head + Encoding.Default.GetString(data, 0, data.Length);

        }
    }



}
