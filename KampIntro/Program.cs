using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori" ;
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalis Butonu");
            }
            else if (dolarDun <dolarBugun  )
            {
                Console.WriteLine("Artis Butonu");
            }
            else
            {
                Console.WriteLine("degismedi butonu");
            } 
            bool sistemeGirisYapmisMi = false;

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanici ayarlari butonu");
            }
            else
            {
                Console.WriteLine("Giris Yap Butonu");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
