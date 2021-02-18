using System;
using GameDemo.Abstract;
using GameDemo.Concrete;
using GameDemo.Entities;

namespace GameDemo
{
    class Program
    {
        //5.gunOdev5
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                FirstName = "Ali", 
                LastName = "Yilmaz", 
                CustomerId = 1, 
                Address = "İstanbul", 
                Email = "aliyilmaz@gmail.com", 
                NationalityId = "12345678901", 
                YearOfBirth =new DateTime(2000,1,1)
            };

            Customer customer2 = new Customer()
            {
                FirstName = "Veli",
                LastName = "Yilmaz",
                CustomerId = 2,
                Address = "İstanbul",
                Email = "veliyilmaz@gmail.com",
                NationalityId = "12345678901",
                YearOfBirth = new DateTime(1999, 9, 9)
            };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Update(customer2);
            customerManager.Delete(customer1);

            Console.WriteLine("---------------");

            Campaign campaign1 = new Campaign()
            {
                CampaignId = 1,
                CampaignName = "First Campaign",
                CampaignCommet = "discount:5 percent",
                CampaignRate=0.05
            };

            Campaign campaign2 = new Campaign()
            {
                CampaignId = 2,
                CampaignName = "Second Campaign",
                CampaignCommet = "discount:10 percent",
                CampaignRate=0.10
            };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Update(campaign2);
            campaignManager.Delete(campaign1);

            Console.WriteLine("---------------");

            WebsiteSaleManager websiteSaleManager = new WebsiteSaleManager();
            websiteSaleManager.Sale(customer2);
            websiteSaleManager.SalesCampaign(customer1,campaign2);

            MobileSaleManager mobileSaleManager = new MobileSaleManager();
            mobileSaleManager.SalesCampaign(customer2, campaign1);
            mobileSaleManager.Sale(customer1);

            













            Console.ReadLine();
            
            

        }
    }
    
}
