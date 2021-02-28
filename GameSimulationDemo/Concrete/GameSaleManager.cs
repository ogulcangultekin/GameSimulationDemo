using GameSimulationDemo.Abstract;
using GameSimulationDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulationDemo.Concrete
{
    class GameSaleManager : IGameSaleService
    {
     

        public void Sell(GamerCustomer gamer, GameSale gameSale)
        {
            Console.WriteLine("Oyuncuya satildi." + gamer.Name + "Adli oyun:" + gameSale.GameName);
        }

        public void SellWithDiscount(GamerCustomer gamer, GameSale gameSale, Campaign campaign)
        {
            Console.WriteLine("Kampanyali satis gerceklesti"); ;
        }
    }
}
