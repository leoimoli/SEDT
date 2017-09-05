using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDT.Modelo.Entidades
{
    public class EquipoUsuario
    {
        public int IdEquipoUsuario { get; set; }
        public int IdUsuario { get; set; }
        public string NombreEquipo { get; set; }
        public string ImagenEscudo { get; set; }
        public string Siglas { get; set; }
        public string SitioWeb { get; set; }
        public string TelefonoDeContacto { get; set; }
        public byte[] Imagen { get; set; }
    }
}
