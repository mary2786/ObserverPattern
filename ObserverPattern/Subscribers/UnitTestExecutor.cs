using System;

namespace ObserverPattern.Subscribers
{
    public class UnitTestExecutor : ISubscriber
    {
        public void PrintMessage()
        {
            Console.WriteLine("Todas las pruebas unitarias fueron exitosas");
        }
    }
}
