using System;

namespace ejemplo_for_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, numero = 0, cont = 0;
            string linea = "";
            Console.Write("la cantidad de numeros a pedir");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            for(int i = 1; i <= n; i++){
                Console.Write("ingrese el numero "+i+"\n");
                linea = Console.ReadLine();
                numero= int.Parse(linea);
                if (numero >= 1000)
                {
                    cont++;
                }
            }
            Console.Write("la cantidad de numero mayores o iguales  a 1000 son: "+cont);
            Console.ReadKey();
        }
    }
}
