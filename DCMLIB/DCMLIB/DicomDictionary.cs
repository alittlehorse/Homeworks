using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DCMLIB
{
    class DicomDictionary
    {
        List<DicomDictonaryEntry> dict = new List<DicomDictonaryEntry>();
        DicomDictonaryEntry dde;
        public DicomDictionary()
        {
            StreamReader sr = new StreamReader("dicom.txt", Encoding.Default);
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                DicomDictonaryEntry dde = new DicomDictonaryEntry();
                string[] a = line.Split('\t');
                dde.tag = a[0];
                dde.Name = a[1];
                dde.Keyword = a[2];
                dde.VR = a[3];
                dde.VM = a[4];
                dict.Add(dde);
            }


        }

        public DicomDictonaryEntry GetEntry(ushort gtag,ushort etag)
        {
            string newtag = '"' + "(" + gtag.ToString("X4") + "," + etag.ToString("X4") + ")" + '"';
            dde = dict.Find(dde => dde.tag== newtag);
            return dde;
        }

    }
    class DicomDictonaryEntry
    {
        public string tag { set; get; }
        public string Name { set; get; }
        public string Keyword { set; get; }
        public string VR { set; get; }
        public string VM { set; get; }
    }

}
