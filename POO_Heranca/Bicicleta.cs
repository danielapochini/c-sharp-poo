using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Heranca
{
    class Bicicleta : Veiculo
    { 
        public void Pedalar()
        {

        }

        // na classe que irá herdar o método, substituimos o abstract por override
        // isso indica que  esse método está sendo sobescrito, cada classe terá um comportamento diferente
        public override void Acelerar()
        {
            Console.WriteLine("Acelerou a bicicleta!");
        }

        public override void Parar()
        {
            Console.WriteLine("Parou a bicicleta!");
        }

    }
}
