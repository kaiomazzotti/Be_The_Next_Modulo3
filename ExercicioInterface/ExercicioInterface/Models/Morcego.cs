using ExercicioInterface.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioInterface.Models
{
    internal class Morcego : Mamifero, IVoar
    {
        public Morcego(string nome, char sexo, int idade, bool carnivoro, bool peconhento, string corCabelos, int qtdeDeMamas, bool pelos, int altitudeMaximaEmMetros, double velocidadeVoo) : base(nome, sexo, idade, carnivoro, peconhento, corCabelos, qtdeDeMamas, pelos)
        {
            AltitudeMaximaEmMetros = altitudeMaximaEmMetros;
            VelocidadeDeVoo = velocidadeVoo;
        }

        public int AltitudeMaximaEmMetros { get; set; }
        public double VelocidadeDeVoo { get ; set ; }

        public void Voar()
        {
            Console.WriteLine($"Altura máxima alcançada: {AltitudeMaximaEmMetros} metros") ;
            Console.WriteLine($"Velocidade média de vôo: {VelocidadeDeVoo} ");
        }
        public override void Alimentar()
        {
            Console.WriteLine($"O Morcego se alimenta de frutos , néctar e pólen das flores , de insetos , de pequenos vertebrados e sangue ");
        }
        public override void Comunicar()
        {
            Console.WriteLine("O morcego emite sons de ecolocalização através de seus focinhos grandes e intrincadamente dobrados");
        }
        public override void Movimentar()
        {
            Console.WriteLine("O morcego Voa");
            Voar();
        }
    }
}
