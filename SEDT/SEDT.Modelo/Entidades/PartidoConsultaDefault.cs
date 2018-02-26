using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDT.Modelo.Entidades
{
    public class PartidoConsultaDefault
    {
        public DateTime FechaPartido { get; set; }
        public string Resultado { get; set; }
        public string EquipoPropio { get; set; }
        public string EquipoRival { get; set; }
        public string NombreTorneo { get; set; }
    }
}
