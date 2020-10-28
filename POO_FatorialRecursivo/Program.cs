﻿using System;

namespace POO_FatorialRecursivo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Calcular fatorial de qual número? ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("O fatorial de " + num + " é: " + Fatorial(num));    
        }

        static int Fatorial(int num)
        {
            if (num <= 0)
            {
                return 1;
            }

            return num * Fatorial(num - 1);
            // 5 * Fatorial(4);
            // 4 * Fatorial(3);
            // 2 * Fatorial(1);
            // 1 * Fatorial(0);
            //return 1;
        }
    }
}
