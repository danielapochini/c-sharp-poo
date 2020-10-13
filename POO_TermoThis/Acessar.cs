using System;
using System.Collections.Generic;
using System.Text;

namespace POO_TermoThis
{
    class Acessar
    {
        string senha = "abc123";

        //this faz referência à classe onde ele está sendo estanciado

        public bool Login(string senha)
        {
            return this.senha == senha;
        }
    }
}
