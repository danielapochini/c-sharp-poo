using System;
using System.Collections.Generic;
using System.Text;

namespace POO_MetodosClasses
{
    class Metodos
    {
        // Métodos simples 
        public void Cumprimentar()
        {
            Console.WriteLine("Olá, seja bem vindo");
        }

        // Métodos com parâmetros  
        public void Somar(int num1, int num2)
        {
            int res = num1 + num2;
            Console.WriteLine("A soma é: " + res);
        }

        public void Apresentar(string nome, int idade)
        {
            Console.WriteLine("Meu nome é " + nome + " e tenho " + idade + " anos");
        }
    }
}
