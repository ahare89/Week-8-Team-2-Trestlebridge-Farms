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
            Console.WriteLine($"{i + 1}. Plowed Field");
        }
        Console.WriteLine();

        // How can I output the type of plant chosen here?
        Console.WriteLine($"Place the plant where?");

        Console.Write("> ");
        int choice = Int32.Parse(Console.ReadLine());

        farm.PlowedFields[choice].AddResource(plant);
    }
}