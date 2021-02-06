using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazilim Gelistirici Yetistirme Kampi";
            string kurs2 = "Programlamaya Baslangic Icin Temel Kurs";
            string kurs3 = "Java";
            string kurs4 = "Phyton";
            string kurs5 = "C#";

            //Array : dizi

            string[] kurslar = new string[] { "Yazilim Gelistirici Yetistirme Kampi", "Programlamaya Baslangic Icin Temel Kurs", "Java", "Phyton", "C#" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("\n for bitti \n");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("\n sayfa sonu");
        }
    }
}
