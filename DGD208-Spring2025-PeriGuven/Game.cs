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
        private Pet adoptedPet = null;

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
                    if (adoptedPet != null)
                    {
                        Console.WriteLine("You already have a pet!");
                        await Task.Delay(1500);
                    }
                    else
                    {
                        var adoption = new AdoptingPet(adoptedPet);
                        adoptedPet = await adoption.AdoptAsync();
                    }
                    break;

                case "2":
                    PetStats.Show(adoptedPet);
                    break;

                case "3":

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