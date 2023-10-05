using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions;
public class ChoosePlowedField
{
    public static void CollectInput(Farm farm, ISeedProducing plant)
    {
        while (true)
        {
            Utils.Clear();
            Console.WriteLine($"0. Exit to main menu");

            for (int i = 0; i < farm.PlowedFields.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Plowed Field  ({farm.PlowedFields[i].RowCount} flowers)");
                Console.WriteLine(farm.PlowedFields[i]);
            }

            Console.WriteLine();

            // How can I output the type of plant chosen here?
            Console.WriteLine($"Place the plant where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"{choice}");

            if (choice == 0)
            {
                break;
            }
            else if (farm.PlowedFields[choice - 1].Capacity > farm.PlowedFields[choice - 1].RowCount)
            {
                farm.PlowedFields[choice - 1].AddResource(plant);
                Console.WriteLine("Plant added.");
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