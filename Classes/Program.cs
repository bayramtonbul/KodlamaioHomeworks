using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //5.gunOdev1
            CustomerMananger customerMananger = new CustomerMananger();
            customerMananger.Add();
            customerMananger.Update();

            ProductMananger productMananger = new ProductMananger();
            productMananger.Add();
            productMananger.Update();

            Customer customer = new Customer();
            customer.Id = 1;
            customer.City = "Ankara";
            customer.FirstName = "Engin";
            customer.LastName = "Demirog";

            Customer customer2 = new Customer
            {
                Id=2,City="İstanbul",FirstName="Derin",LastName="Demirog",TcNo="12345"
            };

            Console.WriteLine(customer2.FirstName);
            Console.WriteLine(customer2.TcNo);
            

            Console.ReadLine();

        }
    }
}
