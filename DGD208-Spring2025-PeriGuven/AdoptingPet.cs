using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGD208_Spring2025_PeriGuven
{
    public class AdoptingPet
    {
        private Pet _adoptedPet;

        public AdoptingPet(Pet adoptedPet)
        {
            _adoptedPet = adoptedPet;
        }

        public async Task<Pet> AdoptAsync()
        {
            Console.Clear();

            if (_adoptedPet != null)
            {
                Console.WriteLine("You already have a friend!");
                await Task.Delay(1500);
                return _adoptedPet;
            }

            var typeMenu = new Menu<PetTypes>(
                "Select a pet to adopt",
                Enum.GetValues(typeof(PetTypes)).Cast<PetTypes>().ToList(),
                pet => pet.ToString()
            );

            PetTypes? selectedType = typeMenu.ShowAndGetSelection();

            if (selectedType == 0)
            {
                Console.WriteLine("Adoption cancelled :(. Please come back!");
                await Task.Delay(1500);
                return null;
            }

            Console.Write("Enter a name for your new friend: ");
            string name = Console.ReadLine();

            string petName = string.IsNullOrWhiteSpace(name) ? selectedType.ToString() : name;
            var newPet = new Pet(selectedType.Value, petName);

            Console.WriteLine($"You adopted {selectedType} {newPet.Name}!");
            await Task.Delay(1500);
            return newPet;
        }
    }
}
