using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Heranca
{
    class Humano
    {
        // A palavra-chave virtual é usada para modificar uma declaração de método, propriedade, indexador ou evento 
        // e permitir que ela seja substituída em uma classe derivada.
        public virtual void Olhos()
        {
            Console.WriteLine("Humano.Olhos");
        }

        public virtual void Cabelos()
        {
            Console.WriteLine("Humano.Cabelos");
        }
    }

    class Pessoa : Humano
    {
        // override: está sobrescrevendo o método da classe que foi herdada
        // sealed: não permitira que o método seja modificado
        public sealed override void Olhos()
        {
            Console.WriteLine("Pessoa.Olhos");
        }

        public override void Cabelos()
        {
            Console.WriteLine("Pessoa.Cabelos");
        }
    }

    class Homem : Pessoa
    { 
        /*        
        public override void Olhos()
        {
            Console.WriteLine("Homem.Olhos");
        }
        */

        public override void Cabelos()
        {
            Console.WriteLine("Homem.Cabelos");
        }
    }
}
