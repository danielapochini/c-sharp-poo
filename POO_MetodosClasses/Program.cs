using System;

namespace POO_MetodosClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodos m = new Metodos();
            m.Cumprimentar();
            m.Somar(1, 2);
            m.Apresentar("Daniela", 26);

            int valor1 = 100;
            int valor2 = 100;

            m.AumentarValor(valor1);
            m.AumentarRef(ref valor2);

            Console.WriteLine("Valor 1: " +valor1); // continuará com o mesmo valor, pois passamos uma "cópia" do valor
            Console.WriteLine("Valor 2: " +valor2); // será afetada o valor original, com o valor que passamos pois foi por referência
        }
    }
}
