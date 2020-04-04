using System;

namespace ejemplo_for_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int mayores= 0,menores=0,nota=0;
            string linea = "";

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Ingrese la nota del alumno "+i+"\n");
                linea = Console.ReadLine();
                nota=int.Parse(linea);
                if (nota >= 7)
                {
                    mayores++;

                }
                else
                {
                    menores++;
                }
            }
            Console.Write("los alumnos con notas iguales o mayores a 7 son: " + mayores + "\n");
            Console.Write("los alumnos con notas menores 7 son: " + menores + "\n");
            Console.ReadKey();
        }
    }
}
