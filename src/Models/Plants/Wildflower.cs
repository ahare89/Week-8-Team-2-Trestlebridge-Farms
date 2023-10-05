using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants;

public class Wildflower : IResource, ICompostProducing
{
    private double _compostProduced = 30.3;
    public string Type { get; }
    public double ShovelCompost()
    {
        return _compostProduced;
    }
    public override string ToString()
    {
        return $"{this}. I'm so yummmmyyyy!! Eat me!";
    }
}