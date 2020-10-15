using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Heranca
{
    // definindo que a classe Veiculo é do tipo abstrata
    // serve somente como base para as outras classes
    abstract class Veiculo
    {
        // herança permite que uma classe herde metodos, atributos, comportamentos de uma outra classe
        // facilitando na manutenção e reaproveitamento de código

        public string Cor { get; set; }
        public string Marca { get; set; }

        // o metódo abstrato não possui implementação, precisa ser implementado em cada classe que irá herdá-lo
        // cada uma definirá seu próprio comportamento
        public abstract void Acelerar();

        public abstract void Parar();
    }
}
