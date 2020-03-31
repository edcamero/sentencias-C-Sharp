using System;

namespace sentenciaif
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1,nota2,nota3,suma,promedio;
            Console.WriteLine("Programa de 3 notas");
            Console.WriteLine("Escriba nota 1");
            nota1=float.Parse(Console.ReadLine());
            Console.WriteLine("Escriba nota 2");
            nota2=float.Parse(Console.ReadLine());
            Console.WriteLine("Escriba nota 3");
            nota3=float.Parse(Console.ReadLine());
            suma=nota1+nota2+nota3;
            promedio=suma/3;
            if(promedio>=3){
                Console.WriteLine("Es promovido");
            }else{
                Console.WriteLine("No es promovido");
            }


        }
    }
}
