using System;

namespace ObserverPattern.Subscribers
{
    public class Installer : ISubscriber
    {
        public void PrintMessage()
        {
            Console.WriteLine("Se ha instalado la versión 1.1");
        }
    }
}
