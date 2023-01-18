using ExercicioInterface.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioInterface.Models
{
    internal class Ornitorrinco : Mamifero, IOviparo, IAquatico
    {
        public Ornitorrinco(string nome, char sexo, int idade, bool carnivoro, bool peconhento, string corCabelos, int qtdeDeMamas, bool pelo) : base(nome, sexo, idade, carnivoro, peconhento, corCabelos, qtdeDeMamas, pelo)
        {
        }

        public bool ViveEmTerra { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Mergulho { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool AguaDoce { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
