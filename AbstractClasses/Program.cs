using System;

namespace AbstractClasses
{
    class Program
    {
        //interface ref tutar
        //class da referans type'dir ve somut yapiya sahiptir.Class icerisinde oprasyonlar olur.
        //Class icerisinde birbiri ile ilgili operasyonlari ve property tutar.
        //abstract class hem tamamlanmis hem tamamlanmamis operasyon tutabilir.
        //abstract class new'lenemez.

        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();

            AMevzuat aMevzuat = new AMevzuat();
            aMevzuat.Degerlendir();
            aMevzuat.Kaydet();


            Console.ReadLine();
        }
    }

    abstract class MevzuatBase
    {
        protected MevzuatBase()
        {

        }
        public abstract void Degerlendir();
        public void Kaydet()
        {
            Console.WriteLine("Kaydedildi.");
        }
    }

    class AMevzuat : MevzuatBase
    {
        public override void Degerlendir()
        {
            Console.WriteLine("A mevzuatina göre degerlendirildi.");
        }
    }

    class BMevzuat : MevzuatBase
    {
        public override void Degerlendir()
        {
            Console.WriteLine("B mevzuatina göre degerlendirildi.");
        }
    }

    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("added");
        }
        public void Delete()
        {
            Console.WriteLine("Deleted");
        }

    }
}
