using System;

namespace ColecaoArray
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
