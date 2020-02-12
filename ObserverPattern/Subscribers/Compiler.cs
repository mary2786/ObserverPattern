using System;

namespace ObserverPattern.Subscribers
{
    public class Compiler : ISubscriber
    {
        public void PrintMessage()
        {
            Console.WriteLine("Compilación de código correcta");
        }
    }
}
