using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDT.Modelo.Entidades
{
    public class HistorialDePago
    {
        public int IdHistorialDePago { get; set; }
        public int IdPlanDePago { get; set; }
        public int IdUsuario { get; set; }
        public string Comprobante { get; set; }
        public DateTime FechaDePago { get; set; }
        public double MontoDePago { get; set; }
        public DateTime FechaVencimiento { get; set; }
    }
}
