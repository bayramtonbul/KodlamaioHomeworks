using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //PersonManager personManager = new PersonManager();
            //personManager.Add(new Customer { Id = 1, FirstName = "Engin", LastName = "Demirog", Address = "Ankara" });

            //Student student = new Student
            //{
            //    Id = 1,
            //    FirstName = "Derin",
            //    LastName = "Demirog",
            //    Department = "Compurer Sciences"
            //};

            //personManager.Add(student);




            //CustomerManager customerManager = new CustomerManager();
            //customerManager.Add(new SqlServerCustomerDal());
            //customerManager.Add(new OracleCustomerDal());



            ICustomerDal[] customerDals = new ICustomerDal[]
            { 
                new SqlServerCustomerDal(), new OracleCustomerDal()
            };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add2(customerDals);











            Console.ReadLine();


        }
    }

    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Department { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
