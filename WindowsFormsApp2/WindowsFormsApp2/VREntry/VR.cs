using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.VREntry
{
    abstract class VR
    {
        //一共有两类:LE,BE,这个需要传递flag,还有是否为字符串,这一类为是否传递length,需要传递length的类,不需要传递字符串
        //但是需要传递length的类,不需要传递flag
        //即为,文本型不用传递LE,BE,需要传递length,而数值型,不需要传递length但是需要传递flag
        //但是sq需要传输语法和length
        //ValueEncoding应该只提供一个借口,而不需要判断类型;
        //所以提供的借口如下:
        //做好使用构造函数接传递值,来使调用方法不需要传值
        //将文本型和数值型不做判断,以为如果要判断,则

        public int length;

        public VR(Rule rule, int length)
        {
            this.length = length;

        }

        public abstract string ValueEncoding();
       
        // public abstract string ValueEncoding(byte[] buff, int i,int flag);
    }
}