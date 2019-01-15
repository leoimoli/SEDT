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

        public static JugadorCartera JugadorCarteraPorID(int idJugador)
        {
            JugadorCartera jugador = ConsultarDAO.ConsultarJugadorCarteraPorID(idJugador);
            return jugador;
        }

        public static DefaultConsulta ConsultaDefault(int idUsuario)
        {
            DefaultConsulta consulta = new DefaultConsulta();
            consulta = ConsultarDAO.ConsultaDefault(idUsuario);
            return consulta;
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

        public static List<Torneo> ConsultarTorneo(Torneo torneo)
        {
            List<Modelo.Entidades.Torneo> lista = new List<Modelo.Entidades.Torneo>();
            lista = ConsultarDAO.ConsultarTorneoPorUsuario(torneo);
            return lista;
        }

        //TODO!!
        public static List<PersonaFisicaJugadorConsultar> ConsultarJugadores(PersonaFisicaJugador jugador)
        {
            List<PersonaFisicaJugadorConsultar> lista = new List<PersonaFisicaJugadorConsultar>();
            lista = ConsultarDAO.BuscarJugadorPorFiltros(jugador);
            // int ID = ConsultarDAO.BuscarJugador();
            //lista.Add(new Modelo.Entidades.PersonaFisicaJugador { IdPersonaFisicaJugador = ID });
            return lista;
        }

        public static List<EquipoRival> ConsultarEquipoRivalPorEquipoSeleccionado(EquipoRival equipoRival)
        {
            List<Modelo.Entidades.EquipoRival> lista = new List<Modelo.Entidades.EquipoRival>();
            lista = ConsultarDAO.ConsultarEquipoRivalPorEquipoSeleccionado(equipoRival);
            return lista;
        }
    }
}
