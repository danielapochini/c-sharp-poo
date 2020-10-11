using System;

namespace EstruturasRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ciclo While
            /*
            int valor = 15;

            while (valor < 10)
            {
                Console.WriteLine("O valor é :" + valor);
                valor++;
            }

            Console.ReadKey();
            */
            #endregion

            #region Ciclo Do - While
            /*
            int valor = 15;
            do
            {
                Console.WriteLine("O valor é: " + valor);
                valor++;
            } while (valor < 10);
            //irá imprimir o valor, depois irá verificar que a condição é falsa e não entrará no laço de repetição
            Console.ReadKey();
            */
            #endregion

            //irá executar enquanto o i for menor que 10
            for (int i = 0, j = 10; i < 10; i++, j--)
            {
                Console.WriteLine("I = " + i + " | J = " +j);
            }

            Console.ReadKey();
        }
    }
}
