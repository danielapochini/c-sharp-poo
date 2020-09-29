using System;

namespace EntradaSaida
{
    class Program
    {
        static void Main(string[] args)
        {
            //saida de dados
            Console.Write("Daniela "); // imprime algo sem quebra de linha
            Console.WriteLine("Teste"); // imprime algo na tela com quebra de linha

            //entrada de dados
            int letra = Console.Read();
            string texto = Console.ReadLine(); //le a proxima linha de caracteres (retorna uma string)
            Console.WriteLine(texto);  

            //Console.ReadKey(false);
            Console.ReadKey(); //capturar uma tecla digitada a partir do teclado
        }
    }
}
