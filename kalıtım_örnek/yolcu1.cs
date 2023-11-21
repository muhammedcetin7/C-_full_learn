using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalıtım_örnek
{
    internal class yolcu1
    {
        private string ad;
        private string soyad;
        private int yas;
        private string cinsiyet;

        public string ADI
        {
            get { return ad; }
            set { ad = value; }
        }
        public string SOYADI
        {
            get { return soyad; }
            set { soyad = value; }
        }
        public int YASI
        {
            get { return yas; }
            set { yas = value; }
        }
        public string CİNSİYETİ
        {
            get { return cinsiyet; }
            set { cinsiyet = value; }
        }
    }

}
