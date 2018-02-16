using SEDT.Modelo.DAO;
using SEDT.Modelo.Entidades;
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
            int idUsuario = Convert.ToInt32(lista[0].IdUsuario.ToString());
            ActualizarDAO.ActualizarUltimaConexion(idUsuario);
            return lista;
        }

        public static PersonaFisicaJugador JugadorPorID(int idJugador)
        {
            PersonaFisicaJugador jugador = ConsultarDAO.ConsultarJugadorPorID(idJugador);
            return jugador;
        }

        public static List<Modelo.Entidades.EquipoUsuario> ConsultarEquiposUsuario(Modelo.Entidades.EquipoUsuario equipo)
        {
            List<Modelo.Entidades.EquipoUsuario> lista = new List<Modelo.Entidades.EquipoUsuario>();
            lista = ConsultarDAO.ConsultarEquiposUsuario(equipo);
            return lista;
        }


        //TODO!!
        public static List<Modelo.Entidades.PersonaFisicaJugador> ConsultarJugadores(Modelo.Entidades.PersonaFisicaJugador jugador)
        {
            List<Modelo.Entidades.PersonaFisicaJugador> lista = new List<Modelo.Entidades.PersonaFisicaJugador>();
            int ID = ConsultarDAO.BuscarJugador();
            lista.Add(new Modelo.Entidades.PersonaFisicaJugador { IdPersonaFisicaJugador = ID });
            return lista;
        }
    }
}
