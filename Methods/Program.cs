using System;
using System.Linq;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
 
            int result = Add2(20, 30);
            Console.WriteLine(result);

            Console.WriteLine("----default value----");

            //2.parametre default 30
            int result2 = Add2default(20);  
            Console.WriteLine(result2);

            Console.WriteLine("----ref keyword----");

            int number1 = 20;   
            int number2 = 100;
            int result3 = Add3(ref number1, number2); 
            Console.WriteLine(result3);
            Console.WriteLine(number1);

            Console.WriteLine("----out keyword----");

            int number1out;
            int number2out = 100;
            int result3out = Add3out(out number1out, number2out);
            Console.WriteLine(result3out);
            Console.WriteLine(number1out);

            Console.WriteLine("----method overloading----");

            Console.WriteLine(Multiply(2,4));
            Console.WriteLine(Multiply(2,4,5));

            Console.WriteLine("----params keyword----");

            Console.WriteLine(Add4(1,2,3,4,5,6));

            Console.ReadLine();
            
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }

        static int Add2(int number1,int number2)
        {
            int result = number1 + number2;
            return result;

        }

        static int Add2default(int number1,int number2=30)
        {
            int result = number1 + number2;
            return result;

        }

        static int Add3( ref int number1,int number2)  
        {
            number1 = 30;
            return number1+number2;

        }

        static int Add3out (out int number1,int number2)
        {
            number1 = 30;
            return number1 + number2;

        }


        static int Multiply(int number1,int number2)
        {
            return number1*number2;
        }

        static int Multiply(int number1, int number2,int number3)
        {
            return number1 * number2*number3;
        }

        static int Add4( params int[] numbers)
        {
            return numbers.Sum();


        }
    }




}
