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
        Utils.Clear();

        for (int i = 0; i < farm.PlowedFields.Count; i++)
        {
            if (farm.PlowedFields[i].Capacity > farm.PlowedFields[i].RowCount)

                Console.WriteLine($"{i + 1}. Plowed Field");
        }
        Console.WriteLine();

        // How can I output the type of plant chosen here?
        Console.WriteLine($"Place the plant where?");

        Console.Write("> ");
        int choice = Int32.Parse(Console.ReadLine());

        if (farm.PlowedFields[choice - 1].Capacity > farm.PlowedFields[choice - 1].RowCount)
        {
            farm.PlowedFields[choice - 1].AddResource(plant);
        }
        else
        {
            Console.WriteLine("The field is FULL!");
        }
    }
}