using System;

namespace POO_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Forma a = new Forma();
            Forma b = new Triangulo(); // Triangulo é uma forma, segundo o polimorfismo
            Forma c = new Circulo();
            Forma d = new Retangulo();

            //Console.WriteLine("Forma");
            //a.Desenhar();
            Console.WriteLine("Triangulo");
            b.Desenhar();
            Console.WriteLine("Circulo");
            c.Desenhar();
            Console.WriteLine("Retangulo");
            d.Desenhar();
        }
    }
}
