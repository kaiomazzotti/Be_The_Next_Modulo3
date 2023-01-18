using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioInterface.Models
{
    internal class Chacal : Mamifero
    {
        public Chacal(string nome, char sexo, int idade, bool carnivoro, bool peconhento, string corCabelos, int qtdeDeMamas, bool pelos) : base(nome, sexo, idade, carnivoro, peconhento, corCabelos, qtdeDeMamas, pelos)
        {
        }

        public override void Alimentar()
        {
            Console.WriteLine($"O chacal é onívoro");
        }
        public override void Comunicar()
        {
            Console.WriteLine("O chacal uiva");
        }
        public override void Movimentar()
        {
            Console.WriteLine("Se movimenta com as 4 patas, podendo correr bem rápido");
        }
    }
}
