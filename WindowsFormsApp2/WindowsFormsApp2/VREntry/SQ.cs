using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.EncodeField;

/// <summary>
/// SQ算法设计:将所有的Item装到List<item>里面
/// 在length为FFFF时,遇到FFFE,E0DD结束
/// 当length确定时,for循环,用Encode解出其中的值
/// 在(FFFE,E000)条目开始
/// 在(FFFE,E00D)条目结束
/// 这个需要用递归来实现,来不断的调用自身
/// 临界条件是(FFFE,E00D)或者length = 0
/// 调用条件是,
/// </summary>
namespace WindowsFormsApp2.VREntry
{
    class SQ : VR
    {
        Rule rule;
        public int temp;
        List<Item> list = new List<Item>();
        public SQ(Rule rule, int length):base(rule,length)
        {
            temp = rule.i;
            this.rule = rule;
        }
        public override string ValueEncoding()
        {
            
            while (rule.i < length+temp)
            {
                //先判断出Tag的值是否为那三个值;
                string tag = "";
                if (rule.ie == 1)
                {
                    ushort gtag = (ushort)(rule.buff[rule.i] * 256 + rule.buff[rule.i + 1]);
                    ushort etag = (ushort)(rule.buff[rule.i + 2] * 256 + rule.buff[rule.i + 3]);
                    tag = "(" + gtag.ToString("X4") + "," + etag.ToString("X4") + ")";
                }
                else
                {
                    ushort gtag = (ushort)(rule.buff[rule.i]  + rule.buff[rule.i + 1] * 256);
                    ushort etag = (ushort)(rule.buff[rule.i + 2]  + rule.buff[rule.i + 3] * 256);
                    tag = "(" + gtag.ToString("X4") + "," + etag.ToString("X4") + ")";
                }

                if (tag == "(FFFE,E000)" || tag == "(FFFE,E00D)")
                {
                    Rule t_rule = new Rule();
                    t_rule.i = rule.i;
                    t_rule.buff = rule.buff;
                    
                    t_rule.ie = 0;//隐式VR

                    t_rule.flag = rule.flag;
                    Encode encode = EncodeFactory.CreateEnode(t_rule);
                    Item item = encode.encode();
                    list.Add(item);
                    rule.i = t_rule.i;
                }
                else if (tag == "(FFFE,E0DD)")
                {
                    Rule t_rule = new Rule();
                    t_rule.i = rule.i;
                    t_rule.buff = rule.buff;

                    t_rule.ie = 0;//隐式VR

                    t_rule.flag = rule.flag;
                    Encode encode = EncodeFactory.CreateEnode(t_rule);
                    Item item = encode.encode();
                    list.Add(item);
                    rule.i = t_rule.i;
                    break;
                }
                else
                {
                    Encode encode = EncodeFactory.CreateEnode(rule);
                    Item item = encode.encode();
                    list.Add(item);
                }
            }
            String str="";
            for (int i = 0; i < list.Count; i++)
            {                
               String temp_s = list[i].Tag +"\t"+  list[i].len.ToString() + "\t" + list[i].Value.Replace('\0',' ') +"\n";
               str+=temp_s;
            }

            return str;
         }
            
    }
    
}
