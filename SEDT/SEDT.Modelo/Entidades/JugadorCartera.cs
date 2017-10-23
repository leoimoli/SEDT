using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDT.Modelo.Entidades
{
   public class JugadorCartera
    {
        public int IdPersonaFisicaJugador { get; set; }
        public int idUsuario { get; set; }
        public string Dni { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Apodo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Altura { get; set; }
        public string Peso { get; set; }
        public byte[] Imagen { get; set; }
    }
}
