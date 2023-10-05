using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities
{
    public class ChickenHouse : IFacility<IFeeding>
    {
        private Guid _id = Guid.NewGuid();
        private List<IFeeding> _chickens = new List<IFeeding>();
        public double _capacity = 15;
        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }
        public void AddResource(IFeeding animal)
        {
            _chickens.Add(animal);
        }
        public int AnimalCount
        {
            get
            {
                return _chickens.Count;
            }
        }
        public void AddResource(List<IFeeding> animals)
        {
            animals.ForEach(animal => _chickens.Add(animal));
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Chicken House {shortId} has {this._chickens.Count} animals\n");
            this._chickens.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}
