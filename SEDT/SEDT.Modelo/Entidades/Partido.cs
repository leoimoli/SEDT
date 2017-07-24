using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDT.Modelo.Entidades
{
    public class Partido
    {
        public int idPartido { get; set; }
        public DateTime FechaPartido { get; set; }
        public int IdEquipoRival { get; set; }
        public string Marcador { get; set; }
        public int MarcadorA { get; set; }
        public int MarcadorB { get; set; }
        public string Resultado { get; set; }
        public int IdTorneo { get; set; }
    }
}
