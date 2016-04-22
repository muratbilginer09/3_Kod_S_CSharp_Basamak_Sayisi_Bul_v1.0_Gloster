using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kod_S_Basamak_Sayısı_Bul_v1._0_Gloster
{
    class Program
    {
        static void Main(string[] args)
        {
            float sayi;
            int basamak_sayisi = 1;

            Console.Write("Sayiyi Giriniz=");

            sayi = float.Parse(Console.ReadLine());

            float sonuc = sayi;

            while (sonuc >= 10)
            {
                basamak_sayisi++;
                sonuc = sonuc / 10;

            }

            Console.WriteLine("Basamak Sayisi=" + basamak_sayisi);

            Console.ReadKey();
        }
    }
}
