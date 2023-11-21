using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalıtım_örnek
{
    internal class ucak:yolcu1
    {
        private string marka;
        private int kapasite;
        private string kalkisyeri;
        private string inisyeri;

        public string MARKA
        {
            get { return marka; }
            set { marka = value; }
        }
        public int KAPASİTE
        {
            get { return kapasite; }
            set { kapasite = value; }
        }
        public string KALKISYERİ
        {
            get { return kalkisyeri; }
            set { kalkisyeri = value; }
        }
        public string INISYERİ
        {
            get { return inisyeri; }
            set { inisyeri = value; }
        }
        public int MyProperty { get; set; }
    }
}
