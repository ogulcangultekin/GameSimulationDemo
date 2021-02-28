using GameSimulationDemo.Concrete;
using GameSimulationDemo.Entities;
using System;

namespace GameSimulationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerCustomer gamerCustomer = new GamerCustomer();
            gamerCustomer.Id = 1;
            gamerCustomer.Name = "Abuzittin";
            gamerCustomer.Surname = "Killibacak";
            gamerCustomer.TcNo = "1234444444";
            gamerCustomer.NationalIdentity = 1;
            gamerCustomer.Birthday = new System.DateTime(1998, 8, 24);
            GamerCustomerManager gamerCustomerManager = new GamerCustomerManager();
            gamerCustomerManager.Add(gamerCustomer);
            gamerCustomerManager.Delete(gamerCustomer);
            gamerCustomerManager.Update(gamerCustomer);


            GameSale gameSale = new GameSale();
            gameSale.GameId = 1;
            gameSale.GameName = "TatarAtarTutar";
            gameSale.Price = 299;

            Campaign campaign = new Campaign();
            campaign.Id = 1;
            campaign.CampaignName = "SudanPahali";
            campaign.CampaignDiscountRate = 100;
            

            GameSaleManager gameSaleManager = new GameSaleManager();
            gameSaleManager.Sell(gamerCustomer, gameSale);
            gameSaleManager.SellWithDiscount(gamerCustomer, gameSale, campaign);
            

        }
    }
}
