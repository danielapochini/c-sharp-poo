using System;

namespace EstruturasRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = 15;

            while (valor < 100)
            {
                Console.WriteLine("O valor é :" + valor);
                valor++;
            }

            Console.ReadKey();
        }
    }
}
