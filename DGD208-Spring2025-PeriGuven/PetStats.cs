using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGD208_Spring2025_PeriGuven
{
    public static class PetStats
    {
        public static void Show(Pet pet)
        {
            Console.Clear();

            if (pet == null)
            {
                Console.WriteLine("You don't have a pet yet!");
            }
            else
            {
                Console.WriteLine($"Pet Name: {pet.Name}");
                Console.WriteLine($"Hunger: {pet.Hunger}");
                Console.WriteLine($"Sleep: {pet.Sleep}");
                Console.WriteLine($"Fun: {pet.Fun}");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to return.");
            Console.ReadKey();
        }
    }
}
