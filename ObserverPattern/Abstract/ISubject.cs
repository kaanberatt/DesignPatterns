namespace ObserverPattern.Abstract
{
    public interface ISubject
    {
        string SubjectName { get; }
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify(string message);
    }
}
