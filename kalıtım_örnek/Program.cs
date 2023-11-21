using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalıtım_örnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ucak uck = new ucak();
            uck.MARKA = "Türk Hava Yolları";
            uck.KAPASİTE = 500;
            uck.KALKISYERİ = "Malatya Havalimanı";
            uck.INISYERİ = "İstanbul Havalimanı";
            uck.ADI = "Muhammed";
            uck.SOYADI = "Çetin";
            uck.CİNSİYETİ = "Erkek";
            uck.YASI = 20;

            Console.WriteLine("Hava Yolu: " + uck.MARKA);
            Console.WriteLine("Güzergah: " + uck.KALKISYERİ + "-" + uck.INISYERİ);
            Console.WriteLine("Uçağın kapasitesi: " + uck.KAPASİTE);
            Console.WriteLine("Yolcunun Adı: " + uck.ADI);
            Console.WriteLine("Yolcunun Soyadı: " + uck.SOYADI);
            Console.WriteLine("Yolcunun Cinsiyeti: " + uck.CİNSİYETİ);
            Console.WriteLine("Yolcunun Yaşı: " + uck.YASI);
            Console.Read();
        }

    }
}
