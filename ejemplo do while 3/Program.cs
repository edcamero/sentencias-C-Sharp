using System;

namespace ejemplo_do_while_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string linea = "";
            int suma = 0, valor = 0;

            do
            {
                Console.Write("ingrese un numero \n");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                if (valor != 9999)
                {
                    suma = suma + valor;

                }

            } while (valor != 9999);

            Console.WriteLine("has salido del ciclo");
            Console.WriteLine("el valor acumulado es : " + suma);
            if (suma < 0)
            {
                Console.WriteLine("el valor acumulado es menor que cero");
            } else if (suma > 0) { 
                Console.WriteLine("el valor acumulado es mayor que cero");

            }else
                {
                Console.WriteLine("el valor acumulado es  cero");
                }
        }

    }
}
