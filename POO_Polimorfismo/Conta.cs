using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Polimorfismo
{
    class CaixaEletronico : IConta
    {
        public string Usuario { get; set; }

        public void Depositar()
        {
             
        }

        public void Sacar()
        {
             
        }

        public void Saldo()
        {
             
        }

        public void SolicitarEmprestimo()
        {

        }
    }

    //interface inicia-se com I 
    // todos os membros de uma interface são public, para serem acessíveis a quem herdar
    // todos os metodos são abstratos, sem precisar colocar o modificador
    interface IConta
    {
        string Usuario { get; set; }
        void Depositar();

        void Sacar();

        void Saldo();

    }
}
