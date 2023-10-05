using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants;

public class Sunflower : ISeedProducing, IResource, ICompostProducing
{
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
        return $"{this}. Yum!";
    }
}