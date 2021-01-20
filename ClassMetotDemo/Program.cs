using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Ali";
            musteri1.Soyadi = "Birinci";
            musteri1.KimlikNo = "111111111";

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Ayşe";
            musteri2.Soyadi = "İkinci";
            musteri2.KimlikNo = "2222222222";

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Hasan";
            musteri3.Soyadi = "Üçüncü";
            musteri3.KimlikNo = "3333333333";


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            

            foreach (Musteri musteri in musteriler)
            {
                musteriManager.MusteriEkle(musteri.Adi, musteri.Soyadi, musteri.KimlikNo);
            }

            Console.WriteLine(" ");
            Console.WriteLine("------------------ ");
            Console.WriteLine(" ");
            foreach (Musteri musteri in musteriler)
            {
                musteriManager.MusteriSil(musteri.Adi, musteri.Soyadi, musteri.KimlikNo);
            }



            //Console.WriteLine("Hello World!");
        }
    }
}
