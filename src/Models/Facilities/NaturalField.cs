using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities;
public class NaturalField : IFacility<ICompostProducing>
{
    private int _PlantPerRow = 6;
    private int _Rowcapacity = 10;



    private List<ICompostProducing> _plants = new List<ICompostProducing>();
    private Guid _id = Guid.NewGuid();

    public double Capacity
    {
        get
        {
            return _PlantPerRow * _Rowcapacity;
        }
    }

    public void AddResource(ICompostProducing plant)
    {
        _plants.Add(plant);
    }

    public void AddResource(List<ICompostProducing> plants)
    {
        // TODO: implement this...
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        StringBuilder output = new StringBuilder();
        string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

        output.Append($"Natural field {shortId} has {this._plants.Count} plants with {_PlantPerRow} per row\n");
        this._plants.ForEach(p => output.Append($"   {p}\n"));

        return output.ToString();
    }
}