using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;
//using InterfaceAbstractDemo.Concrete;


namespace InterfaceAbstractDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to db : "+customer.FirtsName);
        }
    }
}
