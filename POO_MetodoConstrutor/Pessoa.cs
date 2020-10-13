using System;
using System.Collections.Generic;
using System.Text;

namespace POO_MetodoConstrutor
{
    class Pessoa
    {
        public string nome;
        public string sobrenome;
        public int anoNascimento;
        public int idade;

        public Pessoa()
        {
            nome = "Desconhecido";
            sobrenome = "Nenhum";
            anoNascimento = 0;
            idade = 0;
        }
    }
}
