using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDT.Modelo.Entidades
{
    public class FichaTecnicaJugador
    {
        public int IdFichaTecnicaJugador { get; set; }
        public int IdPersonaFisicaJugador { get; set; }
        public string PosicionDeCampo { get; set; }
        public string PiernaHabil { get; set; }
        public string NivelPiernaHabil { get; set; }
        public string PiernaInhabil { get; set; }
        public string NivelPiernaInhabil { get; set; }
        public string JuegoAereo { get; set; }
        public string NivelDefensivo { get; set; }
        public string NivelOfensivo { get; set; }
        public string Velocidad { get; set; }
        public string PredisposiciónEntrenamiento { get; set; }
        public string TecnicaIndividual { get; set; }
        public string DisciplinaTactica { get; set; }
    }
}
