using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities;
public class PlowedField : IFacility<ISeedProducing>
{
    private int _PlantPerRow = 5;
    private int _Rowcapacity = 13;



    private List<ISeedProducing> _plants = new List<ISeedProducing>();
    private Guid _id = Guid.NewGuid();

    public double Capacity
    {
        get
        {
            return _PlantPerRow * _Rowcapacity;
        }
    }

    public void AddResource(ISeedProducing plant)
    {
        // TODO: implement this...
        throw new NotImplementedException();
    }

    public void AddResource(List<ISeedProducing> plants)
    {
        // TODO: implement this...
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        StringBuilder output = new StringBuilder();
        string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

        output.Append($"Plowed field {shortId} has {this._plants.Count} plants with {_PlantPerRow} per row\n");
        this._plants.ForEach(p => output.Append($"   {p}\n"));

        return output.ToString();
    }
}