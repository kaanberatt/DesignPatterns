using System.Collections.Generic;
using ObserverPattern.Abstract;

namespace ObserverPattern.Concrete
{
    public class StockSubject : ISubject
    {
        private readonly List<IObserver> _observers = new();

        public string Symbol { get; }
        public decimal Price { get; private set; }
        public string SubjectName => $"Borsa - {Symbol}";

        public StockSubject(string symbol, decimal initialPrice)
        {
            Symbol = symbol;
            Price = initialPrice;
        }

        public void Attach(IObserver observer)
        {
            if (_observers.Contains(observer))
            {
                return;
            }

            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            if (!_observers.Contains(observer))
            {
                return;
            }

            _observers.Remove(observer);
        }

        public void Notify(string message)
        {
            foreach (var observer in _observers)
            {
                observer.Update(message);
            }
        }

        public void UpdatePrice(decimal newPrice)
        {
            if (newPrice == Price)
            {
                return;
            }

            var oldPrice = Price;
            Price = newPrice;
            var trend = newPrice > oldPrice ? "yükseldi" : "düştü";
            var message = $"{Symbol} hissesi {trend}. Eski fiyat: {oldPrice:C}, yeni fiyat: {newPrice:C}";
            Notify(message);
        }
    }
}
