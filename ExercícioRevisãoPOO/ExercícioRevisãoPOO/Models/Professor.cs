using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioRevisãoPOO.Models
{
    internal class Professor : Pessoa
    {
        public Professor(string nome, int idade) : base(nome, idade)
        {
        }

        public void Explicar(string assunto)
        {
            Console.WriteLine($"O professor {Nome} vai explicar sobre {assunto}");
        }
    }
}
