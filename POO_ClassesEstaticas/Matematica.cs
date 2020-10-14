using System;
using System.Collections.Generic;
using System.Text;

namespace POO_ClassesEstaticas
{
    //uma classe estatica não podemos instanciar objetos, para acessar seus membros 
    // utilizamos a própria classe como referência diretamente
    // ficará visível à todo projeto.
    static class Matematica
    {
        public static int taxa;

        public static int Adicionar(int valor)
        {
            return valor + taxa;
        }

        public static int Diminuir(int valor)
        {
            return valor - taxa;
        }

    }
}
