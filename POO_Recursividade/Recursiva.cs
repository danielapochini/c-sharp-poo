using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Recursividade
{
    class Recursiva
    {
        // forma não recursiva
        public void Executar(String mensagem, int n)
        {
            for(int i=0; i<n; i++)
            {
                Console.WriteLine(mensagem);
            }

        }

        // forma recursiva
        public void ExecutarRecursivo(String mensagem, int n)
        {
            if (n > 0)
            {
                Console.WriteLine(mensagem);
                ExecutarRecursivo(mensagem, n - 1); 
            }
        }
    }
}
