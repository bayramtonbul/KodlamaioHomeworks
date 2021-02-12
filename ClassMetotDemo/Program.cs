using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Name = "Ali";
            musteri1.Surname = "Yilmaz";
            musteri1.Age = 30;
            musteri1.Email = "aliyilmaz@gmail.com";
            musteri1.Address = "Istanbul";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Name = "Veli";
            musteri2.Surname = "Kaya";
            musteri2.Age = 40;
            musteri2.Email = "velikaya@gmail.com";
            musteri2.Address = "Ankara";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Name = "Hale";
            musteri3.Surname = "Celik";
            musteri3.Age = 35;
            musteri3.Email = "halecelik@gmail.com";
            musteri3.Address = "Izmir";

            Musteri musteri4 = new Musteri();
            musteri4.Id = 4;
            musteri4.Name = "Lale";
            musteri4.Surname = "Demir";
            musteri4.Age = 25;
            musteri4.Email = "laledemir@gmail.com";
            musteri4.Address = "Bursa";


            Console.WriteLine("------Ekleme------");
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);

            Console.WriteLine("------Listeleme------");

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Musteri:"+musteri.Name + " " + musteri.Surname+","+musteri.Address);  
            }

            Console.WriteLine("------Silme------");

            musteriManager.Silme(musteri1);
            musteriManager.Silme(musteri2);
            musteriManager.Silme(musteri3);
            musteriManager.Silme(musteri4);





        }
    }
}
