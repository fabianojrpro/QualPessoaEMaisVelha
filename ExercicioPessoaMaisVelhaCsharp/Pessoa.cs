using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPessoaMaisVelhaCsharp
{
    internal class Pessoa
    {
        public string nome { get; private set; }
        public int idade { get; private set; }

        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        public void MaisVelha(Pessoa um, Pessoa dois)
        {
            if (um.idade > dois.idade)
            {
                Console.WriteLine("Pessoa mais velha: " + um.nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + dois.nome);
            }
        }
    }
}
