using GameSimulationDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulationDemo.Entities
{
    public class GamerCustomer:IEntity
    {
        public int Id{ get; set; }
        public string TcNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }

        public int NationalIdentity { get; set; }
    }
}
