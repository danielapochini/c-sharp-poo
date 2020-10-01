using Microsoft.VisualBasic.CompilerServices;
using System;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Operadores matematicos
            /*          
            int num1 = 15;
            int num2 = 2;
            //int resultado = num1 + num2;
            Console.WriteLine(num1 + num2);
            Console.WriteLine(num1 - num2);
            Console.WriteLine(num1 * num2);
            Console.WriteLine(num1 / num2);
            Console.WriteLine(num1 % num2);
            Console.ReadKey();
            */
            #endregion

            #region Precedência operadores aritméticos
            /*          
           double num1 = 100;
            double num2 = 10;
            double num3 = 5;

            double res = (num1 + num2) * (num3 / 2);

            Console.WriteLine(res);
            Console.ReadKey();
            */
            #endregion

            #region Operadores de incremento/decremento
            /*
            int num1 = 10;
            //num = num1 + 1;
            //num1++;

            num1--;
            // ++num1: pre incremento/decremento - primeiro a variavel é acrescida e é exibido 11 na tela
            // num1++: pos incremento/decremento - primeiro é realizado o processo 
            // (no caso, imprimir o valor na tela), é exibido 10 e depois a variavel é acrescida

            Console.WriteLine(num1);
            Console.ReadKey();
            */
            #endregion

            #region Operador de concatenação

            /*            
            string nome = "Daniela";
            string sobrenome = "Pochini";
            string nomeCompleto = nome + " " + sobrenome + " " + 1993;

            Console.WriteLine(nomeCompleto);
            Console.ReadKey();
            */

            #endregion

            #region Operador de atribuição
            /*
            int num1 = 10;

            // num1 = num1 + 20;  
            //num1 += 20;
            //num1 vai receber seu proprio valor + 20 e o resultado será 30.

            //num1 -= 2;
            //num1 vai receber seu proprio valor - 2  e o resultado será 8.

            //num1 *= 3;
            //num1 vai receber seu proprio valor vezes 3  e o resultado será 30.

            //num1 /= 2;
            //num1 vai receber seu proprio valor dividido por 2  e o resultado será 5.

            //num1 %= 2;
            //num1 vai receber seu proprio valor e o resto da divisão por 2 e o resultado será 0.

            string nome = "Daniela ";
            nome += "Pochini";
            //não sobescreve o valor na variavel, concatena junto com a outra variavel do tipo string 
            Console.WriteLine(nome);
            Console.ReadKey();

            */
            #endregion

            #region Operador de igualdade / comparação
            /*
            bool res0 = 100 == 50; //100 é igual a 50? retorna false
            bool res1 = 100 == (50 * 2); //100 é igual a 50? retorna true

            bool res2 = 200 != (100 + 100); //200 é diferente de 200? retorna false
            bool res3 = (200 / 2) != (100 + 100); //100 é diferente de 200? retorna true

            string nome = "Daniela";
            bool res4 = nome == "Daniela"; //os valores são iguais? retorna true
            bool res4 = nome == "Teste"; //os valores são iguais? retorna false

            bool res4 = nome != "Daniela"; //os valores são diferentes? retorna false
            bool res4 = nome != "Teste"; //os valores são diferentes? retorna true

            Console.WriteLine();
            Console.ReadKey();
             */
            #endregion

            #region Operadores relacionais
            /*
            bool res0 = 100 < 50 + 65; // true
            bool res1 = 100 > 50 * 2;  // false
            bool res2 = 100 + 25 <= 50 * 2;  // false
            bool res3 = 100 >= 50 * 2;  // true
            bool res4 = 75 >= 50 * 2;  // false
            */
            #endregion

            #region Operadores lógicos
            /*
            bool res1 = 100 > 50;
            bool res2 = 50 == 50;

            bool final1 = res1 && res2; // && - AND
            bool final2 = res1 || res2; // || - OR


            Console.WriteLine(final2);
            Console.ReadKey();
            */

            #endregion

        }
    }
}
