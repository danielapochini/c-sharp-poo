using System;

namespace POO_TermoThis
{
    class Program
    {
        static void Main(string[] args)
        {
            Acessar a = new Acessar();

            if (a.Login("123"))
            {
                Console.WriteLine("Seja bem vindo");
            }
            else
            {
                Console.WriteLine("Acesso negado!");
            }
        }
    }
}
