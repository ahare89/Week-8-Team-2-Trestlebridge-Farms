using System;
using System.Reflection.Metadata;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;
using System.Timers;

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
                    Console.WriteLine("The Grazing Field was created! Press any button to continue");
                    Console.ReadLine();
                    break;
                case 2:
                    farm.AddDuckHouse(new DuckHouse());
                    Console.WriteLine("The Duck House was created! Press any button to continue");
                    Console.ReadLine();
                    break;
                case 3:
                    farm.AddChickenHouse(new ChickenHouse());
                    Console.WriteLine("The Chicken House was created! Press any button to continue");
                    Console.ReadLine();
                    break;
                case 4:
                    farm.AddPlowedField(new PlowedField());
                    Console.WriteLine("The Plowed Field was created! Press any button to continue");
                    Console.ReadLine();
                    break;
                case 5:
                    farm.AddNaturalField(new NaturalField());
                    Console.WriteLine("The Natural Field was created! Press any button to continue");
                    Console.ReadLine();
                    break;
                default:
                    break;
            }
        }
    }
}