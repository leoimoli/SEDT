using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDT.Modelo.Entidades
{
    public class Torneo
    {
        public int IdTorneo { get; set; }
        public string NombreTorneo { get; set; }
        public string Descripcion { get; set; }
        public int IdEquipoUsuario { get; set; }
        public string FormatoTorneo { get; set; }
        public int DuracionPartidos { get; set; }
    }
}
