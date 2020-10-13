using System;

namespace POO_MetodosClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodos m = new Metodos();

            #region Métodos Simples
            // m.Cumprimentar();
            #endregion

            #region Métodos com parâmetros
            /*
            m.Somar(1, 2);
            m.Apresentar("Daniela", 26);
            */
            #endregion

            #region Passagem de parâmetros por valor e por referência
            /*
            int valor1 = 100;
            int valor2 = 100;

            m.AumentarValor(valor1);
            m.AumentarRef(ref valor2);

            Console.WriteLine("Valor 1: " +valor1); // continuará com o mesmo valor, pois passamos uma "cópia" do valor da variável
            Console.WriteLine("Valor 2: " +valor2); // será afetada o valor original, com o valor que passamos pois foi por referência
            */
            #endregion

            #region Métodos com retorno de valores
            /*
            string nomeCompleto = m.MontaNome("Daniela", "Pochini");
            int codigoChar = m.CodigoChar('a'); 
            double pi = m.ValorPI();

            Console.WriteLine(nomeCompleto);
            Console.WriteLine(codigoChar);
            Console.WriteLine(pi);
            */
            #endregion

        }
    }
}
