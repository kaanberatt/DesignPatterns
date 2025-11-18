using ObserverPattern.Abstract;
using ObserverPattern.Models;

namespace ObserverPattern.Concrete.Subjects;

public class StockMarketSubject : ISubject<StockPrice>
{
    private readonly List<IObserver<StockPrice>> _observers = new();

    public StockPrice? CurrentState { get; private set; }

    public void Attach(IObserver<StockPrice> observer)
    {
        if (!_observers.Contains(observer))
        {
            _observers.Add(observer);
            Console.WriteLine($"{observer.Name} borsa güncellemelerine abone oldu.");
        }
    }

    public void Detach(IObserver<StockPrice> observer)
    {
        if (_observers.Remove(observer))
        {
            Console.WriteLine($"{observer.Name} abonelikten ayrıldı.");
        }
    }

    public void Notify()
    {
        if (CurrentState is null)
        {
            return;
        }

        foreach (var observer in _observers)
        {
            observer.Update(CurrentState);
        }
    }

    public void UpdateState(StockPrice newState)
    {
        CurrentState = newState;
        Console.WriteLine($"\n> {newState.Symbol} hissesi {newState.Price:C} olarak güncellendi.");
        Notify();
    }
}
