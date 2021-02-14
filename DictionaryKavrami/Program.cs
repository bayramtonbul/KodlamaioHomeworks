using System;
using System.Collections.Generic;

namespace DictionaryKavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.gunOdev4
            //Dictionary<Tkey,Tvalue>
            Dictionary<int, string> books = new Dictionary<int, string>();
            books.Add(1, "kitap a");
            books.Add(2, "kitap b");
            books.Add(3, "kitap c");
            books.Add(4, "kitap d");
            books.Add(5, "kitap e");

            Console.WriteLine("eleman sayisi : "+books.Count);
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }

            Console.WriteLine("----remove----");

            books.Remove(5);

            Console.WriteLine("eleman sayisi : " + books.Count);
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }








        }

    }
}
