using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    public class WebsiteSaleManager : ISaleService
    {
        public void Sale(Customer customer)
        {
            Console.WriteLine(customer.FirstName+" bought the game from the website ");
        }

        public void SalesCampaign(Customer customer,Campaign campaign)
        {
            Console.WriteLine(customer.FirstName + " bought the game from the website with "+campaign.CampaignName);
        }
    }
}


