using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals
{
  public class Duck : IResource, IEggHarvesting, IFeatherHarvesting, IFeeding 
  {
    private Guid _id = Guid.NewGuid();

    public string Type { get; } = "Duck";

    private int _eggs = 6;  
    public int HarvestEggs() 
    {
        return _eggs;
    }

    private double _feathers = 0.75;
    public double HarvestFeathers() 
    {
        return _feathers;
      
    }

     private string _shortId {
            get {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

    public double FeedPerDay { get; set; } = 0.8;

    public void Feed()
    {
      Console.WriteLine($"Duck {this._shortId} just ate {this.FeedPerDay}kg of Feed");
    }

    public override string ToString() {
      return $"Duck {this._shortId}. Quack!";
    }
  }
}

