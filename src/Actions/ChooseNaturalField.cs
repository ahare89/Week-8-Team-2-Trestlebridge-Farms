using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions;
public class ChooseNaturalField
{
    public static void CollectInput(Farm farm, ICompostProducing plant)
    {
        Utils.Clear();

        for (int i = 0; i < farm.NaturalFields.Count; i++)
        {
            if (farm.NaturalFields[i].Capacity > farm.NaturalFields[i].RowCount)
            {
                Console.WriteLine($"{i + 1}. Natural Field");
            }
        }
        Console.WriteLine();

        // How can I output the type of plant chosen here?
        Console.WriteLine($"Place the plant where?");

        Console.Write("> ");
        int choice = Int32.Parse(Console.ReadLine());

        if (farm.NaturalFields[choice - 1].Capacity > farm.NaturalFields[choice - 1].RowCount)


        {
            farm.NaturalFields[choice - 1].AddResource(plant);
        }
        else
        {
            Console.WriteLine("The field is FULL!");
        }
    }
}