using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseDuckHouse
    {
        public static void CollectInput(Farm farm, IFeeding animal)
        {
            Utils.Clear();

            for (int i = 0; i < farm.DuckHouses.Count; i++)
            {
                if (farm.DuckHouses[i].Capacity > farm.DuckHouses[i].AnimalCount)
                {
                    Console.WriteLine($"{i + 1}. Duck House");
                }
            }
            Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place the animal where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());

            if (farm.DuckHouses[choice - 1].Capacity > farm.DuckHouses[choice - 1].AnimalCount)
            {
                farm.DuckHouses[choice - 1].AddResource(animal);
            }
            else
            {
                Console.WriteLine("The Duck House is FULL!");
            }

        }
    }
}
