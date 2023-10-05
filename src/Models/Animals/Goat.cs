using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals
{
    public class Goat : IResource, ICompostProducing, IGrazing 
    {
        private double _compost = 7.5;
        public double ShovelCompost()
        {
            return _compost;
        }
        private Guid _id = Guid.NewGuid();
        public string Type { get; } = "Goat";
        private string _shortId {
            get {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }
        public double GrassPerDay { get; set; } = 4.1;
        public void Graze()
        {
        Console.WriteLine($"Goat {this._shortId} just ate {this.GrassPerDay}kg of grass");
        }
        public override string ToString() {
        return $"Goat {this._shortId}. AAAAAAAAAAAA!";
        }
    }
}