using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Customer customer = new Customer();
            //customer.FirstName = " ";

            //Person[] persons = new Person[]
            //{
            //    new Customer(),new Student(),new Person()
            //};

            Person[] persons = new Person[]
           {
               new Customer{FirstName="Engin" },
               new Student{ FirstName="Derin"},
               new Person{ FirstName="Salih"}
           };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);

            }

            Console.ReadLine();




        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public string Departmant { get; set; }
    }
}
