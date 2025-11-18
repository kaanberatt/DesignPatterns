namespace ObserverPattern.Abstract;

public interface ISubject<TState>
{
    TState? CurrentState { get; }
    void Attach(IObserver<TState> observer);
    void Detach(IObserver<TState> observer);
    void Notify();
    void UpdateState(TState newState);
}
