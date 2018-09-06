using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DCMLIB
{
    public partial class frmImage : Form
    {
        short[] owpixels { set; get; }    //OW像素缓冲区
        sbyte[] obpixels { set; get; }   //OB像素缓冲区
        DCMDataSet items { set; get; }
        ushort bs { set; get; }
        ushort hb { set; get; }

        public frmImage(DCMDataSet items)
        {
            InitializeComponent();
            this.items = items;
        }

        private void frmImage_Load(object sender, EventArgs e)
        {
            this.Width = items[DicomTags.Columns].ReadValue<ushort>()[0];
            this.Height = items[DicomTags.Rows].ReadValue<ushort>()[0];
            tsWindow.Text = items[DicomTags.WindowWidth].ReadValue<String>()[0];
            tsLevel.Text = items[DicomTags.WindowCenter].ReadValue<String>()[0];
            bs = items[DicomTags.BitsStored].ReadValue<ushort>()[0];//多少位
            hb = items[DicomTags.HighBit].ReadValue<ushort>()[0];//最高位是什么
            //如果是OW的话,将数据放在owpixels
            if (items[DicomTags.BitsAllocated].ReadValue<UInt16>()[0] == 16)
            {
                owpixels = items[DicomTags.PixelData].ReadValue<Int16>();
                
            }
            else {
                obpixels = items[DicomTags.PixelData].ReadValue<sbyte>();
            }
        }


        public void myPaint(object sender, PaintEventArgs e)
        {
            double  w = double.Parse(tsWindow.Text);
            double  c = double.Parse(tsLevel.Text);
            //获取绘画图像
            Bitmap bmp = new Bitmap(this.Width, this.Height, e.Graphics);
            paintSH(w,c,bmp);
            e.Graphics.DrawImage(bmp, 0, 0);
        }
        public Bitmap paintSH(double w, double c, Bitmap bmp)
        {
            int flag = (int)Math.Pow(2, bs) - 1;
            //窗宽窗位的变化与显示
            for (int i = 0; i < Height; i++)//行
            {
                for (int j = 0; j < Width; j++)
                {
                    int idx = i * Width + j;//定位
                    int pixel;
                    if (owpixels != null) //ow
                        pixel = owpixels[idx];

                    else  //ob
                        pixel = obpixels[idx];
                    //窗宽床位变换
                    //Int16[] val = {(Int16)pixel };
                    pixel = pixel >> 0;
                    pixel = (Int16)((pixel >> (hb - bs + 1)) & flag);
                    if (pixel <= c - w / 2)
                    {
                        pixel = 0;
                    }
                    else if (pixel >= c + w / 2)
                    {
                        pixel = 255;
                    }
                    else
                    {
                        pixel = (int)(((pixel - c) / w + 0.5) * 255);
                    }
                    Color p = Color.FromArgb(pixel, pixel, pixel);
                    bmp.SetPixel(j, i, p);

                }

            }
            return bmp;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "肺窗": tsWindow.Text = "700"; tsLevel.Text = "-600"; break;
                case "脑窗": tsWindow.Text = "60"; tsLevel.Text = "35"; break;
                case "骨窗": tsWindow.Text = "1400"; tsLevel.Text = "600"; break;
                case "纵膈窗": tsWindow.Text = "350"; tsLevel.Text = "0"; break;
                case "肝窗": tsWindow.Text = "150"; tsLevel.Text = "30"; break;
                case "腹窗": tsWindow.Text = "250"; tsLevel.Text = "40"; break;
                case "脊柱窗": tsWindow.Text = "250"; tsLevel.Text = "40"; break;                  
            }
            Refresh();
        }
    }
}
