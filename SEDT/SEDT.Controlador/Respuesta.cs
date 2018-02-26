using SEDT.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDT.Controlador
{
    public class Respuesta
    {
        public bool Exito { get; set; }
        public List<string> Errores { get; set; }
        public int Id { get; set; }
        public List<PersonaFisicaJugador> Resultado { get; set; }
        public List<PersonaFisicaJugadorConsultar> ResultadoConsultar { get; set; }
        public List<DefaultConsulta> ConsultaDefault { get; set; }
    }
}
