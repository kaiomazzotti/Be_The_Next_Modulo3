using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioInterface.Interface
{
    public interface IVoar
    {
        int AltitudeMaximaEmMetros { get; set; }
        double VelocidadeDeVoo { get; set; }        
        void Voar();

    }
}
