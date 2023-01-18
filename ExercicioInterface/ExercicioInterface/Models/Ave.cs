using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioInterface.Models
{
    public class Ave : Animal
    {
        public bool Rapina { get; set; }
        public string CorPena { get; set; }
        public Ave(string nome, char sexo, int idade, bool carnivoro, bool peconhento, bool rapina, string corPena) : base(nome, sexo, idade, carnivoro, peconhento)
        {
            Rapina = rapina;
            CorPena = corPena;
        }
        public void Ciscar()
        {
            Console.WriteLine("O animal " + Nome + "está ciscando!");
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
            string rapina = "";
            if (Rapina == true)
                rapina = "É rapina";
            else
                rapina = "Não é Rapina";
            Console.WriteLine($"{rapina}\nCor da Pena: {CorPena}");
            Ciscar();
        }
    }
}
