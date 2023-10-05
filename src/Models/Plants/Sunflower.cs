using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants;

public class Sunflower : ISeedProducing, IResource, ICompostProducing
{
    private Guid _id = Guid.NewGuid();

    private string _shortId {
            get {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }
    private int _seedsProduced = 650;
    private double _compostProduced = 21.6;
    public string Type { get; }
    public double Harvest()
    {
        return _seedsProduced;
    }

    public double ShovelCompost()
    {
        return _compostProduced;
    }
    public override string ToString()
    {
        return $"Sunflower #{this._shortId}. Yum!";
    }
}