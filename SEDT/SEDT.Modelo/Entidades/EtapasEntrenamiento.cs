using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDT.Modelo.Entidades
{
    public class EtapasEntrenamiento
    {
        public int IdEtapaEntrenamiento { get; set; }
        public string MaterialesDeTrabajo { get; set; }
        public string Descripcion { get; set; }
        public int IdTurno { get; set; }
    }
}
