using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Actions;

public class PurchaseSeed
{
    public static void CollectInput(Farm farm)
    {
        Console.WriteLine("1. Sunflower");
        Console.WriteLine("2. Wildflower");
        Console.WriteLine("3. Sesame");

        Console.WriteLine();
        Console.WriteLine("What are you buying today?");

        Console.Write("> ");
        string choice = Console.ReadLine();

        switch (Int32.Parse(choice))
        {
            case 1:
            // ChooseSeedField.CollectInput(farm, new Sunflower());
            // break; ...needs Plowed/NaturalField, ChoosePlowed/NaturalField & seed models set up;
            // case 2:
            //     ChooseGrazingField.CollectInput(farm, new Wildflower());
            //     break; ...needs NaturalField, ChooseNaturalField & seed models set up;
            // case 3:
            //     ChooseGrazingField.CollectInput(farm, new Sesame());
            //     ChooseGrazingField.CollectInput(farm, new Wildflower());
            //     break; ...needs PlowedField, ChoosePlowedField & seed models set up;
            default:
                break;
        }
    }
}