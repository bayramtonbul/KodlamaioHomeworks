using System;

namespace ReferanceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.gunOdev1
            //int,decimal,float,enum,boolean..  value types

            int sayi1 = 10;
            int sayi2 = 20;

            sayi1 = sayi2;

            sayi2 = 100;
            Console.WriteLine("sayı 1 : " + sayi1);

            //array,class,interface.. reference types
            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[]{10, 20, 30};
            sayilar1 = sayilar2;
            sayilar2[0] = 1000;
            Console.WriteLine("sayilar1[0] : "+sayilar1[0]);

            //foreach (int sayi in sayilar1)
            //{
            //    Console.WriteLine(sayi);
            //}


            Person person1 = new Person();
            Person person2 = new Person();

            person1.FirstName = "Engin";
            person2 = person1;
            Console.WriteLine(person2.FirstName);
            person2.FirstName = "Derin";
            Console.WriteLine(person1.FirstName);
            Console.WriteLine(person2.FirstName);


            Customer customer = new Customer();

            customer.FirstName = "Salih";

            Person person3 = customer;
            customer.FirstName = "Ahmet";

           
            Console.WriteLine(customer.FirstName);

            customer.CreditCardNumnber = "2433434";
            Console.WriteLine(customer.CreditCardNumnber);
            //boxing
            Console.WriteLine(((Customer)person3).CreditCardNumnber);



            Employee employee = new Employee();
            employee.FirstName = "Veli";

            PersonManager personManager = new PersonManager();
            personManager.Add(employee);
            personManager.Add(person1);
            personManager.Add(person2);
            personManager.Add(person3);
            personManager.Add(customer);









        }
    }

    class Person
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
    // base class:Person
    class Customer:Person
    {
        public string CreditCardNumnber { get; set; }

    }

    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }

    }

}
