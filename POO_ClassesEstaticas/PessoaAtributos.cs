using System;
using System.Collections.Generic;
using System.Text;

namespace POO_ClassesEstaticas
{
    partial class PessoaAtributos
    {
        // membros estaticos são acessados diretamente pela refêrencia da classe 
        public static int maioridade = 18;
         
        // membros comuns o acesso é realizado apenas pelos objetos instanciados
        public string nome;
        public int idade;
         
    }
}
