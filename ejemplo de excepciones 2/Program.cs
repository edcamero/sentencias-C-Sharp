using System;

namespace ejemplo_de_excepciones_2
{
    class Program
    {
        static void Main(string[] args)
        { 
            try
            {
                for(int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("5x" + i + "=" + i * 5);
                }
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
