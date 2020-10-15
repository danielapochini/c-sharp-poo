using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Modificadores
{
    //modificadores de acesso servem para modificar a visibilidade, ou seja, o tipo de acesso que os membros daquela classe irão ter
    // public: está visivel para todos
    // private: o membro são privados na minha classe, só estão vísiveis dentro da propria classe. também não estarão visiveis para herança.
    // protected: semelhante ao private, mas é vísivel para quem herda. somente aos objetos instanciados a classe não podem ter acesso.
    // internal: o membro será visivel apenas dentro da aplicação/projeto
    class Teste
    {
        private string nome;
        public string sobrenome;
        
        private void Metodo1() { }
        public void Executar() { }
    }

    class Humano
    {
        protected string nome;
        private string sobrenome;
        internal int idade;
    }

    class Homem : Humano
    {
        public void Metodo()
        {
            nome = "";
            idade = 0;
        }
    }
}
