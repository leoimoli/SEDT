using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDT.Modelo.Entidades
{
    public class JugadorCartera
    {
        public int IdJugadorCartera { get; set; }
        public int idUsuario { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Apodo { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string RedSocial { get; set; }
        public string EquipoObservado { get; set; }
        public string EquipoRival { get; set; }
        public DateTime FechaPartido { get; set; }
    }
}
