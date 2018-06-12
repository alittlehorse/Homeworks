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
            ushort gtag = GetUInt16(data, ref idx);

            return gtag;
        }
        public ushort GetElementTag(byte[] data, ref uint idx)
        {
            ushort etag = GetUInt16(data, ref idx);

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
            //隐式VR
            if (syntax.isExplicit == false )
            {
                len = GetUInt32(data, ref idx);
            }

            //显示VR
            else if (syntax.isExplicit == true)
            {

                len = GetUInt16(data, ref idx);
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
            if (lenth != 0)
            {
                byte[] buff = ArrayHelper.SplitArray(data, idx, lenth + idx - 1);
                idx += lenth;
                return buff;
            }
            else
            {
                return null;
            }
        }
        public abstract byte[] WriteValue<T>(T[] val);
        //ReadValue方法和GetValue方法是两个不同的方法
        //ReadValue方法返回各自传输语法中的值
        //而GetValue返回的是byte[]
        public abstract T[] ReadValue<T>(byte[] data);
        /// <summary>
        /// 这些GetXXX(byte[] data)系列的方法,传递进来的byte[]是已经切割好的只剩下Value未解出的原数组
        /// 并不改变idx
        /// </summary>
        /// <param name="data">已经切割后的byte[]数组</param>
        /// <returns></returns>
        public abstract String GetString(byte[] data, String head);
        public UInt16 GetUInt16(byte[] data)
        {
            UInt16 number = 0;
            if (syntax.isBE == false)
            {
                number = (ushort)(data[0] + data[ 1] * 256);
            }
            if (syntax.isBE == true)
            {
                number = (ushort)(data[0] * 256 + data[1]);
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
            if (syntax.isBE == false)
            {
                number = (Int16)(data[0] + data[1] * 256);
            }
            if (syntax.isBE == true)
            {
                number = (Int16)(data[0] * 256 + data[1]);
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
                return "";
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
            if (syntax.isBE == false)
            {
                number = (ushort)(data[idx] + data[idx + 1] * 256);
            }
            if (syntax.isBE == true)
            {
                number = (ushort)(data[idx] * 256 + data[idx + 1]);
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
        public Int32 GetInt32(byte[] data,ref uint idx)
        {
            Int32 number = 0;
            if (syntax.isBE == false) { number = BitConverter.ToInt32(data, (int)idx); }
            else
            {
                Array.Reverse(data);
                number = BitConverter.ToInt32(data, (int)idx);
            }
            idx += 4;
            return number;
        }
        public Int16 GetInt16(byte[] data,ref uint idx)
        {
            Int16 number = 0;
            if (syntax.isBE == false)
            {
                number = (Int16)(data[idx] + (data[idx+1]<<8));
            }
            if (syntax.isBE == true)
            {
                number = (Int16)((data[idx]<<8) + data[idx+1]);
            }
            idx += 2;
            return number;
        }

        //现在还用不到这个方法
        public UInt64 GetUInt64(byte[] data, ref uint idx)
        {
            UInt64 number = 0;
            if (syntax.isBE == false) { number = BitConverter.ToUInt64(data, (int)idx); }
            else
            {
                byte[] buff = ArrayHelper.SplitArray(data, idx, idx + 7);
                Array.Reverse(buff);
                number = BitConverter.ToUInt64(buff, 0);
            }
            idx += 8;
            return number;
        }
        public Int64 GetInt64(byte[] data, ref uint idx)
        {
            Int64 number = 0;
            if (syntax.isBE == false) { number = BitConverter.ToInt64(data, (int)idx); }
            else
            {
                byte[] buff = ArrayHelper.SplitArray(data, idx, idx + 7);
                Array.Reverse(buff);
                number = BitConverter.ToInt64(buff, 0);
            }
            idx += 8;
            return number;
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
        public override T[] ReadValue<T>(byte[] data)
        {
            if (typeof(T) == typeof(UInt32))
            {
                UInt32[] val = new UInt32[1];
                val[0] = GetUInt32(data);
                return val as T[];
            }
            throw new NotSupportedException();
        }
        public override byte[] WriteValue<T>(T[] val)
        {
            if (typeof(T) == typeof(UInt32))
            {
                UInt32[] vals = val as UInt32[];
                //val的值只在val[0]中,因为他是强制转化为数组
                byte[] data = BitConverter.GetBytes(vals[0]);
                if (syntax.isBE)
                {
                    Array.Reverse(data);
                }
                return data;
            }
            throw new NotSupportedException();
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
        public override T[] ReadValue<T>(byte[] data)
        {
            if (typeof(T) == typeof(UInt16))
            {
                UInt16[] val = new UInt16[1];
                val[0] = GetUInt16(data);
                return val as T[];
            }
            throw new NotSupportedException();
        }
        public override byte[] WriteValue<T>(T[] val)
        {
            if (typeof(T) == typeof(UInt16))
            {
                UInt16[] vals = val as UInt16[];
                //val的值只在val[0]中,因为他是强制转化为数组
                byte[] data = BitConverter.GetBytes(vals[0]);
                if (syntax.isBE)
                {
                    Array.Reverse(data);
                }
                return data;
            }
            throw new NotSupportedException();
        }
    }
    //AS AgeString 是String类型
    public class AS : VR
    {
        public AS(TransferSyntax syntax) : base(syntax) { }
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
//DA是Date类型
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
        public override T[] ReadValue<T>(byte[] data)
        {
            if (typeof(T) == typeof(DateTime))
            {
                String dataString = GetString(data, "");
                DateTime[] vals = new DateTime[1];
                vals[0] = Convert.ToDateTime(dataString);
                return vals as T[];
            }
            throw new NotSupportedException();
        }
        public override byte[] WriteValue<T>(T[] val)
        {
            if (typeof(T) == typeof(DateTime))
            {
                DateTime[] vals = val as DateTime[];
                String temp = vals[0].ToString().Replace("-", "").Substring(0,8);
                byte[] data = Encoding.Default.GetBytes(temp);
                return data;
            }
            throw new NotSupportedException();
        }
    }
//Decimal String
    public class DS : VR
    {
        public DS(TransferSyntax syntax) : base(syntax) { }
        public override string GetString(byte[] data, String head)
        {
            String str = Encoding.Default.GetString(data, 0, data.Length);
            return head + str;
        }
        public override T[] ReadValue<T>(byte[] data)
        {
            if (typeof(T) == typeof(String))
            {
                String[] vals = new String[1];
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
                String vals = val as String;
                byte[] data = Encoding.Default.GetBytes(vals);
                return data;
            }
            throw new NotSupportedException();
        }
    }
//Float Point Double
    public class FD : VR
    {
        public FD(TransferSyntax syntax) : base(syntax) { }
        public override string GetString(byte[] data, String head)
        {
            return head+GetDouble(data).ToString();
        }
        public override T[] ReadValue<T>(byte[] data)
        {
            if (typeof(T) == typeof(Double))
            {
                Double[] val = new Double[1];
                val[0] = GetDouble(data);
                return val as T[];
            }
            throw new NotSupportedException();
        }
        public override byte[] WriteValue<T>(T[] val)
        {
            if (typeof(T) == typeof(Double))
            {
                Double[] vals = val as Double[];
                byte[] data = BitConverter.GetBytes(vals[0]);
                if (syntax.isBE)
                {
                    Array.Reverse(data);
                }
                return data;
            }
            throw new NotSupportedException();
        }

    }
//DateTime
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
        public override T[] ReadValue<T>(byte[] data)
        {
            if (typeof(T) == typeof(DateTime))
            {
                String dataString = GetString(data, "");
                DateTime[] val = new DateTime[1];
                val[0] = Convert.ToDateTime(dataString);
                return val as T[];
            }
            throw new NotSupportedException();
        }
        public override byte[] WriteValue<T>(T[] val)
        {
            if (typeof(T) == typeof(DateTime))
            {
                DateTime[] vals = val as DateTime[];
                //转化为时间戳
                String temp = vals[0].ToString().Replace("-", "").Replace(":","").Replace(" ","");
                byte[] data = Encoding.Default.GetBytes(temp);
                return data;
            }
            throw new NotSupportedException();
        }
    }

// Signed Short

    public class SS : VR
    {
        public SS(TransferSyntax syntax) : base(syntax) { }
        public override string GetString(byte[] data, String head)
        {
            return head+GetInt16(data).ToString();
        }
        public override T[] ReadValue<T>(byte[] data)
        {
            if (typeof(T) == typeof(Int16))
            {
                Int16[] val = new Int16[1];
                val[0] = GetInt16(data);
                return val as T[];
            }
            throw new NotSupportedException();
        }
        public override byte[] WriteValue<T>(T[] val)
        {
            if (typeof(T) == typeof(Int16))
            {
                Int16[] vals = val as Int16[];
                //val的值只在val[0]中,因为他是强制转化为数组
                byte[] data = BitConverter.GetBytes(vals[0]);
                if (syntax.isBE)
                {
                    Array.Reverse(data);
                }
                return data;
            }
            throw new NotSupportedException();
        }
    }
//Float Point Single
    public class FS : VR
    {
        public FS(TransferSyntax syntax) : base(syntax) { }
        public override string GetString(byte[] data, String head)
        {
            return head+GetSingle(data).ToString();
        }
        public override T[] ReadValue<T>(byte[] data)
        {
            if (typeof(T) == typeof(Single))
            {
                Single[] val = new Single[1];
                val[0] = GetSingle(data);
                return val as T[];
            }
            throw new NotSupportedException();
        }
        public override byte[] WriteValue<T>(T[] val)
        {
            if (typeof(T) == typeof(Single))
            {
                Single[] vals = val as Single[];
                byte[] data = BitConverter.GetBytes(vals[0]);
                if (syntax.isBE)
                {
                    Array.Reverse(data);
                }
                return data;
            }
            throw new NotSupportedException();
        }
    }
//Short String <=16   
    public class SH : VR
    {
        public SH(TransferSyntax syntax) : base(syntax) { }
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
//Short Text <=1024
    public class ST : VR
    {
        public ST(TransferSyntax syntax) : base(syntax) { }
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
//LongText<=10240
    public class LT : VR
    {
        public LT(TransferSyntax syntax) : base(syntax) { }
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
 //Application Entity  
    public class AE : VR
    {
        public AE(TransferSyntax syntax) : base(syntax) { }
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
 //Code String   
    public class CS : VR
    {
        public CS(TransferSyntax syntax) : base(syntax) { }
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
                //还存在字符串数组吗?
                String val = "";
                //引用自身的GetString方法
                val = GetString(data, "");
                return val as T[];
            }
            throw new NotSupportedException();
        }
        //String类型不用管是否为BE或者LE
        public override byte[] WriteValue<T>(T[] val)
        {
            if (typeof(T) == typeof(String))
            {
                String vals = val as String;
                byte[] data = Encoding.Default.GetBytes(vals);
                return data;
            }
            throw new NotSupportedException();
        }
    }
 //Integer String
    public class IS : VR
    {
        public IS(TransferSyntax syntax) : base(syntax) { }
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
                //还存在字符串数组吗?
                String val = "";
                //引用自身的GetString方法
                val = GetString(data, "");
                return val as T[];
            }
            throw new NotSupportedException();
        }
        //String类型不用管是否为BE或者LE
        public override byte[] WriteValue<T>(T[] val)
        {
            if (typeof(T) == typeof(String))
            {
                String vals = val as String;
                byte[] data = Encoding.Default.GetBytes(vals);
                return data;
            }
            throw new NotSupportedException();
        }
    }
//Signed Long
    public class SL : VR
    {
        public SL(TransferSyntax syntax) : base(syntax) { }
        public override string GetString(byte[] data, String head)
        {
            return head+GetInt32(data).ToString();
        }
        public override T[] ReadValue<T>(byte[] data)
        {
            if (typeof(T) == typeof(Int32))
            {
                Int32[] val = new Int32[1];
                val[0] = GetInt32(data);
                return val as T[];
            }
            throw new NotSupportedException();
        }
        public override byte[] WriteValue<T>(T[] val)
        {
            if (typeof(T) == typeof(Int32))
            {
                Int32[] vals = val as Int32[];
                //val的值只在val[0]中,因为他是强制转化为数组
                byte[] data = BitConverter.GetBytes(vals[0]);
                if (syntax.isBE)
                {
                    Array.Reverse(data);
                }
                return data;
            }
            throw new NotSupportedException();
        }
    }

 //Time  
    public class TM : VR
    {
        public TM(TransferSyntax syntax) : base(syntax) { }
        public override string GetString(byte[] data, String head)
        {
            String s = Encoding.Default.GetString(data, 0, data.Length);
            int hour = int.Parse(s.Substring(0, 2));
            int minute = int.Parse(s.Substring(2, 2));
            int second = int.Parse(s.Substring(4, 2));
            string resualt = hour + ":" + minute + ":" + second;
            return head + resualt;
        }
        public override T[] ReadValue<T>(byte[] data)
        {
            if (typeof(T) == typeof(DateTime))
            {
                String dataString = GetString(data, "");
                DateTime[] vals = new DateTime[1];
                vals[0] = Convert.ToDateTime(dataString);
                return vals as T[];
            }
            throw new NotSupportedException();
        }
        public override byte[] WriteValue<T>(T[] val)
        {
            if (typeof(T) == typeof(DateTime))
            {
                DateTime[] vals = val as DateTime[];
                String temp = vals[0].ToString().Replace("-", "").Replace(":","").Replace(" ","").Substring(8, 6);
                byte[] data = Encoding.Default.GetBytes(temp);
                return data;
            }
            throw new NotSupportedException();
        }
    }
/// <summary>
/// unique Identifier 
/// Length:<=64
/// </summary>
    public class UI : VR
    {
        public UI(TransferSyntax syntax) : base(syntax) { }
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
    /// <summary>
    /// Long String
    /// Length:<=64
    /// </summary>
    public class LO : VR
    {
        public LO(TransferSyntax syntax) : base(syntax)
        {

        }
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
    /// <summary>
    /// 特殊类,标志为私有类
    /// </summary>
    public class TS:VR
    {
        public TS(TransferSyntax syntax) : base(syntax)
        {

        }
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
/// <summary>
/// Person Name
/// Length:<=64
/// </summary>
    public class PN : VR
    {
        public PN(TransferSyntax syntax) : base(syntax)
        {

        }
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
/// <summary>
/// Floating Point Single
/// Length:=8
/// </summary>
    public class FL : VR
    {
        public FL(TransferSyntax syntax) : base(syntax) { }
        public override string GetString(byte[] data, String head)
        {
            return head + GetSingle(data).ToString();
        }
        public override T[] ReadValue<T>(byte[] data)
        {
            if (typeof(T) == typeof(Single))
            {
                Single[] val = new Single[1];
                val[0] = GetSingle(data);
                return val as T[];
            }
            throw new NotSupportedException();
        }
        public override byte[] WriteValue<T>(T[] val)
        {
            if (typeof(T) == typeof(Single))
            {
                Single[] vals = val as Single[];
                byte[] data = BitConverter.GetBytes(vals[0]);
                if (syntax.isBE)
                {
                    Array.Reverse(data);
                }
                return data;
            }
            throw new NotSupportedException();
        }
    }

}
