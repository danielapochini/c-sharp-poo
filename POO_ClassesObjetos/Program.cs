using System;

namespace POO_ClassesObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Classes e Objetos
            /*
            MinhaClasse mclasse = new MinhaClasse();
            MinhaClasse m2 = null;

            OutraClasse outra = new OutraClasse();
            OutraClasse outra2 = outra;
             */
            #endregion

            Pessoa p1 = new Pessoa();
            p1.nome = "Daniela";
            p1.sobrenome = "Pochini";
            p1.anoNascimento = 1993;

            Pessoa p2 = new Pessoa()
            {
                nome = "Teste01",
                sobrenome = "Teste",
                anoNascimento = 2020
            };

            p1.nome = "Jason";

            Console.WriteLine("Pessoa 1: " + p1.nome);
            Console.WriteLine("Pessoa 1: " + p1.sobrenome);
            Console.WriteLine("Pessoa 1: " + p1.anoNascimento);

            Console.WriteLine();

            Console.WriteLine("Pessoa 1: " + p2.nome);
            Console.WriteLine("Pessoa 1: " + p2.sobrenome);
            Console.WriteLine("Pessoa 1: " + p2.anoNascimento);

            Console.ReadKey();

        }

        class MinhaClasse
        {

        }
    }
}
