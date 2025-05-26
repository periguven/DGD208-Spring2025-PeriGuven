using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGD208_Spring2025_PeriGuven
{
    public class Pet
    {
        private Action<Pet> onDeath;

        public string Name { get; set; }
        public PetTypes Type { get; set; }
        public int Hunger { get; set; } = 50;
        public int Sleep { get; set; } = 50;
        public int Fun { get; set; } = 50;

        public Pet(PetTypes type, string name, Action<Pet> onDeath)
        {
            this.Type = type;
            this.Name = name;
            this.onDeath = onDeath;
        }

        public void ModifyStat(PetStat stat, int amount)
        {
            switch (stat)
            {
                case PetStat.Hunger:
                    Hunger = Math.Clamp(Hunger + amount, 0, 100);
                    break;
                case PetStat.Sleep:
                    Sleep = Math.Clamp(Sleep + amount, 0, 100);
                    break;
                case PetStat.Fun:
                    Fun = Math.Clamp(Fun + amount, 0, 100);
                    break;
            }
        }

        public async Task StartLifecycleAsync()
        {
            while (true)
            {
                await Task.Delay(3000);

                Hunger = Math.Max(0, Hunger - 1);
                Sleep = Math.Max(0, Sleep - 1);
                Fun = Math.Max(0, Fun - 1);

                if (Hunger == 0 || Sleep == 0 || Fun == 0)
                {
                    onDeath?.Invoke(this);
                    break;
                }
            }
        }
    }
}
