using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Encapsulamento
{
    class Conta
    {

        // encapsulamento é o processo de ocultar ou esconder os membros de uma classe
        // dando acesso exterior usando um modificador de acesso e o encapsulamento fornece
        // uma maneira de preservar a integridade do estado dos dados

        public string _cliente;
        public double _saldo;
        private double _taxa = 10;

        public string Cliente
        {
            get { return _cliente;  }
            set
            {
                if (value != "Daniela" && value != "Teste")
                {
                    _cliente = "Visitante";
                    Saldo = 0;
                }
                else
                {
                    _cliente = value;
                    Saldo = 100;
                }
            }
        }

        public double Saldo
        {
            get { return _saldo; }

            private set { _saldo = value; }
        }

        public void Sacar(double valor)
        {
            valor += _taxa;
            _saldo -= valor;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }
    }
}
