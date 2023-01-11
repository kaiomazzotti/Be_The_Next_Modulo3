using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioRevisãoPOO.Models
{
    internal class Aluno : Pessoa
    {
        public Aluno(string nome, int idade) : base(nome, idade)
        {
        }
        public void IrParaEscola()
        {
            Console.WriteLine($"O aluno {Nome} está indo para escola");
        }
    }
}
