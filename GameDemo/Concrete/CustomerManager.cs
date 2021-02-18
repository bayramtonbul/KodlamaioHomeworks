using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    public class CustomerManager : ICustomerService 
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer Added : "+customer.FirstName);
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer Deleted : " + customer.FirstName);
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Customer Updated: " + customer.FirstName);
        }
    }
}
