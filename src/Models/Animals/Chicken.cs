using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals
{
    public class Chicken : IResource, IEggHarvesting, IFeatherHarvesting, IFeeding, IMeatProducing 
    {
        private int _eggs = 7;
        public int HarvestEggs()
        {
            return _eggs;
        }
        private double _meatProduced = 1.7;
        public double Butcher () {
            return _meatProduced;
        }

        private Guid _id = Guid.NewGuid();
        public string Type { get; } = "Chicken";
        private double _feathers = 0.5;
        public double HarvestFeathers() 
        {
            return _feathers;
        
        }
        private string _shortId {
            get {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }
        public double FeedPerDay { get; set; } = 0.9;
        public void Feed()
        {
        Console.WriteLine($"Chicken {this._shortId} just ate {this.FeedPerDay}kg of Feed");
        }
        public override string ToString() {
        return $"Chicken {this._shortId}. Cluck!";
        }
    }
}