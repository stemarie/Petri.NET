namespace Petri
{
    public interface IArc : INameable
    {
        int Capacity { get; }
        int Weight { get; }
    }
}