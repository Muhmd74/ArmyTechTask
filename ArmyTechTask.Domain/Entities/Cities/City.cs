using System;
using ArmyTechTask.Domain.Entities.Branches;

namespace ArmyTechTask.Domain.Entities.Cities
{
    public class City
    {
        public int ID { get; set; }

        public string CityName { get; set; }

        public ICollection<Branch> Branches { get; set; }
    }
}
