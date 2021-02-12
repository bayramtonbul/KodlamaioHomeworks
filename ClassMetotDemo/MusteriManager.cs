using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Name+" "+musteri.Surname+" Musteri Listesine Eklendi.");

        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine(musteri.Id+ "  Nolu Musteri Listeden Silindi.");

        }





    }
}
