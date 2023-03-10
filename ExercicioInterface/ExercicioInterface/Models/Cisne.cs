using ExercicioInterface.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioInterface.Models
{
    internal class Cisne : Ave, IOviparo, IAquatico, IVoar
    {
        public Cisne(string nome, char sexo, int idade, bool carnivoro, bool peconhento, bool rapina, string corPena) : base(nome, sexo, idade, carnivoro, peconhento, rapina, corPena)
        {
        }

        bool IAquatico.ViveEmTerra { get; set ; }
        bool IAquatico.Mergulho { get; set ; }
        bool IAquatico.AguaDoce { get ; set ; }
        int IVoar.AltitudeMaximaEmMetros { get ; set  ; }
        double IVoar.VelocidadeDeVoo { get ; set ; }

        public void Botar()
        {
            throw new NotImplementedException();
        }

        public void Chocar()
        {
            throw new NotImplementedException();
        }

        void IVoar.Voar()
        {
            throw new NotImplementedException();
        }
    }
}
