using System;

namespace DemoAbstractClass
{
    //5.gunOdev3
    class Program
    {
        //abstract class'in nesnesi olusturulmaz.Govdesi yazilmaz.Referans noktasi alinabilir
        static void Main(string[] args)
        {
            Worker workerA = new Worker();
            workerA.Add();
            Worker2 workerB = new Worker2();
            workerB.Add();
           


            Console.ReadLine();

        }
    }

    //abstract class MyCLass
    //{
    //    public abstract void Add();
    //    abstract public int MyProperty { get; set; }
    //}

    interface Person
    {
        public void Add();

    }

    abstract class PersonAbstract
    {
        public abstract void Add();
    }

    class Worker:Person
    {
        public void Add()
        {
            Console.WriteLine("worker Added");
        }
    }

    class Worker2 : PersonAbstract
    {
        public override void Add()
        {
            Console.WriteLine("Worker2 added");
        }
    }
}
