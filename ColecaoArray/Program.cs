using System;

namespace ColecaoArray
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Vetores
            /*
                        // vetor armazena mais de um elemento
                        //declarando vetor de numeros inteiros
                        int[] numeros = new int[5];

                        //atribuição de valores
                        numeros[0] = 10;
                        numeros[1] = 20;
                        numeros[2] = 30;
                        numeros[3] = 40;
                        numeros[4] = 50;

                        //referenciar e alterar valor de uma posição
                        numeros[2] = 55;

                        //declarado vetor de outra forma
                        string[] nomes = 
                         {
                            "Daniela", 
                            "Teste1", 
                            "Teste2"
                        };

                        nomes[0] = "Teste0";

                        Console.WriteLine(numeros[2]); //imprime 55
                        Console.WriteLine(nomes[0]); //imprime "Teste0"
                        Console.ReadKey();
            */
            #endregion

            //a virgula na declaração indica que é um array bidimensional/matriz
            //matriz de inteiros com 2 linhas e 3 colunas 
            int[,] numeros = new int[2, 3];
            numeros[0, 0] = 10;
            numeros[0, 1] = 20;
            numeros[0, 2] = 30;

            numeros[1, 0] = 40;
            numeros[1, 1] = 50;
            numeros[1, 2] = 60; 

            Console.Write("[" + numeros[0, 0] +"]");
            Console.Write("[" + numeros[0, 1] + "]");
            Console.Write("[" + numeros[0, 2] + "]");

            Console.WriteLine();

            Console.Write("[" + numeros[1, 0] + "]");
            Console.Write("[" + numeros[1, 1] + "]");
            Console.Write("[" + numeros[1, 2] + "]");

            Console.WriteLine();

            string[,] nomes =
             {
                { "Teste00", "Teste01", "Teste02" },
                { "Teste03", "Teste04", "Teste05" }
            };

            Console.WriteLine(nomes[0, 1]);
            Console.ReadKey();
        }
    }
}
