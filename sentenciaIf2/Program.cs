using System;

namespace sentenciaIf2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, resultado1, resultado2;
            Console.WriteLine("Programa de 2 numeros");
            Console.WriteLine("Escriba el numero 1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el numero 2");
            num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                resultado1 = num1 + num2;
                resultado2 = num1 - num2;
                Console.WriteLine("el resultado de la suma: " + resultado1);
                Console.WriteLine("el resultado de la resta: " + resultado2);
            }
            else
            {
                resultado1 = num1 * num2;
                resultado2 = num1 / num2;
                Console.WriteLine("el resultado de la multiplicacion: " + resultado1);
                Console.WriteLine("el resultado de la division: " + resultado2);
            }

            Console.WriteLine("Hello World!");
        }
    }
}
