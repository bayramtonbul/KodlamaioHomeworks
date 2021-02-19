using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class EStateCustomerCheckManager : ICustomerCheckService
    {
        public bool Check(Customer customer)
        {
            Console.WriteLine(customer.FirstName+" checked");
            return true;
        }
    }
}
