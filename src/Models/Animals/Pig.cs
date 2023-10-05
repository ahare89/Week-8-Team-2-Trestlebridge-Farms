using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals
{
    public class Pig : IResource, IGrazing, IMeatProducing 
    {
        private Guid _id = Guid.NewGuid();
        public string Type { get; } = "Pig";
        private string _shortId {
            get {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }
        private double _meatProduced = 8.4;
        public double Butcher () {
            return _meatProduced;
        }
        public double GrassPerDay { get; set; } = 3.2;
        public void Graze()
        {
        Console.WriteLine($"Pig {this._shortId} just ate {this.GrassPerDay}kg of grass");
        }
        public override string ToString() {
        return $"Pig {this._shortId}. Oink!";
        }
    }
}