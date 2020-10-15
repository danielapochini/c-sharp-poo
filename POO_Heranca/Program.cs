using System;

namespace POO_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Parte 1
            /*          
            Carro c = new Carro();
            Bicicleta b = new Bicicleta();
            //Veiculo v = new Veiculo(); não é possível instanciar objetos

            c.Acelerar();
            b.Acelerar();

            c.Parar();
            b.Parar();
            */
            #endregion

            Humano a = new Humano();
            Pessoa b = new Pessoa();
            Homem c = new Homem();

            Console.WriteLine("Humano");
            a.Olhos();
            a.Cabelos();

            Console.WriteLine("\nPessoa");
            b.Olhos();
            b.Cabelos();

            Console.WriteLine("\nHomem");
            c.Olhos();
            c.Cabelos();

        }
    }
}
