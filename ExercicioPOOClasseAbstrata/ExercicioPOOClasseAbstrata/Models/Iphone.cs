using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOOClasseAbstrata.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }


        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo ({nomeApp}) no {Modelo}");
            Console.WriteLine("\n||||\n\n||||||||\n\n||||||||||||| 100% CONCLÚIDO\n\nAplicativo {0} instalado.",nomeApp);
        }
    }
}