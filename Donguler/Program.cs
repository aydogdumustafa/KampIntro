using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazilim Gelistirici Yetistirme Kampi";
            string kurs2 = "Programlamaya baslangic icn temel kurs";
            string kurs3 = "Java";

            string[] kurslar = new string[] { "Yazilim Gelistirici Yetistirme Kampi",
                "Programlamaya baslangic icn temel kurs",
                "Java","Python" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("sayfa sonu");

            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
