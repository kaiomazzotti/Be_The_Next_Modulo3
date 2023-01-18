using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioInterface.Models
{
    public class Reptil : Animal
    {
        public bool TemEscamas { get; set; }
        public bool TemCasco { get; set; }
        public Reptil(string nome, char sexo, int idade, bool carnivoro, bool peconhento, bool temEscamas, bool temCasco) : base(nome, sexo, idade, carnivoro, peconhento)
        {
            TemEscamas = temEscamas;
            TemCasco = temCasco;
        }

        public override void Alimentar()
        {
            throw new NotImplementedException();
        }

        public override void Comunicar()
        {
            throw new NotImplementedException();
        }

        public override void Movimentar()
        {
            throw new NotImplementedException();
        }
        public override void Apresentar()
        {
            base.Apresentar();
            string escamas = "";
            string cascos = "";
            if (TemEscamas == true)
                escamas = "Tem escamas";
            else
                escamas = "Não tem escamas";
            if (TemCasco == true)
                cascos = "Tem casco";
            else
                cascos = "Não tem casco";
            Console.WriteLine($"{escamas}\n{cascos}");
        }
    }
}
