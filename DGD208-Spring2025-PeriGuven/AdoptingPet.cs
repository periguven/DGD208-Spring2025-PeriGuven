using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGD208_Spring2025_PeriGuven
{
    public class AdoptingPet
    {
        public AdoptingPet() { }

        public async Task<Pet> AdoptAsync(Action<Pet> onDeath)
        {
            Console.Clear();

            var typeMenu = new Menu<PetTypes>(
            "Select a pet to adopt",
            Enum.GetValues(typeof(PetTypes)).Cast<PetTypes>().ToList(),
            pet => pet.ToString()
            );

            PetTypes? selectedType = typeMenu.ShowAndGetSelection();

            if (selectedType == null)
            {
                Console.WriteLine("Adoption cancelled :(. Please come back!");
                await Task.Delay(1500);
                return null;
            }

            Console.Write("Enter a name for your new friend: ");
            string name = Console.ReadLine();

            string petName = string.IsNullOrWhiteSpace(name) ? selectedType.ToString() : name;
            var newPet = new Pet(selectedType.Value, petName, onDeath);

            Console.WriteLine($"You adopted {selectedType} {newPet.Name}!");
            await Task.Delay(1500);
            return newPet;
        }
    }
}
