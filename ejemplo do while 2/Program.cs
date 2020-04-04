using System;

namespace ejemplo_do_while_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string linea = "";
            double suma = 0, valor = 1,  promedio =0;
            int  cont = 0;
            do
            {
                Console.Write("ingrese un numero \n");
                linea = Console.ReadLine();
                valor= double.Parse(linea);
                if (valor > 0) { 
                suma = suma + valor;
                cont++;
                }

            } while (valor != 0);
            promedio = suma / cont;
            Console.WriteLine("has salido del ciclo");
            Console.WriteLine("el promedio de los numero es: "+ promedio);
            Console.ReadKey();
        }
    
    }
}
