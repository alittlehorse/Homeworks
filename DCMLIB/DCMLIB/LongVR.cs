using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace DCMLIB
{
    /// <summary>
    /// longVR继承自VR,作为OB OF OW SQ UT UN等具体vr子类的直接基类
    /// </summary>
    public abstract class LongVR : VR
    {
        public LongVR(TransferSyntax syntax) : base(syntax) { }

        public override uint GetLength(byte[] data, ref uint idx, string vrstring)
        {
            uint len = 0;
            //默认语法
            if (syntax.isExplicit == false)
            {
                len = GetUInt32(data, ref idx);

            }
            //LE,显示VR
            else if (syntax.isExplicit == true )
            {
                idx += 2;
                len = GetUInt32(data, ref idx);
            }
            return len;
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
                if (item.gtag==0xfffe&&item.etag==0xe0dd)
                    break;
                else
                    sq[0] = (DCMDataItem)item;
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
        public override T[] ReadValue<T>(byte[] data)
        {
            if (typeof(T) is DCMDataSequence)
            {
                IntPtr ptr = new IntPtr(BitConverter.ToInt64(data, 0));
                GCHandle handle = GCHandle.FromIntPtr(ptr);
                DCMDataSequence[] sq = new DCMDataSequence[1];
                sq[0] = (DCMDataSequence)handle.Target;
                return sq as T[];
            }
            else
                throw new NotSupportedException();
        }

        public override byte[] WriteValue<T>(T[] val)
        {
            if (typeof(T) is DCMDataSequence)
            {
                DCMDataSequence[] sq = val as DCMDataSequence[];
                GCHandle handle = GCHandle.Alloc(sq[0]);
                IntPtr ptr = GCHandle.ToIntPtr(handle);
                return BitConverter.GetBytes(ptr.ToInt64());
            }
            else
                throw new NotSupportedException();
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
            uint i = 0;
            String result="" ;
            while (i < data.Length)
            {
                result += ((sbyte)data[i]).ToString()+"/";
                i += 1;
            }
            return head + result;
        }
        public override T[] ReadValue<T>(byte[] data)
        {
            if (typeof(T) == typeof(sbyte))
            {
                sbyte[] val = new sbyte[data.Length];
                for (int i = 0; i < val.Length; i++)
                    val[i] = (sbyte)data[i];
                return val as T[];
            }
            throw new NotSupportedException();
        }

        public override byte[] WriteValue<T>(T[] val)
        {
            if (typeof(T) == typeof(sbyte))
            {
                sbyte[] vals = val as sbyte[];
                byte[] data = new byte[vals.Length];
                for (int i = 0; i < val.Length; i++)
                {
                    //注意,无论编码还是解码,GetBytes方法得到的是LE;
                    data[i] = (byte)vals[i];
                }
                return data;
            }
           
            throw new NotSupportedException();
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
            uint i = 0;
            Int32 result = 0;
            while (i < data.Length - 1)
            {
                byte[] buff = ArrayHelper.SplitArray(data, i, i + 3);
                Int32 temp = GetInt32(buff);
                result += temp;
                i += 4;
            }
            return head + result.ToString();
        }
        public override T[] ReadValue<T>(byte[] data)
        {
            if (typeof(T) == typeof(UInt32))
            {
                UInt32[] val = new UInt32[data.Length / 4];
                uint idx = 0;
                for (int i = 0; i < val.Length; i++)
                    val[i] = GetUInt32(data, ref idx);
                return val as T[];
            }
            if (typeof(T) == typeof(Int32))
            {
                Int32[] val = new Int32[data.Length / 4];
                uint idx = 0;
                for (int i = 0; i < val.Length; i++)
                    val[i] = GetInt32(data, ref idx);
                return val as T[];
            }
            throw new NotSupportedException();
        }

        public override byte[] WriteValue<T>(T[] val)
        {
            
            if (typeof(T) == typeof(UInt32))
            {
                UInt32[] vals = val as UInt32[];
                byte[] data = new byte[vals.Length * 4];
                for (int i = 0; i < val.Length; i++)
                {                   
                    byte[] ss = BitConverter.GetBytes(vals[i]);
                    //注意,无论编码还是解码,GetBytes方法得到的是LE;
                    if (syntax.isBE) Array.Reverse(ss);
                    data[i * 4] = ss[0];
                    data[i * 4 + 1] = ss[1];
                    data[i * 4 + 2] = ss[2];
                    data[i * 4 + 3] = ss[3];
                }
                return data;
            }
            if (typeof(T) == typeof(Int32))
            {
                Int32[] vals = val as Int32[];
                byte[] data = new byte[vals.Length * 4];
                for (int i = 0; i < val.Length; i++)
                {
                    byte[] ss = BitConverter.GetBytes(vals[i]);
                    //注意,无论编码还是解码,GetBytes方法得到的是LE;
                    if (syntax.isBE) Array.Reverse(ss);
                    data[i * 4] = ss[0];
                    data[i * 4 + 1] = ss[1];
                    data[i * 4 + 2] = ss[2];
                    data[i * 4 + 3] = ss[3];
                }
                return data;
            }

            throw new NotSupportedException();
        }
        
    }
    public class OW : LongVR
        {
            public OW(TransferSyntax syntax) : base(syntax) { }
            public override string GetString(byte[] data, String head)
            {
                uint i = 0;
                Int16 result = 0;
                while (i < data.Length - 1)
                {
                    byte[] buff = ArrayHelper.SplitArray(data, i, i + 1);
                    Int16 temp = GetInt16(buff);
                    result += temp;
                    i += 2;
                }
                return head + result.ToString();
            }
            public override T[] ReadValue<T>(byte[] data)
            {
                if (typeof(T) == typeof(ushort))
                {
                    ushort[] val = new ushort[data.Length / 2];
                    uint idx = 0;
                    for (int i = 0; i < val.Length; i++)
                        val[i] = GetUInt16(data, ref idx);
                    return val as T[];
                }
                if (typeof(T) == typeof(short))
                {
                    short[] val = new short[data.Length / 2];
                    uint idx = 0;
                    for (int i = 0; i < val.Length; i++)
                        val[i] = GetInt16(data, ref idx);
                    return val as T[];
                }
                throw new NotSupportedException();
            }
            public override byte[] WriteValue<T>(T[] val)
            {
                if (typeof(T) == typeof(ushort))
                {
                    ushort[] vals = val as ushort[];
                    byte[] data = new byte[vals.Length * 2];
                    for (int i = 0; i < val.Length; i++)
                    {
                        byte[] ss = BitConverter.GetBytes(vals[i]);
                        //注意,无论编码还是解码,GetBytes方法得到的是LE;
                        if (syntax.isBE) Array.Reverse(ss);
                        data[i * 2] = ss[0];
                        data[i * 2 + 1] = ss[1];
                    }
                    return data;
                }
                if (typeof(T) == typeof(short))
                {
                    short[] vals = val as short[];
                    byte[] data = new byte[vals.Length * 2];
                    for (int i = 0; i < val.Length; i++)
                    {
                        byte[] ss = BitConverter.GetBytes(vals[i]);
                        //注意,无论编码还是解码,GetBytes方法得到的是LE;
                        if (syntax.isBE) Array.Reverse(ss);
                        data[i * 2] = ss[0];
                        data[i * 2 + 1] = ss[1];
                    }
                    return data;
                }
                throw new NotSupportedException();
            }
        }
    public class UN : LongVR
        {
            public UN(TransferSyntax syntax) : base(syntax) { }
            public override string GetString(byte[] data, String head)
            {
                if (data != null)
                {
                    return head + Encoding.Default.GetString(data, 0, data.Length);
                }
                else
                {
                    return "";
                }
            }
            public override T[] ReadValue<T>(byte[] data)
            {
                if (typeof(T) == typeof(String))
                {
                    String[] vals = new string[1];
                    //引用自身的GetString方法
                    vals[0] = GetString(data, "");
                    return vals as T[];
                }
                throw new NotSupportedException();
            }
            //String类型不用管是否为BE或者LE
            public override byte[] WriteValue<T>(T[] val)
            {
                if (typeof(T) == typeof(String))
                {
                    String[] vals = val as String[];
                    byte[] data = Encoding.Default.GetBytes(vals[0]);
                    return data;
                }
                throw new NotSupportedException();
            }
        }
    public class UT : LongVR
        {
            public UT(TransferSyntax syntax) : base(syntax) { }
            public override string GetString(byte[] data, String head)
            {
                return head + Encoding.Default.GetString(data, 0, data.Length);
            }
            public override T[] ReadValue<T>(byte[] data)
            {
                if (typeof(T) == typeof(String))
                {
                    String[] vals = new string[1];
                    //引用自身的GetString方法
                    vals[0] = GetString(data, "");
                    return vals as T[];
                }
                throw new NotSupportedException();
            }
            //String类型不用管是否为BE或者LE
            public override byte[] WriteValue<T>(T[] val)
            {
                if (typeof(T) == typeof(String))
                {
                    String[] vals = val as String[];
                    byte[] data = Encoding.Default.GetBytes(vals[0]);
                    return data;
                }
                throw new NotSupportedException();
            }
        }
}
