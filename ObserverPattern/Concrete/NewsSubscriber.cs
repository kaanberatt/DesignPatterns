using System;
using ObserverPattern.Abstract;

namespace ObserverPattern.Concrete
{
    public class NewsSubscriber : IObserver
    {
        public string Name { get; }

        public NewsSubscriber(string name)
        {
            Name = name;
        }

        public void Update(string message)
        {
            Console.WriteLine($"[Abone - {Name}] {message}");
        }
    }
}
