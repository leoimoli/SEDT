using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDT.Modelo.Entidades
{
   public class HistorialEtapa
    {
        public int IdHistorial { get; set; }
        public int IdEtapaEntrenamiento { get; set; }
        public int idEquipoJugador { get; set; }
    }
}
