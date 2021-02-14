using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.gunOdev3


            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            sehirler.Add("izmir");
            sehirler.Add("Adana");
            sehirler.Add("istanbul");
            sehirler.Add("Bursa");
            Console.WriteLine(sehirler.Count);

            foreach (var sehir in sehirler)
            {
                Console.WriteLine(sehir);

            }

            Console.WriteLine("sehirler[4] : "+sehirler[4]);



            Console.WriteLine("-----MyList-----");

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Ankara");
            sehirler2.Add("İzmir");
            sehirler2.Add("Adana");
            sehirler2.Add("İstanbul");
            sehirler2.Add("Bursa");
            Console.WriteLine(sehirler2.Count);

            foreach (var sehir in sehirler2.List)
            {
                Console.WriteLine(sehir);

            }

            Console.WriteLine("sehirler2[4] : " + sehirler2.List[4]);


        }
    }

    class MyList<T>  //Generic type
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];

            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];

            }

            _array[_array.Length - 1] = item;



        }


        public int Count
        {
            get { return _array.Length; }
        }



        public T[] List
        {
            get { return _array; }

        }




    }
}
