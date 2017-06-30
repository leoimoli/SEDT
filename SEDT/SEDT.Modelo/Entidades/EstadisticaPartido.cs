using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDT.Modelo.Entidades
{
    public class EstadisticaPartido
    {
        public int IdEstadisticaPartido { get; set; }
        public int CornersPropio { get; set; }
        public int CornersRival { get; set; }
        public int FaltasRecibidas { get; set; }
        public int FaltasCometidas { get; set; }
        public int PenalesRecibidos { get; set; }
        public int PenalesCometidos { get; set; }
        public int OffsidePropio { get; set; }
        public int OffsideRival { get; set; }
        public int PosesionPropia { get; set; }
        public int PosesioRival { get; set; }
        public int TirosPropios { get; set; }
        public int TirosRivales { get; set; }
        public int TirosAlArcoPropios { get; set; }
        public int TirosAlArcoRivales { get; set; }
        public int CantidadPasesPropios { get; set; }
        public int CantidadPasesRivales { get; set; }
        public int idPartido { get; set; }
    }
}

