using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGD208_Spring2025_PeriGuven
{
    public static class ItemDatabase
    {
        public static List<Item> AllItems = new List<Item>
    {
        // Foods
        new Item {
            Name = "Kibble",
            Type = ItemType.Food,
            CompatibleWith = new List<PetTypes> { PetTypes.Dog },
            AffectedStat = PetStat.Hunger,
            EffectAmount = 15,
            Duration = 2.5f  // Takes 2.5 seconds to eat
        },
        new Item {
            Name = "Premium Dog Food",
            Type = ItemType.Food,
            CompatibleWith = new List<PetTypes> { PetTypes.Dog },
            AffectedStat = PetStat.Hunger,
            EffectAmount = 30,
            Duration = 3.0f  // Takes 3 seconds to eat
        },
        new Item {
            Name = "Cat Food",
            Type = ItemType.Food,
            CompatibleWith = new List<PetTypes> { PetTypes.Cat },
            AffectedStat = PetStat.Hunger,
            EffectAmount = 15,
            Duration = 2.0f
        },
        new Item {
            Name = "Tuna Treat",
            Type = ItemType.Food,
            CompatibleWith = new List<PetTypes> { PetTypes.Cat },
            AffectedStat = PetStat.Hunger,
            EffectAmount = 25,
            Duration = 1.5f  // Quick treat
        },
        new Item {
            Name = "Snail Food",
            Type = ItemType.Food,
            CompatibleWith = new List<PetTypes> { PetTypes.Snail },
            AffectedStat = PetStat.Hunger,
            EffectAmount = 10,
            Duration = 1.0f
        },
        new Item {
            Name = "Fruit Mix",
            Type = ItemType.Food,
            CompatibleWith = new List<PetTypes> { PetTypes.Chicken },
            AffectedStat = PetStat.Hunger,
            EffectAmount = 20,
            Duration = 2.0f
        },
        new Item {
            Name = "Fish",
            Type = ItemType.Food,
            CompatibleWith = new List<PetTypes> { PetTypes.Octopus },
            AffectedStat = PetStat.Hunger,
            EffectAmount = 10,
            Duration = 0.5f  // Very quick to consume
        },
        new Item {
            Name = "Premium Fish Pellets",
            Type = ItemType.Food,
            CompatibleWith = new List<PetTypes> { PetTypes.Octopus },
            AffectedStat = PetStat.Hunger,
            EffectAmount = 20,
            Duration = 1.0f
        },
        new Item {
            Name = "Carrots",
            Type = ItemType.Food,
            CompatibleWith = new List<PetTypes> { PetTypes.Snail },
            AffectedStat = PetStat.Hunger,
            EffectAmount = 15,
            Duration = 3.0f  // Takes time to chew
        },
        new Item {
            Name = "Leafy Greens",
            Type = ItemType.Food,
            CompatibleWith = new List<PetTypes> { PetTypes.Snail },
            AffectedStat = PetStat.Hunger,
            EffectAmount = 25,
            Duration = 4.0f  // Lots to munch through
        },
        
        // Universal Foods
        new Item {
            Name = "Vitamin Treat",
            Type = ItemType.Food,
            CompatibleWith = new List<PetTypes> { PetTypes.Dog, PetTypes.Cat, PetTypes.Chicken },
            AffectedStat = PetStat.Hunger,
            EffectAmount = 10,
            Duration = 1.0f  // Quick treat
        },
        new Item {
            Name = "Gourmet Dinner",
            Type = ItemType.Food,
            CompatibleWith = new List<PetTypes> { PetTypes.Dog, PetTypes.Cat },
            AffectedStat = PetStat.Hunger,
            EffectAmount = 40,
            Duration = 5.0f  // Fancy meal takes time
        },
        
        // Toys
        new Item {
            Name = "Tennis Ball",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetTypes> { PetTypes.Dog },
            AffectedStat = PetStat.Fun,
            EffectAmount = 20,
            Duration = 4.0f  // Playing fetch takes time
        },
        new Item {
            Name = "Squeaky Toy",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetTypes> { PetTypes.Dog },
            AffectedStat = PetStat.Fun,
            EffectAmount = 15,
            Duration = 2.5f
        },
        new Item {
            Name = "String Toy",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetTypes> { PetTypes.Cat },
            AffectedStat = PetStat.Fun,
            EffectAmount = 20,
            Duration = 3.0f  // Playing with string
        },
        new Item {
            Name = "Toy Mouse",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetTypes> { PetTypes.Cat },
            AffectedStat = PetStat.Fun,
            EffectAmount = 15,
            Duration = 2.0f
        },
        new Item {
            Name = "Tiny Ball",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetTypes> { PetTypes.Snail },
            AffectedStat = PetStat.Fun,
            EffectAmount = 15,
            Duration = 3.0f  // he's smol
        },
        new Item {
            Name = "Bell",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetTypes> { PetTypes.Chicken },
            AffectedStat = PetStat.Fun,
            EffectAmount = 10,
            Duration = 1.5f
        },
        new Item {
            Name = "Bubbler",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetTypes> { PetTypes.Octopus },
            AffectedStat = PetStat.Fun,
            EffectAmount = 10,
            Duration = 2.0f  // Watching bubbles
        },
        new Item {
            Name = "Water Plant",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetTypes> { PetTypes.Octopus },
            AffectedStat = PetStat.Fun,
            EffectAmount = 15,
            Duration = 1.5f
        },
        new Item {
            Name = "Chew Toy",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetTypes> { PetTypes.Chicken },
            AffectedStat = PetStat.Fun,
            EffectAmount = 15,
            Duration = 3.5f  // Lots of chewing
        },
        new Item {
            Name = "Underwater Tunnel",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetTypes> { PetTypes.Octopus },
            AffectedStat = PetStat.Fun,
            EffectAmount = 20,
            Duration = 4.0f  // Running through tunnels
        },
        
        // Universal Toys
        new Item {
            Name = "Ball",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetTypes> { PetTypes.Dog, PetTypes.Cat, PetTypes.Octopus, PetTypes.Chicken },
            AffectedStat = PetStat.Fun,
            EffectAmount = 10,
            Duration = 2.0f
        },
        
        // Sleep Items
        new Item {
            Name = "Comfy Bed",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetTypes> { PetTypes.Dog, PetTypes.Cat },
            AffectedStat = PetStat.Sleep,
            EffectAmount = 30,
            Duration = 6.0f  // Takes time to fall asleep
        },
        new Item {
            Name = "Pet Blanket",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetTypes> { PetTypes.Dog, PetTypes.Cat, PetTypes.Chicken },
            AffectedStat = PetStat.Sleep,
            EffectAmount = 20,
            Duration = 4.0f
        },
        new Item {
            Name = "Perch",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetTypes> { PetTypes.Chicken },
            AffectedStat = PetStat.Sleep,
            EffectAmount = 25,
            Duration = 3.0f
        },
        new Item {
            Name = "Cave Decoration",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetTypes> { PetTypes.Octopus },
            AffectedStat = PetStat.Sleep,
            EffectAmount = 15,
            Duration = 2.0f
        },
        new Item {
            Name = "Tiny medieval house",
            Type = ItemType.Toy,
            CompatibleWith = new List<PetTypes> { PetTypes.Snail },
            AffectedStat = PetStat.Sleep,
            EffectAmount = 25,
            Duration = 5.0f  // Takes time to get comfortable
        }
    };
    }
}
