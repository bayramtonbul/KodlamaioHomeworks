using System;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //11.gunOdev3

            //DortIslem dortIslem = new DortIslem(2, 3);
            //Console.WriteLine(dortIslem.Topla2());
            //Console.WriteLine(dortIslem.Topla(3, 3));

            //var type = typeof(DortIslem);
            //// obje dödürür Activator.CreateInstance();
            //DortIslem dortIslem = (DortIslem)Activator.CreateInstance(type, 2, 3);
            //Console.WriteLine(dortIslem.Topla2());
            //Console.WriteLine(dortIslem.Topla(3, 3));


            //var type = typeof(DortIslem);
            //var instance = Activator.CreateInstance(type, 2, 3);
            //Console.WriteLine(instance.GetType().GetMethod("Topla2").Invoke(instance, null));

            //var type = typeof(DortIslem);
            //var instance = Activator.CreateInstance(type, 2, 3);
            //MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");
            //Console.WriteLine(methodInfo.Invoke(instance, null));

            //var type = typeof(DortIslem);
            //var methods = type.GetMethods();

            //foreach (var info in methods)
            //{
            //    Console.WriteLine("Metod Adı: {0}", info.Name);
            //    foreach (var parameterInfo in info.GetParameters())
            //    {
            //        Console.WriteLine("parameters: {0}", parameterInfo.Name);
            //    }

            //    foreach (var attribute in info.GetCustomAttributes())
            //    {
            //        Console.WriteLine("Attributes: {0}",attribute.GetType().Name);
            //    }
            //}

            



            foreach (var info in typeof(DortIslem).GetMethods())
            {
                Console.WriteLine("Method Adı:"+info.Name);
                foreach (var parameter in info.GetParameters())
                {
                    Console.WriteLine("Parameter:"+parameter.Name);
                }

                foreach (var attribute in info.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute :"+attribute.GetType().Name);
                }
            }





            Console.ReadLine();
        }

        class DortIslem
        {
            int _sayi1;
            int _sayi2;

            public DortIslem(int sayi1, int sayi2)
            {
                _sayi1 = sayi1;
                _sayi2 = sayi2;
            }

            public DortIslem()
            {

            }

            public int Topla(int sayi1, int sayi2)
            {
                return sayi1 + sayi2;
            }

            public int Carp(int sayi1, int sayi2)
            {
                return sayi1 * sayi2;
            }

            public int Topla2()
            {
                return _sayi1 + _sayi2;
            }
            [MethodName]
            public int Carp2()
            {
                return _sayi1 * _sayi2;
            }
        }

        public class MethodNameAttribute : Attribute
        {

        }

    }
}
