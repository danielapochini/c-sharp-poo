using System;

namespace POO_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c = new Carro();
            Bicicleta b = new Bicicleta();
            //Veiculo v = new Veiculo(); não é possível instanciar objetos

            c.Acelerar();
            b.Acelerar();

            c.Parar();
            b.Parar();
        }
    }
}
