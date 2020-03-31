using System;

namespace senteciaSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            string numero;
            Console.WriteLine("prograama de sentencia switch");
            Console.WriteLine("Escriba el numero en castellano");
            numero = Console.ReadLine();
            switch(numero){
                case "UNO":
                Console.WriteLine("1");
                break;
                case "DOS":
                Console.WriteLine("2");
                break;
                case "TRES":
                Console.WriteLine("3");
                
                break;
                case "CUATRO":
                Console.WriteLine("4");
                break;
                case "CINCO":
                Console.WriteLine("5");
                break;
                default:
                Console.WriteLine(" no es asi");
                break;

            }
        }
    }
}
