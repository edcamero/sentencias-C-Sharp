using System;

namespace sentenciaIf3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.Write("Ingrese un valor entero de 1 o 2 dígitos:");
            num = int.Parse(Console.ReadLine());
            if (num > 0 && num < 100)
            {
                if (num < 10)
                {
                    Console.Write("Tiene un dígito");
                }
                else
                {
                    Console.Write("Tiene dos dígitos");
                }
            }
            else
            {
                Console.Write("Digito no valido");
            }
            Console.ReadKey();
        }
    }
}
