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

            int valor = 15;
            do
            {
                Console.WriteLine("O valor é: " + valor);
                valor++;
            } while (valor < 10);
            //irá imprimir o valor, depois irá verificar que a condição é falsa e não entrará no laço de repetição
            Console.ReadKey();
        }
    }
}
