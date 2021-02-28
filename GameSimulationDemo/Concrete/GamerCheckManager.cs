using GameSimulationDemo.Abstract;
using GameSimulationDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulationDemo.Concrete
{
    public class GamerCheckManager : IGamerCheckService
    {
        public bool CheckIfRealPerson(GamerCustomer gamerCustomer)
        {
            return true;
        }
    }
}
