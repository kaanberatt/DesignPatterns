using System.Collections.Generic;
using ObserverPattern.Abstract;

namespace ObserverPattern.Concrete
{
    public class NewsPublisher : ISubject
    {
        private readonly List<IObserver> _subscribers = new();

        public string PublisherName { get; }
        public string SubjectName => $"Haber Merkezi - {PublisherName}";

        public NewsPublisher(string publisherName)
        {
            PublisherName = publisherName;
        }

        public void Attach(IObserver observer)
        {
            if (_subscribers.Contains(observer))
            {
                return;
            }

            _subscribers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            if (!_subscribers.Contains(observer))
            {
                return;
            }

            _subscribers.Remove(observer);
        }

        public void Notify(string message)
        {
            foreach (var observer in _subscribers)
            {
                observer.Update(message);
            }
        }

        public void PublishNews(string category, string headline)
        {
            var message = $"{PublisherName} yeni bir haber paylaştı [{category}]: {headline}";
            Notify(message);
        }
    }
}
