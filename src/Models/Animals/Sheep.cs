using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals
{
    public class Sheep : IResource, IGrazing, IMeatProducing 
    {
        private Guid _id = Guid.NewGuid();
        public string Type { get; } = "Sheep";
        private string _shortId {
            get {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }
        private double _meatProduced = 5;
        public double Butcher () {
            return _meatProduced;
        }
        public double GrassPerDay { get; set; } = 4.1;
        public void Graze()
        {
        Console.WriteLine($"Sheep {this._shortId} just ate {this.GrassPerDay}kg of grass");
        }
        public override string ToString() {
        return $"Sheep {this._shortId}. Baaaa!";
        }
    }
}