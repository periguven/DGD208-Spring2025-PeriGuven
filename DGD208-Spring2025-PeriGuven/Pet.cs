using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGD208_Spring2025_PeriGuven
{
    public class Pet
    {
        public string Name { get; set; }
        public int Hunger { get; set; }
        public int Sleep { get; set; }
        public int Fun { get; set; }
        public PetTypes Type { get; set; }

        public Pet(PetTypes type, string name)
        {
            Type = type;
            Name = name;
            Hunger = 50;
            Sleep = 50;
            Fun = 50;
        }
    }
}
