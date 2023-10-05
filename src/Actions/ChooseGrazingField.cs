using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseGrazingField
    {
        public static void CollectInput(Farm farm, IGrazing animal)
        {
            Utils.Clear();

            for (int i = 0; i < farm.GrazingFields.Count; i++)
            {
                //follow same methodology on Chicken House and Duck House
                if (farm.GrazingFields[i].Capacity > farm.GrazingFields[i].AnimalCount)
                {
                    Console.WriteLine($"{i + 1}. Grazing  ({farm.GrazingFields[i].AnimalCount} animals)");
                }
            }

            Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place the animal where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());

            if (farm.GrazingFields[choice - 1].Capacity > farm.GrazingFields[choice - 1].AnimalCount)
            {
                farm.GrazingFields[choice - 1].AddResource(animal);
            }
            else
            {
                Console.WriteLine("The grazing field is FULL!");
            }

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}