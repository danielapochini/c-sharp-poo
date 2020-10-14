using System;

namespace POO_Propriedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Teste t = new Teste();
            t.Nome = "Daniela";
            t.Idade = 26;

            Console.WriteLine(t.Nome + " " + t.Sobrenome);
            Console.WriteLine(t.Idade);
        }
    }
}
