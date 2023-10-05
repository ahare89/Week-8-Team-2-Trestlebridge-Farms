using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Models
{
    public class Farm
    {
        public List<GrazingField> GrazingFields { get; } = new List<GrazingField>();

        public List<DuckHouse> DuckHouses { get; } = new List<DuckHouse>();
        public List<ChickenHouse> ChickenHouses { get; } = new List<ChickenHouse>();

        /*
            This method must specify the correct product interface of the
            resource being purchased.
         */
        public void PurchaseResource<T> (IResource resource, int index)
        {
            Console.WriteLine(typeof(T).ToString());
            switch (typeof(T).ToString())
            {
                case "Cow":
                    GrazingFields[index].AddResource((IGrazing)resource);
                    break;
                case "Duck":
                    DuckHouses[index].AddResource((IFeeding)resource);
                    break;
                case "Chicken":
                    ChickenHouses[index].AddResource((IFeeding)resource);
                    break;
                default:
                    break;
            }
        }

        public void AddGrazingField (GrazingField field)
        {
            GrazingFields.Add(field);
        }
        public void AddDuckHouse (DuckHouse duckHouse)
        {
            DuckHouses.Add(duckHouse);
        }
        public void AddChickenHouse (ChickenHouse chickenHouse)
        {
            ChickenHouses.Add(chickenHouse);
        }

       

        public override string ToString()
        {
            StringBuilder report = new StringBuilder();

            GrazingFields.ForEach(gf => report.Append(gf));
            DuckHouses.ForEach(dh => report.Append(dh));

            return report.ToString();
        }
    }
}