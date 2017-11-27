using SEDT.Modelo.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDT.Controlador
{
    public static class Consultar
    {
        public static List<Modelo.Entidades.Usuario> LoginUsuario(Modelo.Entidades.Usuario usuario)
        {
            List<Modelo.Entidades.Usuario> lista = new List<Modelo.Entidades.Usuario>();
            lista = ConsultarDAO.LoginUsuario(usuario);
            return lista;
        }
        public static List<Modelo.Entidades.EquipoUsuario> ConsultarEquiposUsuario(Modelo.Entidades.EquipoUsuario equipo)
        {
            List<Modelo.Entidades.EquipoUsuario> lista = new List<Modelo.Entidades.EquipoUsuario>();
            lista = ConsultarDAO.ConsultarEquiposUsuario(equipo);
            return lista;
        }
    }
}
