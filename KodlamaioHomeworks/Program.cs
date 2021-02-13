using System;
using System.Collections.Generic;

namespace KodlamaioHomeworks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<string> isimler = new List<string>();
            isimler.Add("ali");
            Console.WriteLine(isimler.Count);
            isimler.Add("mehmet");
            isimler.Add("Veli");
            Console.WriteLine(isimler.Count);

            foreach (string isim in isimler)
            {
                Console.WriteLine(isim);
                   

            }

        }
    }
}
