using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGD208_Spring2025_PeriGuven
{
    public class Game
    {
        private bool _isRunning;
        private List<Pet> adoptedPets = new List<Pet>();
        private const int MaxPets = 3;

        public async Task GameLoop()
        {
            Initialize();
            _isRunning = true;

            while (_isRunning)
            {
                string userChoice = GetUserInput();
                await ProcessUserChoice(userChoice);
            }

            Console.WriteLine("Thanks for playing!");
        }

        private void Initialize()
        {
            // Use this to initialize the game
        }

        private string GetUserInput()
        {
            Console.Clear();
            Console.WriteLine("=== Main Menu ===");
            Console.WriteLine("1. Adopt a pet");
            Console.WriteLine("2. View pet status");
            Console.WriteLine("3. Use item on a pet");
            Console.WriteLine("4. Credits");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");
            return Console.ReadLine();
        }

        private async Task ProcessUserChoice(string choice)
        {
            switch (choice)
            {
                case "0":
                    _isRunning = false;
                    break;

                case "1":
                    if (adoptedPets.Count >= MaxPets)
                    {
                        Console.WriteLine("You already have 3 friends!");
                        await Task.Delay(1500);
                    }
                    else
                    {
                        var adoption = new AdoptingPet();
                        var newPet = await adoption.AdoptAsync((pet) =>
                        {
                            adoptedPets.Remove(pet);
                            Console.Clear();
                            Console.WriteLine($"Oh no! Your pet {pet.Name} ({pet.Type}) has died.");
                        });
                        if (newPet != null)
                        {
                            adoptedPets.Add(newPet);

                            _ = newPet.StartLifecycleAsync();

                            Console.WriteLine($"You adopted {newPet.Name}!");
                        }
                    }
                    break;

                case "2":
                    if (adoptedPets.Count == 0)
                    {
                        Console.WriteLine("You don't have any pets.");
                        await Task.Delay(1500);
                    }
                    else
                    {
                        var petMenu = new Menu<Pet>(
                            "Your Pets",
                            adoptedPets,
                            pet => $"{pet.Name} ({pet.Type}) - Hunger: {pet.Hunger}, Sleep: {pet.Sleep}, Fun: {pet.Fun}"
                        );

                        Pet selectedPet = petMenu.ShowAndGetSelection();
                        if (selectedPet != null)
                        {
                            PetStats.Show(selectedPet);
                            Console.WriteLine("Press any key to return...");
                            Console.ReadKey();
                        }
                    }
                    break;

                case "3":
                    if (adoptedPets.Count == 0)
                    {
                        Console.WriteLine("You have no pets.");
                        await Task.Delay(1500);
                        break;
                    }
                    else
                    {
                        var petMenu = new Menu<Pet>(
                            "Select a pet to use item on",
                            adoptedPets,
                            pet => $"{pet.Name} ({pet.Type})"
                        );

                        Pet selectedPet = petMenu.ShowAndGetSelection();

                        if (selectedPet == null)
                        {
                            Console.WriteLine("None of thhe items are used.");
                            await Task.Delay(1000);
                            break;
                        }
                        var compatibleItems = ItemDatabase.AllItems
                        .Where(item => item.CompatibleWith.Contains(selectedPet.Type))
                        .ToList();

                        if (compatibleItems.Count == 0)
                        {
                            Console.WriteLine("There are no compatible items for this pet.");
                            await Task.Delay(1500);
                            break;
                        }

                        var itemMenu = new Menu<Item>(
                        "Select an item to use",
                        compatibleItems,
                        item => $"{item.Name} ({item.Type}) - {item.AffectedStat} +{item.EffectAmount}"
                        );

                        Item selectedItem = itemMenu.ShowAndGetSelection();

                        if (selectedItem == null)
                        {
                            Console.WriteLine("No item selected.");
                            await Task.Delay(1000);
                            break;
                        }

                        Console.WriteLine($"Using {selectedItem.Name} on {selectedPet.Name}...");
                        await Task.Delay((int)(selectedItem.Duration * 1000));

                        switch (selectedItem.AffectedStat)
                        {
                            case PetStat.Hunger:
                                selectedPet.Hunger = Math.Min(100, selectedPet.Hunger + selectedItem.EffectAmount);
                                break;
                            case PetStat.Sleep:
                                selectedPet.Sleep = Math.Min(100, selectedPet.Sleep + selectedItem.EffectAmount);
                                break;
                            case PetStat.Fun:
                                selectedPet.Fun = Math.Min(100, selectedPet.Fun + selectedItem.EffectAmount);
                                break;
                        }

                        Console.WriteLine($"{selectedItem.AffectedStat} increased by {selectedItem.EffectAmount}!");
                        await Task.Delay(1500);
                    }

                    break;

                case "4":
                    Console.WriteLine("Creator: Peri Güven - 2305041010");
                    Console.WriteLine("Press anything to return.");
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    await Task.Delay(1000);
                    break;
            }
        }
    }
}