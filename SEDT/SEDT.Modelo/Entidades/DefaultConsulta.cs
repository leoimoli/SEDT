using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDT.Modelo.Entidades
{
    public class DefaultConsulta
    {
        public int idUsuario { get; set; }
        public PlanDePago plan { get; set; }
        public List<EquipoUsuario> EquiposUsuario { get; set; }
        public int CantidadCompetencias { get; set; }
        public List<PartidoConsultaDefault> PartidosUsuario { get; set; }
        public int CantidadPartidos { get; set; }
        public List<JugadoresConsultaDefault> JugadoresUsuario { get; set; }
        public int CantidadJugadores { get; set; }
        public int CantidadEquipos { get; set; }

    }
}
