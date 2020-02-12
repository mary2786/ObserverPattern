using ObserverPattern.Publishers;
using ObserverPattern.Subscribers;
using System;

namespace ObserverPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********************************************************");
            Console.WriteLine("* Captura el número de una de las siguientes opciones:   *");
            Console.WriteLine("* 1 = Subir código                                       *");
            Console.WriteLine("* 2 = Agregar Notificador                                *");
            Console.WriteLine("* 3 = Agregar Compilador                                 *");
            Console.WriteLine("* 4 = Agregar Ejecutor de Pruebas Unitarias              *");
            Console.WriteLine("* 5 = Agregar Instalador                                 *");
            Console.WriteLine("**********************************************************");

            string text;
            UploadCode uploadCode = new UploadCode();
            Notifier notifier = new Notifier();
            Compiler compiler = new Compiler();
            UnitTestExecutor executor = new UnitTestExecutor();
            Installer installer = new Installer();

            do
            {
                text = Console.ReadLine();
                switch (text)
                {
                    case "1":
                        uploadCode.PrintMessage();
                        break;
                    case "2":
                        uploadCode.Subscribe(notifier);
                        break;
                    case "3":
                        uploadCode.Subscribe(compiler);
                        break;
                    case "4":
                        uploadCode.Subscribe(executor);
                        break;
                    case "5":
                        uploadCode.Subscribe(installer);
                        break;
                    default:
                        Console.WriteLine("No existe esa opción en el menú");
                        break;
                }
            } while (text != null);
        }
    }
}
