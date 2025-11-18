namespace ObserverPattern.Abstract;

public interface IObserver<TState>
{
    string Name { get; }
    void Update(TState updatedState);
}
