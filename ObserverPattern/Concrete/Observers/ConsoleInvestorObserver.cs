using ObserverPattern.Abstract;
using ObserverPattern.Models;

namespace ObserverPattern.Concrete.Observers;

public class ConsoleInvestorObserver : IObserver<StockPrice>
{
    public ConsoleInvestorObserver(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public void Update(StockPrice updatedState)
    {
        Console.WriteLine($"{Name} bildirimi: {updatedState.Symbol} şu anda {updatedState.Price:C}. Güncelleme zamanı {updatedState.UpdatedAt:HH:mm:ss}.");
    }
}
