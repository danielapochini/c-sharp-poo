﻿using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Heranca
{
    class Carro : Veiculo
    { 
        public int VelocidadeMaxima { get; set; }

        public void LigarMotor()
        {
            Console.WriteLine("O carro ligou o motor");
        }

        public override void Acelerar()
        {
            Console.WriteLine("Acelerou o carro!");
        }

        public override void Parar()
        {
            Console.WriteLine("Parou o carro!");
        }
    }
}
