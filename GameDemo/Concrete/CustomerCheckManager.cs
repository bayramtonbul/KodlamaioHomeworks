using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool Check(Customer customer)
        {
            return true;
        }
    }
}
