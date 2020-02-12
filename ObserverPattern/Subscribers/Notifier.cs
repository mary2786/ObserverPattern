using System;

namespace ObserverPattern.Subscribers
{
    public class Notifier : ISubscriber
    {
        public void PrintMessage()
        {
            Console.WriteLine("Existe una actualización de código: Versión 1.1");
        }
    }
}
