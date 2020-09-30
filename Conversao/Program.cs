using System;

namespace Conversao
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Conversão Implicita
            /*
            byte num1 = 100; // 8 bits, de 0 a 255
            ushort num2; // 16 bit, de 0 a 65.535

            num2 = num1;
            /conversão implicita:
            // o compilador entende que todos os valores do tipo byte vai caber na tipo short, não faltará espaço, nem abrangência.

            float num3 = 1250.45f;
            double num4 = num3;

            num3 = num1;
            num2 = num1;

            // num1 = num2 apresentaria erro pois não o tipo byte não comporta o tipo ushort
             
            int numero = 'C';
            // sera imprimido o valor do código numero (67) e não o caractere (C)
            */
            #endregion

            #region Conversão Explícita
            /*            
            //conversão explicita é necessário forçar a conversão colocando na frente do valor convertido entre parenteses 
            // o valor no qual ele será convertido, pode ocorrer a perda de dados.
            ushort num1 = 100;
            byte num2 = (byte)num1;

            float num3 = 2500.786f;
            int num4 = (int)num3; //imprime apenas os numeros inteiros (2500)

            char letra = (char)97; //converte para o caractere correspondente (a)
            */
            #endregion

            #region Metodo Parse
            /*
            // transforma uma cadeia de caracteres (String) que represente  a um valor numérico, no numero equivalente

            string txtNumero = "1985";
            int numero = int.Parse(txtNumero);

            byte num1 = byte.Parse("120");

            double num2 = double.Parse("125623,57"); //nas casas decimais são usadas , e não .

            float num3 = float.Parse("457,75")
            */
            #endregion

            #region Classe Convert
            /*
            String texto = Convert.ToString(2500); //retorna 2500
            String texto2 = Convert.ToString(false); //retorna False 
            double num1 = Convert.ToDouble(false); //retorna 0
            int num2 = Convert.ToInt32('C'); //retorna 67
            */
            #endregion

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
