using System;

namespace POO_ClassesEstaticas
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Classe Estatica
            /*
            Matematica.taxa = 10;

            int valor1 = Matematica.Adicionar(200);
            int valor2 = Matematica.Adicionar(200);

            Console.WriteLine("Valor 1: " + valor1);
            Console.WriteLine("Valor 2: " + valor2);
            */
            #endregion

            #region Membros estáticos

            Pessoa.maioridade = 21;

            Pessoa p = new Pessoa();
            p.nome = "Daniela";
            p.idade = Pessoa.CalcularIdade(1993);

            Console.WriteLine(p.nome);
            Console.WriteLine(p.idade);
            Console.WriteLine(Pessoa.maioridade);
            #endregion
        }
    }
}
