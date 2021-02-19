using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    public class MobileSaleManager : ISaleService
    {
        public void Sale(Customer customer)
        {
            Console.WriteLine(customer.FirstName+" bought the game from the mobile ");
        }

        public void SalesCampaign(Customer customer,Campaign campaign)
        {
            Console.WriteLine(customer.FirstName + " bought the game from the mobile with "+campaign.CampaignName);
        }
    }
}
