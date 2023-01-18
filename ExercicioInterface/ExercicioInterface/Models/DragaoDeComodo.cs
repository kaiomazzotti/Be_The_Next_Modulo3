using ExercicioInterface.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioInterface.Models
{
    internal class DragaoDeComodo : Reptil, IOviparo
    {
        public DragaoDeComodo(string nome, char sexo, int idade, bool carnivoro, bool peconhento, bool temEscamas, bool temCasco) : base(nome, sexo, idade, carnivoro, peconhento, temEscamas, temCasco)
        {
        }

        public void Botar()
        {
            throw new NotImplementedException();
        }

        public void Chocar()
        {
            throw new NotImplementedException();
        }
    }
}
