using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDT.Modelo.Entidades
{
    public class JugadoresConsultaDefault
    {
        public int IdPersonaFisicaJugador { get; set; }
        public int IdUsuario { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string NombreEquipo { get; set; }
        public string Posicion { get; set; }
        public string Imagen { get; set; }

    }
}
