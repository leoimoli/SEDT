using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEDT.Modelo.Entidades;
using SEDT.Modelo.DAO;

namespace SEDT.Controlador
{
    public static class Validar
    {
        public static Respuesta AltaEquipoUsuario(EquipoUsuario equipo)
        {
            Respuesta respuesta = new Respuesta();
            respuesta.Errores = new List<string>();
            if (String.IsNullOrEmpty(equipo.NombreEquipo))
            {
                respuesta.Errores.Add("El nombre del equipo es dato obligatorio.");
                respuesta.Exito = false;
            }

            bool ValidarAltaEquipoUsuarioExistente = ConsultarDAO.ValidarAltaEquipoUsuarioExistente(equipo);
            if (ValidarAltaEquipoUsuarioExistente == true)
            {
                respuesta.Errores.Add("Ya existe para el usuario logueado un equipo con el mismo nombre ingresado.");
                respuesta.Exito = false;
            }
            return respuesta;
        }
        public static Respuesta AltaPersonaFisicaJugador(PersonaFisicaJugador jugador)
        {
            Respuesta respuesta = new Respuesta();
            respuesta.Errores = new List<string>();
            if (String.IsNullOrEmpty(jugador.Apellido))
            {
                respuesta.Errores.Add("El campo Apellido es un dato obligatorio.");
                respuesta.Exito = false;
            }
            if (String.IsNullOrEmpty(jugador.Nombre))
            {
                respuesta.Errores.Add("El campo Nombre es un dato obligatorio.");
                respuesta.Exito = false;
            }
            if (String.IsNullOrEmpty(jugador.Apodo))
            {
                respuesta.Errores.Add("El campo Apodo es un dato obligatorio.");
                respuesta.Exito = false;
            }
            ///// Si se ingreso un dni se valida por dni.
            if (!String.IsNullOrEmpty(jugador.Dni))
            {
                bool AltaPersonaFisicaJugadorExistente = ConsultarDAO.AltaPersonaFisicaJugadorExistentePorDni(jugador.Dni, jugador.idUsuario);
                if (AltaPersonaFisicaJugadorExistente == true)
                {
                    respuesta.Errores.Add("Ya existe una persona fisica con los mismos datos para el usuario logueado.");
                    respuesta.Exito = false;
                }
            }
            ///// Si no se cargo un dni se Valida por Apellido,Nombre,Apodo.
            else
            {
                bool AltaPersonaFisicaJugadorExistente = ConsultarDAO.AltaPersonaFisicaJugadorExistente(jugador.Apellido, jugador.Nombre, jugador.Apodo, jugador.idUsuario);
                if (AltaPersonaFisicaJugadorExistente == true)
                {
                    respuesta.Errores.Add("Ya existe una persona fisica con los mismos datos para el usuario logueado.");
                    respuesta.Exito = false;
                }
            }
            return respuesta;
        }
    }
}
