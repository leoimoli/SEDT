using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDT.Modelo.Entidades
{
    public class Entrenamiento
    {
        public int IdEntrenamiento { get; set; }
        public DateTime FechaEntrenamiento { get; set; }
        public int CantidadTurnoEntrenamiento { get; set; }
        public int IdEquipo { get; set; }
    }
}
