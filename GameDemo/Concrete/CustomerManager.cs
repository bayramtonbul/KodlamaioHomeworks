using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    public class CustomerManager : ICustomerService 
    {
        ICustomerCheckService _customerCheckService;

        public CustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public void Add(Customer customer)
        {
            if (_customerCheckService.Check(customer))
            {
                Console.WriteLine("Customer Added : " + customer.FirstName);
            }
            else
            {
                Console.WriteLine("kayıt basarisiz");
            }
            
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
