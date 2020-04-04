using System;

namespace ejemplo_for_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            double promedio = 0.0;
            string linea = "";
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Ingrese el valor numero " + i +"\n");
                linea = Console.ReadLine();
                suma = suma + int.Parse(linea);
            }
            promedio = suma / 10;
            Console.Write("La suma de los dos valores es:");
            Console.WriteLine(suma);
            Console.Write("El promedio de los dos valores es:");
            Console.WriteLine(promedio);
            Console.ReadKey();
        }
    }
}
