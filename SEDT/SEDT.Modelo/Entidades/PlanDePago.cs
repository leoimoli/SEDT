﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDT.Modelo.Entidades
{
    public class PlanDePago
    {
        public int IdPlanDePago { get; set; }
        public string NombreDePlan { get; set; }
        public int Dias { get; set; }
        public int CantidadEquipos { get; set; }
        public int CantidadJugadores { get; set; }
    }
}
