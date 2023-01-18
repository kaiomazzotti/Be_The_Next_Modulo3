using ExercicioInterface.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioInterface.Models
{
    internal class Mamifero : Animal
    {
        public int  QtdeDeMamas { get; set; }
        public bool Pelos { get; set; }
        public string CorCabelos { get; set; }
        public Mamifero(string nome, char sexo, int idade, bool carnivoro, bool peconhento, string corCabelos, int qtdeDeMamas , bool pelo) : base(nome, sexo, idade, carnivoro, peconhento)
        {
            CorCabelos = corCabelos;
            QtdeDeMamas = qtdeDeMamas;
            Pelos = pelo;
        }
        public void Amamentar()
        {
            Console.WriteLine("O animal {0} alimenta seus bebês amamentando", Nome);
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
            string pelos = "";
            if (Pelos == true)
                pelos = "Tem pêlos";
            else
                pelos = "Não tem pêlos";
            Console.WriteLine($"{pelos}\nCor dos cabelos: {CorCabelos}\nQuantidade de mamas: {QtdeDeMamas}");
        }

    }
}
