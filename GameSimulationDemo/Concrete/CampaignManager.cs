using GameSimulationDemo.Abstract;
using GameSimulationDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulationDemo.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya eklendi");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya silindi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya güncellendi.");
        }
    }
}
