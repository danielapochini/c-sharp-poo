using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Heranca
{
    class Veiculo
    {
        // herança permite que uma classe herde metodos, atributos, comportamentos de uma outra classe
        // facilitando na manutenção e reaproveitamento de código

        public string Cor { get; set; }
        public string Marca { get; set; }

        public void Acelerar()
        {
            Console.WriteLine("Acelerou!");
        }

        public void Parar()
        {
            Console.WriteLine("Parou!");
        }
    }
}
