using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    public interface ISaleService
    {
        void Sale(Customer customer);
        void SalesCampaign(Customer customer,Campaign campaign);
         
    }
}