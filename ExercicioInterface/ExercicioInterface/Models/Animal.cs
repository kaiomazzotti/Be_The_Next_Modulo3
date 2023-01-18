using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioInterface.Models
{
    public abstract class Animal
    {
        public Animal(string nome, char sexo, int idade, bool carnivoro, bool peconhento)
        {
            Nome = nome;
            Sexo = sexo;
            Idade = idade;
            Carnivoro = carnivoro;
            Peconhento = peconhento;
        }

        public string Nome { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public char Sexo { get; set; }
        public int Idade { get; set; }
        public bool Carnivoro { get; set; }
        public bool Peconhento { get; set; }
        public abstract void Movimentar();
        public abstract void Comunicar();
        public abstract void Alimentar();
        public virtual void Apresentar()
        {
            string carnivoro = "";
            string peconhento = "";
            if (Carnivoro == true)
                carnivoro = "Come carne";
            else
                carnivoro = "Não come carne";
            if (Peconhento == true)
                peconhento = "É peçonhento";
            else
                peconhento = "Não é peçonhento";
            Console.WriteLine($"Animal: {Nome}\nSexo: ({Sexo})\nIdade: {Idade} anos\n{carnivoro}\n{peconhento}");
            Movimentar();
            Alimentar();
            Comunicar();

        }
    }
}
