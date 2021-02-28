using GameSimulationDemo.Abstract;
using GameSimulationDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulationDemo.Concrete
{
    public class GamerCustomerManager : IGamerCustomerService
    {
        public void Add(GamerCustomer gamerCustomer)
        {
            Console.WriteLine("Musteri eklendi. "+gamerCustomer.Name);
        }

        public void Delete(GamerCustomer gamerCustomer)
        {
            Console.WriteLine("Musteri silindi. " + gamerCustomer.Name);
        }

        public void Update(GamerCustomer gamerCustomer)
        {
            Console.WriteLine("Musteri guncellendi. " + gamerCustomer.Name);
        }
    }
}
