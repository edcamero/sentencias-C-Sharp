using System;

namespace ejemplo_foreach_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sueldos = new int[5]; 
            for (int f = 0; f < 5; f++)
            { Console.Write("Ingrese valor de la componente:");
                String linea; linea = Console.ReadLine();
                sueldos[f] = int.Parse(linea); 
            }
            foreach (int s in sueldos) { Console.WriteLine(s); }
            Console.ReadKey();
        }
    }
}
