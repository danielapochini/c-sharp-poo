﻿using System;

namespace POO_Modificadores
{
    class Program
    {
        static void Main(string[] args)
        {
            Teste t = new Teste();
            //t.nome = "";
            t.sobrenome = "";
            // t.Metodo1();
            t.Executar();

            Homem h = new Homem();
            h.idade = 18;

        }
    }
}
