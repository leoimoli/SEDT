﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDT.Modelo.Entidades
{
    public class EstadisticaJugadorTotal
    {
        public int IdEstadisticaJugadorTotal { get; set; }
        public int IdEquipoJugador { get; set; }
        public string PartidosJugados { get; set; }
        public string Goles { get; set; }
        public string Amarillas { get; set; }
        public string Rojas { get; set; }
        public string AsistenciaEntrenamiento { get; set; }
        public string TirosAlArco { get; set; }
        public string TirosDesviados { get; set; }
        public string FaltasCometidas { get; set; }
        public string FaltasRecibidas { get; set; }
    }
}
