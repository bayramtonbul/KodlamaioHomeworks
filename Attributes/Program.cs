using System;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            //11.gunOdev3
            //Attribute Nesneye bir anlam yükleniyor
            //Reflection calışma anında nesneler hakkında bilgi alma-istersek calistirabilmek
            Customer customer = new Customer { Id = 1, LastName = "Yilmaz", Age = 32 };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
            Console.ReadLine();
        }
    }

    [ToTable("Customers")]
    [ToTable("TblCustomers")]
    class Customer
    {
        public int Id { get; set; }
        [RequiredProperty]
        public string FirstName { get; set; }
        [RequiredProperty]
        [RequiredProperty]
        public string LastName { get; set; }
        [RequiredProperty]
        public int Age { get; set; }



    }

    class CustomerDal
    {
        [Obsolete("Don't use Add,instead use AddNew Method")]
        public void Add(Customer customer)
        {
            Console.WriteLine(
                "{0},{1},{2},{3} added!",
                customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }

        public void AddNew(Customer customer)
        {
            Console.WriteLine(
                "{0},{1},{2},{3} added!",
                customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
    }


    //[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    class RequiredPropertyAttribute : Attribute
    {

    }




    [AttributeUsage(AttributeTargets.Class,AllowMultiple =true)]
    class ToTable : Attribute
    {
        string _tableName;

        public ToTable(string tableName)
        {
            _tableName = tableName;
        }
    }
}

