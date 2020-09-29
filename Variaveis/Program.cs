using System;

namespace Variaveis
{
    class Program
    {

        // uma enumeração precisa ser declarada na raiz da classe, fora do método main
        // não precisa colocar ; ao final é separado por ,
        // são nomes definidos, não precisam estar entre ""
        // precisam ser numeros inteiros
        enum Notas {
            Minimo = 10,
            Media = 20, 
            Maxima = 30
        }

        // definir tipos de dados personalizados
        // sem o public não é vísivel para acesso
        struct Pessoa
        {
            public string nome;
            public int idade;
            public double altura;
        }

        static void Main(string[] args)
        {
            #region Numericas Integrais
            //// Integral assinado
            //sbyte num1 = 10; // 8 bits, de -128 a 127
            //short num2 = 20; // 16 bits, –32.768 a 32.767
            //int num3 = 30; // 32 bits, –2.147.483.648 a 2.147.483.647
            //long num4 = 40L; // 64 bits, –9.223.372.036.854.775.808 a 9.223.372.036.854.775.807

            //// Integral sem sinal
            //byte num5 = 10; // 8 bits, intervalo de 0 a 255
            //ushort num6 = 20; // 16 bits, de 0 a 65.535
            //uint num7 = 30;  // 32 bits, de 0 a 4.294.967.295
            //ulong num8 = 40L; // 64 bits, de 0 a 18.446.744.073.709.551.615

            //sbyte numero;
            //numero = 100;

            //numero = 120;
            //numero = num1;
            #endregion

            #region Números Reais
            //float real1 = 100.75f; // 32 bits, de 1,5 × 10-45 a 3,4 × 1038, precisão de 7 dígitos => Sufixo f, Ex.: 10.5f
            //double real2 = 12500.45; // 64 bits, de 5,0 × 10-324 a 1,7 × 10308, precisão de 15 dígitos => Sufixo d (opcional), Ex.: 10.5d
            //decimal real3 = 752538.457m; // 128 bits, intervalo de pelos menos –7,9 × 10-28 a 7,9 × 1028, com precisão de pelo menos 28 dígitos => Sufixo m, Ex.: 10.5m

            //double valor;
            //valor = real1;
            #endregion

            #region Caractere
            //char letra = '\u0041';
            //char escape = '\n';
            //char literal = 'C';
            #endregion

            #region Boolean
            //bool verificar = false;
            //verificar = true;
            #endregion

            #region String (Cadeia de Caracteres)
            //iniciar a string com @ ignora os caracteres especiais, ex:
            //string texto = @"Daniela Pochini\n 1993 @@??$$";

            //string texto = "Daniela Pochini\n 1993 @@??$$";
            //string mensagem = null;
            //mensagem = texto;
            #endregion

            #region Tipo Implícito Var
            //var valor = 100; -- assume qualquer tipo de valor  
            //valor = 20; -- a partir do momento que recebe o valor numérico, será este tipo até o final
            //valor = "Daniela"; -- este não é aceito
            #endregion

            #region Tipo Object (Base para todos os tipos)
            // é uma variavel da qual todas as outras variaveis herdam, pode ser atribuido qualquer valor   
            // é a base de todos os tipos e comporta todos os tipos a qualquer momento que for atribuido
            //object obj = false;
            //obj = 200; -- não dá erro
            //obj = "Daniela"; -- este também não
            #endregion

            #region Constantes
            // precisa ter um valor inicial atribuido ao ser declarada
            // este valor não poderá será alterado até o final
            //const double pi = 3.1415;
            //const string nome = "Daniela";
            #endregion

            #region Enumeração
            //Notas notasAlunos = Notas.Media;
            #endregion

            Pessoa p1 = new Pessoa(); //inicializando uma estrutura
            p1.altura = 1.75;
            p1.idade = 26;
            p1.nome = "Daniela";

            Pessoa p2 = new Pessoa()
            {
                altura = 1.65,
                idade = 25,
                nome = "Pessoa"
            };

            p2.nome = "Teste";

            Console.WriteLine(p1.nome);
            Console.WriteLine(p1.idade);
            Console.WriteLine(p1.altura);

            Console.WriteLine();

            Console.WriteLine(p2.nome);
            Console.WriteLine(p2.idade);
            Console.WriteLine(p2.altura);
            Console.ReadKey();
        }
    }
}
