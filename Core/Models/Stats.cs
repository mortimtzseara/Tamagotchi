using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamagochi_repo.Core.Models
{
    public class Stats
    {
        public int Hunger { get; set; }
        public int Energy { get; set; }
        public int Health { get => (Hunger + Energy) / 2; }

        public Stats(int hunger = 100, int energy = 100)
        {
            Hunger = hunger;
            Energy = energy;
        }
    }
}
