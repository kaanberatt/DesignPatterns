using ObserverPattern.Abstract;
using ObserverPattern.Models;

namespace ObserverPattern.Concrete.Observers;

public class ThresholdAlertObserver : IObserver<StockPrice>
{
    private readonly decimal _threshold;

    public ThresholdAlertObserver(string name, decimal threshold)
    {
        Name = name;
        _threshold = threshold;
    }

    public string Name { get; }

    public void Update(StockPrice updatedState)
    {
        if (updatedState.Price >= _threshold)
        {
            Console.WriteLine($"{Name} alarmı: {updatedState.Symbol} {_threshold:C} eşiğini aştı! (Şu an: {updatedState.Price:C})");
        }
        else
        {
            Console.WriteLine($"{Name} bilgilendirme: {updatedState.Symbol} {_threshold:C} seviyesinin altında, güncel değer {updatedState.Price:C}.");
        }
    }
}
