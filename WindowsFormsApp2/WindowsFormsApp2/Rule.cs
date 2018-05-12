using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    /// <summary>
    /// Rule类,来承接传来的byte[]数组和显示或隐式,LE或BE,以及数组索引指针
    /// </summary>
    class Rule
    {
        //ie,显式或者隐式
        //flag,LE或者BE

        public int ie { set; get; }
        public int flag { set; get; }
        public byte[] buff { set; get; }
        //当前数组位置
        public int i { set; get; }
    }
}
