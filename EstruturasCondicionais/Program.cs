using System;

namespace EstruturasCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Condição simples
            //int valor = 7;

            //if (valor < 5)
            //{
            //    Console.WriteLine("Condição verdadeira");
            //}
            //else
            //{
            //    Console.WriteLine("Condição retornou falso");
            //}
            #endregion

            #region Condição Encadeada
            /*
            int valor = 25;

            if (valor < 5)
            {
                Console.WriteLine("Condição verdadeira");
            }
            else if (valor >= 5 && valor < 10)
            {
                Console.WriteLine("Condição alternativa 1");
            } 
            else if (valor >=10 && valor < 20)
            {
                Console.WriteLine("Condição alternativa 2");
            }
            else
            {
                Console.WriteLine("Condição alternativa final");

            }
            Console.ReadKey();
            */

            #endregion

            #region Condição Aninhada
            /*
            int numero = 13;

            if (numero > 5)
            {
                Console.Write("O número é maior que 5");

                if (numero % 2 == 0)
                {
                    Console.WriteLine(" e também é par.");
                }
                else
                {
                    Console.WriteLine(" mas não é par");
                }
            }
            else
            {
                Console.Write("O número é menor que 5");
            }

            Console.ReadKey();
            */
            #endregion

        }
    }
}
