﻿using System;

namespace senteciaSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("prograama de sentencia switch");
            Console.WriteLine("Escriba el numero ");
            numero = int.Parse(Console.ReadLine());
            switch(numero){
                case 1:
                Console.WriteLine("UNO");
                break;
                case 2:
                Console.WriteLine("DOS");
                break;
                case 3:
                Console.WriteLine("TRES");
                
                break;
                case 4:
                Console.WriteLine("CUATRO");
                break;
                case 5:
                Console.WriteLine("CINCO");
                break;
                default:
                Console.WriteLine(" fuera de rango");
                break;

            }
            Console.ReadKey();
        }
    }
}
