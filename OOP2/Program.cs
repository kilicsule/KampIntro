using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sule Kilic
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Sule";
            musteri1.Soyadi = "Kilic";
            musteri1.TcNo = "124585852";

            //Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "5445626";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "45125";

            //Gercek Musteri - Tuzel Musteri
            //SOLID

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);


        }
    }
}
