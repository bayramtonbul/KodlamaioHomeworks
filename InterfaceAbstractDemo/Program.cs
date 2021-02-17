using System;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using InterfaceAbstractDemo.Adapters;

namespace InterfaceAbstractDemo
{
    //5.gunOdev4
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer 
            { 
                FirtsName = "****", 
                LastName = "****", 
                NationalityId = "12345678901", 
                DateOfBirth = new DateTime(1999, 9, 9)
            });


            Console.ReadLine();
        }
    }
}
