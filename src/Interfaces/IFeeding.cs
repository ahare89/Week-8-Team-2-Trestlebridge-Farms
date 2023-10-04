namespace Trestlebridge.Interfaces
{
    public interface IFeeding
    {
        double FeedPerDay { get; set; }
        void Feed();
    }
}