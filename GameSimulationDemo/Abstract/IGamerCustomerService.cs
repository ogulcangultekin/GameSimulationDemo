using GameSimulationDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulationDemo.Abstract
{
    interface IGamerCustomerService
    {
        public void Add(GamerCustomer gamerCustomer);
        public void Update(GamerCustomer gamerCustomer);
        public void Delete(GamerCustomer gamerCustomer);
    }
}
