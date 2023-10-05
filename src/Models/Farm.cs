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
        public List<PlowedField> PlowedFields { get; } = new List<PlowedField>();
        public List<NaturalField> NaturalFields { get; } = new List<NaturalField>();

        /*
            This method must specify the correct product interface of the
            resource being purchased.
         */
        public void PurchaseResource<T>(IResource resource, int index)
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
                case "Goat":
                    GrazingFields[index].AddResource((IGrazing)resource);
                    break;
                case "Ostrich":
                    GrazingFields[index].AddResource((IGrazing)resource);
                    break;
                case "Pig":
                    GrazingFields[index].AddResource((IGrazing)resource);
                    break;
                case "Sheep":
                    GrazingFields[index].AddResource((IGrazing)resource);
                    break;
                case "Sesame":
                    PlowedFields[index].AddResource((ISeedProducing)resource);
                    break;
                // case "Sunflower":
                //     ChickenHouses[index].AddResource((IFeeding)resource);
                // break;
                case "Wildflower":
                    NaturalFields[index].AddResource((ICompostProducing)resource);
                    break;
                default:
                    break;
            }
        }

        public void AddGrazingField(GrazingField field)
        {
            GrazingFields.Add(field);
        }
        public void AddDuckHouse(DuckHouse duckHouse)
        {
            DuckHouses.Add(duckHouse);
        }
        public void AddChickenHouse(ChickenHouse chickenHouse)
        {
            ChickenHouses.Add(chickenHouse);
        }
        public void AddPlowedField(PlowedField plowedField)
        {
            PlowedFields.Add(plowedField);
        }
        public void AddNaturalField(NaturalField naturalField)
        {
            NaturalFields.Add(naturalField);
        }



        public override string ToString()
        {
            StringBuilder report = new StringBuilder();

            GrazingFields.ForEach(gf => report.Append(gf));
            DuckHouses.ForEach(dh => report.Append(dh));
            ChickenHouses.ForEach(ch => report.Append(ch));
            PlowedFields.ForEach(pf => report.Append(pf));
            NaturalFields.ForEach(nf => report.Append(nf));

            return report.ToString();
        }
    }
}