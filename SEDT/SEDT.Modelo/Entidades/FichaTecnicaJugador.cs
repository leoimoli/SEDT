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
        public int IdUsuario { get; set; }
        public string PosicionDeCampo { get; set; }
        public string PiernaHabil { get; set; }
        public string Altura { get; set; }
        public string Peso { get; set; }

        ///// Cualidades Fisicas
        public string Salto { get; set; }
        public string Velocidad { get; set; }
        public string Resistencia { get; set; }
        public string Fuerza { get; set; }

        ///// Cualidades Tecnicas
        public string ControlDeBalon { get; set; }
        public string Regates { get; set; }
        public string Definicion { get; set; }
        public string Marcaje { get; set; }
        public string PaseCorto { get; set; }
        public string PaseLargo { get; set; }
        public string Remate { get; set; }
        public string TiroLibre { get; set; }


        ///// Cualidades tacticas
        public string DisciplinaTactica { get; set; }
        public string NivelDefensivo { get; set; }
        public string NivelOfensivo { get; set; }
    }
}
