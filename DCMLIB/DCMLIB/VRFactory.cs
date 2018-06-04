using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace DCMLIB
{
    public  class VRFactory
    {
        protected  TransferSyntax syntax;
        public  Hashtable VRs = new Hashtable();
        public VRFactory(TransferSyntax syn)
        {
            syntax = syn;
        }


        /// <summary>
        /// 如果在VRs里找到就直接返回对应的VR子类，如果没有找到，就创建相应vr子类的对象保存到VRs中，然后返回
        /// </summary>
        public VR GetVR(string key)
        {
            if (VRs.Contains(key))
            {
                return (VR)VRs[key];
            }
            else
            {
                VR vr = CreateVR(key);
                VRs.Add(key,vr);
                return vr;
            }
        }

        public  VR CreateVR(string key)
        {
            {
                VR vr = null;
                if (key == "UL")
                {
                    vr = new UL(syntax);
                }
                else if (key == "US")
                {
                    vr = new US(syntax);
                }
                else if (key == "AS")
                {
                    vr = new AS(syntax);
                }
                else if (key == "DA")
                {
                    vr = new DA(syntax);
                }
                else if (key == "DS")
                {
                    vr = new DS(syntax);
                }
                else if (key == "FD")
                {
                    vr = new FD(syntax);
                }
                else if (key == "DT")
                {
                    vr = new DT(syntax);
                }
                else if (key == "SS")
                {
                    vr = new SS(syntax);
                }
                else if (key == "FS")
                {
                    vr = new FS(syntax);
                }
                else if (key == "OW")
                {
                    vr = new OW(syntax);
                }
                else if (key == "UN")
                {
                    vr = new UN(syntax);
                }
                else if (key == "UT")
                {
                    vr = new UT(syntax);
                }
                else if (key == "SH")
                {
                    vr = new SH(syntax);
                }
                else if (key == "ST")
                {
                    vr = new ST(syntax);
                }
                else if (key == "LT")
                {
                    vr = new LT(syntax);
                }
                else if (key == "AE")
                {
                    vr = new AE(syntax);
                }
                else if (key == "CS")
                {
                    vr = new CS(syntax);
                }
                else if (key == "IS")
                {
                    vr = new IS(syntax);
                }
                else if (key == "SL")
                {
                    vr = new SL(syntax);
                }
                else if (key == "SQ")
                {
                    vr = new SQ(syntax);
                }
                else if (key == "TM")
                {
                    vr = new TM(syntax);
                }
                else if (key == "UI")
                {
                    vr = new UI(syntax);
                }
                else if (key == "LO")
                {
                    vr = new LO(syntax);
                }
                else if (key == "TS")
                {
                    vr = new TS(syntax);
                }
                else if (key == "PN")
                {
                    vr = new PN(syntax);
                }
                else if (key == "OB")
                {
                    vr = new OB(syntax);
                }
                else if (key == "OF")
                {
                    vr = new OF(syntax);
                }
                return vr;

            }
        }


    }
}