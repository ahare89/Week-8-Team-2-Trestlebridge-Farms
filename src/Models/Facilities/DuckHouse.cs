using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities
{
  public class DuckHouse : IFacility<IFeeding>
  {

    private Guid _id = Guid.NewGuid();

    private List<IFeeding> _ducks = new List<IFeeding>();
    public double _capacity = 12;

    public double Capacity
    {
      get
      {
        return _capacity;
      }
    }

    public void AddResource(IFeeding animal)
    {
      _ducks.Add(animal);
    }

    public int AnimalCount
    {
      get
      {
        return _ducks.Count;
      }
    }

    public void AddResource(List<IFeeding> animals)
    {
      // TODO: implement this...
      throw new NotImplementedException();
    }

    public override string ToString()
    {
      StringBuilder output = new StringBuilder();
      string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

      output.Append($"Duck House {shortId} has {this._ducks.Count} animals\n");
      this._ducks.ForEach(a => output.Append($"   {a}\n"));

      return output.ToString();
    }
  }
}