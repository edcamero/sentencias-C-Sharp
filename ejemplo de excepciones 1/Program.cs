using System;

namespace ejemplo_de_excepciones_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int i = 0;
                i = i / 0;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
}
