using System;
using System.Collections.Generic;
using System.Text;

namespace POO_ClassesObjetos
{
    class Pessoa
    {
        // atributos ou campos
        public string nome;
        public string sobrenome;
        public int anoNascimento;

        // métodos simples
        public void Cumprimentar()
        {
            Console.WriteLine("Olá, eu sou " + nome + " " + sobrenome);

        }

    }
}
