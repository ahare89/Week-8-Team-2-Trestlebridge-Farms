using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseChickenHouse
    {
        public static void CollectInput(Farm farm, IFeeding animal)
        {
            Utils.Clear();

            for (int i = 0; i < farm.ChickenHouses.Count; i++)
            {
                if (farm.ChickenHouses[i].Capacity > farm.ChickenHouses[i].AnimalCount)
                {
                    Console.WriteLine($"{i + 1}. Chicken House  ({farm.ChickenHouses[i].AnimalCount} chickens)");
                }
            }
            Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place the animal where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());

            if (farm.ChickenHouses[choice - 1].Capacity > farm.ChickenHouses[choice - 1].AnimalCount)
            {
                farm.ChickenHouses[choice - 1].AddResource(animal);
            }
            else
            {
                Console.WriteLine("The Coop is FULL!");
            }

        }
    }
}