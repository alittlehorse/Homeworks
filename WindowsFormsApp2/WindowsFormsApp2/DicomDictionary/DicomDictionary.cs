using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp2
{
    class DicomDictionary
    {
        List<DicomDictonaryEntry> dict = new List<DicomDictonaryEntry>();
        DicomDictonaryEntry dde;
        public DicomDictionary()
        {
            StreamReader sr = new StreamReader("E:\\dicom.txt", Encoding.Default);
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                DicomDictonaryEntry dde = new DicomDictonaryEntry();
                string[] a =  line.Split('\t');
                dde.tag = a[0];
                dde.Name = a[1];
                dde.Keyword = a[2];
                dde.VR = a[3];
                dde.VM = a[4];
                dict.Add(dde);
            }
        

        }
        public DicomDictonaryEntry FindByTag(string tag)
        {
            string newtag = '"' + tag + '"';
            dde=dict.Find(delegate(DicomDictonaryEntry dde1) {
                return dde1.tag == newtag;
            });
            return dde;
        }

    }
}
