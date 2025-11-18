using System;
using ObserverPattern.Abstract;

namespace ObserverPattern.Concrete
{
    public class InvestorObserver : IObserver
    {
        public string Name { get; }

        public InvestorObserver(string name)
        {
            Name = name;
        }

        public void Update(string message)
        {
            Console.WriteLine($"[Yatırımcı - {Name}] {message}");
        }
    }
}
