using GameSimulationDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulationDemo.Abstract
{
    interface IGameSaleService
    {
        public void Sell(GamerCustomer gamer, GameSale gameSale);

        public void SellWithDiscount(GamerCustomer gamer, GameSale gameSale, Campaign campaign);
    }
}
