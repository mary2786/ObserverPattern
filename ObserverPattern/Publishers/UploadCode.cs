using ObserverPattern.Subscribers;
using System;
using System.Collections.Generic;

namespace ObserverPattern.Publishers
{
    public class UploadCode
    {
        private List<ISubscriber> _observers = new List<ISubscriber>();

        public void Subscribe(ISubscriber observer)
        {
            if (!_observers.Contains(observer))
            {
                Console.WriteLine("Se ha suscrito el evento " + observer.GetType().Name);
                _observers.Add(observer);
            }
            else
            {
                Console.WriteLine("Ya se ha suscrito el evento " + observer.GetType().Name);
            }
            
        }

        public void UnSubscribe(ISubscriber observer)
        {
            _observers.Remove(observer);
        }

        public void NotifySubscribers()
        {
            foreach(ISubscriber observer in _observers)
            {
                observer.PrintMessage();
            }
        }

        public void PrintMessage()
        {
            Console.WriteLine("Commit de código de la versión 1.1");
            NotifySubscribers();
        }
    }
}
