using System;

namespace ejemplo_do_while_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string linea = "";
            double valor = 1;
            int digitos=0;
            do
            {
                Console.Write("ingrese un numero \n");
                linea = Console.ReadLine();
                valor = double.Parse(linea);
                digitos= (int)Math.Log10(valor) + 1;
                if(digitos>0)
                Console.Write("la cantidad de digitos es : "+ digitos+"\n");
            } while (valor != 0);
            Console.WriteLine("has salido del ciclo");
            Console.ReadKey();
        }
    }
}
