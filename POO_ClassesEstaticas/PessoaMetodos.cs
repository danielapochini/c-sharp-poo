using System;
using System.Collections.Generic;
using System.Text;

namespace POO_ClassesEstaticas
{
    partial class PessoaAtributos
    {
        public void Apresentar()
        {
            Console.WriteLine("Olá, eu sou " + nome);
        }

        public static int CalcularIdade(int anoNascimento)
        {
            return DateTime.Now.Year - anoNascimento;
        }
    }
}
