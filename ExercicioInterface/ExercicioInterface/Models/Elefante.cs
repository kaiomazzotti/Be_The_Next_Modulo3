using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioInterface.Models
{
    internal class Elefante : Mamifero
    {
        public Elefante(string nome, char sexo, int idade, bool carnivoro, bool peconhento, string corCabelos, int qtdeDeMamas, bool pelo) : base(nome, sexo, idade, carnivoro, peconhento, corCabelos, qtdeDeMamas, pelo)
        {
        }
    }
}
