using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Propriedades
{
    class Teste
    {
        //definição de um campo
        private string _nome;
        public string Sobrenome { get; } = "Pochini";

        private int _idade;

        //definição de uma propriedade
        public string Nome
        {
            get
            {
                return _nome;
            }
            
            set
            {
                _nome = value;
            }
        }

        public int Idade
        {
            get
            {
                return _idade;
            }

            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Idade não pode ser inferior a 18");
                }
                else
                {
                    _idade = value;
                }
            }
        }

        public void Apresentar()
        {
            if (_nome != "")
            {
                Console.WriteLine("Bem vindo " + _nome);
            }
        }
    }
}
