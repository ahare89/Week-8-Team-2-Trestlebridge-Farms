using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants;

public class Sunflower : ISeedProducing, IResource
{
    private int _seedsProduced = 40;
    public string Type { get; }
    public double Harvest()
    {
        return _seedsProduced;
    }
    public override string ToString()
    {
        return $"{this}. Yum!";
    }
}