using System;
using System.Collections.Generic;

namespace DictionaryWork
{
    class Program
    {
        static void Main(string[] args)
        {

            //4.gunOdev5
            Dictionary<int, string> books = new Dictionary<int, string>();
            Console.WriteLine("books.Count : " + books.Count);

            books.Add(1, "kitap a");
            books.Add(2, "kitap b");
            books.Add(3, "kitap c");

            foreach (var book in books)
            {
                Console.WriteLine(book);

            }

            Console.WriteLine("books.Count : " + books.Count);


            Console.WriteLine("----------MyDictionary----------");

            MyDictionary<int, string> myBooks = new MyDictionary<int, string>();
            Console.WriteLine("myBooks.Count : " + myBooks.Count);

            myBooks.Add(1, "kitap a");
            myBooks.Add(2, "kitap b");
            myBooks.Add(3, "kitap c");

            foreach (var book in myBooks.KeyList)
            {
                Console.WriteLine(book);

            }

            foreach (var book in myBooks.ValueList)
            {
                Console.WriteLine(book);

            }

        

            Console.WriteLine("myBooks.Count : " + myBooks.Count);








            Console.ReadLine();

        }
    }
}
