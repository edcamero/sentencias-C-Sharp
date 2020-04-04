using System;

namespace ejemplo_foreach_2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int n = 0;
            string linea = "";
            Console.WriteLine("ingrese el tamaño del vector ");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            int[] vector = new int[n];
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("ingrese un valor para el elemento: "+i);
                linea = Console.ReadLine();
                vector[i]  = int.Parse(linea);
                
            }

            foreach( int dato in vector)
            {
                if (dato > 100)
                {
                    Console.WriteLine("los datos resultantes mayores a 100");
                    Console.WriteLine(dato);
                }
                
            }
            Console.ReadKey();

        }
    }
}
