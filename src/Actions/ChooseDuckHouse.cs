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
            while (true)
            {
                Utils.Clear();
                Console.WriteLine($"0. Exit to main menu");

                for (int i = 0; i < farm.DuckHouses.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. Duck House  ({farm.DuckHouses[i].AnimalCount} ducks)");
                    Console.WriteLine(farm.DuckHouses[i]);
                }
                Console.WriteLine();

                // How can I output the type of animal chosen here?
                Console.WriteLine($"Place the animal where?");

                Console.Write("> ");
                int choice = Int32.Parse(Console.ReadLine());
                Console.WriteLine($"{choice}");
                
                if (choice == 0)
                {
                    break;
                }
                else if (farm.DuckHouses[choice - 1].Capacity > farm.DuckHouses[choice - 1].AnimalCount)
                {
                    farm.DuckHouses[choice - 1].AddResource(animal);
                    Console.WriteLine("Duck added.");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine($@"
**** That facililty is not large enough ****
****     Please choose another one      ****
(press any key)");
                    Console.ReadLine();
                }
            }

        }
    }
}
