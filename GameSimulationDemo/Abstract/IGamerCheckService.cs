using GameSimulationDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulationDemo.Abstract
{
    interface IGamerCheckService
    {
        bool CheckIfRealPerson(GamerCustomer gamerCustomer);
    }
}
