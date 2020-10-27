using System;

namespace POO_Recursividade
{
    // recursividade: um recurso de um método chamar a si mesmo
    // ou seja, dentro do seu corpo de execução, ele executa uma subrotina dele mesmo.

    class Program
    {

        static void Main(string[] args)
        {
            Recursiva r = new Recursiva();
            //r.Executar("Ola mundo!", 5); 
            r.ExecutarRecursivo("Ola mundo!", 5);
        }
    }
}
