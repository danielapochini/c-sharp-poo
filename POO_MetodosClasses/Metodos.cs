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

        // Passgem de parâmetros por valor
        public void AumentarValor(int valor)
        {
            valor += 10;
            Console.WriteLine("O valor final (por valor) é: " + valor);
        }

        // Passagem de parâmetros por referência
        public void AumentarRef(ref int valor)
        {
            valor += 10;
            Console.WriteLine("O valor final (por referência) é: " + valor);
        }

        // Métodos com retorno de valores
        public string MontaNome(string nome, string sobrenome)
        {
            //string nomeCompleto = nome + " " + sobrenome;
            return nome + " " + sobrenome;
        }

        public int CodigoChar(char caractere)
        {
            //int codigo = (int)caractere;
            return caractere;
        }

        public double ValorPI()
        {
            return 3.145;
        }

        // Sobrecarga de Métodos (Overloading) - Criar o mesmo método com várias assinaturas 
        public void Cumprimentar(string nome)
        {
            Console.WriteLine("Olá " + nome + ", seja bem vindo");
        }

        public void Cumprimentar(string nome, int hora)
        {

            string mensagem = hora < 12 ? "Bom dia " + nome : "Boa tarde " + nome;
            Console.WriteLine(mensagem);
        }

        public bool Comparar(int num1, int num2)
        {
            return num1 == num2;
        }

        public bool Comparar(string txt1, string txt2)
        {
            return txt1 == txt2;
        }
    }
}
