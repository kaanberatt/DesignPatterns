namespace ObserverPattern.Abstract
{
    public interface IObserver
    {
        string Name { get; }
        void Update(string message);
    }
}
