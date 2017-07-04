using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDT.Modelo.Entidades
{
   public class TurnoEntrenamiento
    {
        public int IdTurno { get; set; }
        public int IdEntrenamiento { get; set; }
        public DateTime Horario { get; set; }
        public string LugarEntrenamiento { get; set; }
        public int CantidadEtapas { get; set; }
    }
}

