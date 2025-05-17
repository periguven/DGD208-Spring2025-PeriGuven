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
                return;
            }
           
        }
    }
}
