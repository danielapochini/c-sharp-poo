using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Heranca
{
    // herança multipla/encadeada, caminhonete irá herdar de carro e carro está herdando de veículo
    sealed class Caminhonete : Carro
    {
        public bool CabineExtendida { get; set; }
    }
}
