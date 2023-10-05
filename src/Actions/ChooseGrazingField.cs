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
            while (true)
            {
                Utils.Clear();
                Console.WriteLine($"0. Exit to main menu");
                
                for (int i = 0; i < farm.GrazingFields.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. Grazing  ({farm.GrazingFields[i].AnimalCount} animals)");
                    Console.WriteLine(farm.GrazingFields[i]);
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
                else if (farm.GrazingFields[choice - 1].Capacity > farm.GrazingFields[choice - 1].AnimalCount)
                {
                    farm.GrazingFields[choice - 1].AddResource(animal);
                    Console.WriteLine("Animal added.");
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
            

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}