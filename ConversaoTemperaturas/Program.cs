using System;

namespace ConversaoTemperaturas
{
    class Program
    {
        static void Main(string[] args)
        {
            double c, f, k;

            Console.WriteLine("### CONVERSOR DE TEMPERATURAS ###");
            Console.Write("Insira a temperatura em Celsius: ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("---------------");

            // F = (c * 9 / 5) + 32;
            f = (c * 9 / 5) + 32;

            // K = (c + 273,15);

            k = c + 273.15;

            Console.WriteLine("A temperatura em Celsius é: " + c + " graus");
            Console.WriteLine("A temperatura em Fahrenheits é: " + f + " graus");
            Console.WriteLine("A temperatura em Kelvin é: " + k + " graus");



        }
    }
}
