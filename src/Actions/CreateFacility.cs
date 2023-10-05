using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class CreateFacility
    {
        public static void CollectInput(Farm farm)
        {
            Console.WriteLine("1. Grazing field");
            Console.WriteLine("2. Duck House");
            Console.WriteLine("3. Chicken House");
            Console.WriteLine("4. Plowerd field");
            Console.WriteLine("5. Natural field");

            Console.WriteLine();
            Console.WriteLine("Choose what you want to create");

            Console.Write("> ");
            string input = Console.ReadLine();

            switch (Int32.Parse(input))
            {
                case 1:
                    farm.AddGrazingField(new GrazingField());
                    break;
                case 2:
                    farm.AddDuckHouse(new DuckHouse());
                    break;
                case 3:
                    farm.AddChickenHouse(new ChickenHouse());
                    break;
                case 4:
                    farm.AddPlowedField(new PlowedField());
                    break;
                case 5:
                    farm.AddNaturalField(new NaturalField());
                    break;
                default:
                    break;
            }
        }
    }
}