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
        public static Respuesta AltaUsuario(Usuario usuario)
        {
            Respuesta respuesta = new Respuesta();
            respuesta.Exito = true;
            respuesta.Errores = new List<string>();
            if (string.IsNullOrEmpty(usuario.Dni))
            {
                respuesta.Errores.Add("El campo DNI es un dato obligatorio.");
                respuesta.Exito = false;
            }
            if (String.IsNullOrEmpty(usuario.Apellido))
            {
                respuesta.Errores.Add("El campo Apellido es un dato obligatorio.");
                respuesta.Exito = false;
            }
            if (String.IsNullOrEmpty(usuario.Nombre))
            {
                respuesta.Errores.Add("El campo Nombre es un dato obligatorio.");
                respuesta.Exito = false;
            }
            bool ValidarUsuarioExistente = ConsultarDAO.ValidarUsuarioExistente(usuario.Dni);
            if (ValidarUsuarioExistente == true)
            {
                respuesta.Errores.Add("Ya existe un usuario con el Nro.Documento ingresado.");
                respuesta.Exito = false;
            }
            return respuesta;
        }
        public static Respuesta AltaEquipoUsuario(EquipoUsuario equipo)
        {
            Respuesta respuesta = new Respuesta();
            respuesta.Exito = true;
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
            respuesta.Exito = true;
            if (jugador.IdUsuario <= 0)
            {
                respuesta.Errores.Add("Error al agregar un jugador. IdUsuario = 0");
                respuesta.Exito = false;
            }
            if (string.IsNullOrEmpty(jugador.Dni))
            {
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
            }
            ///// Si se ingreso un dni se valida por dni.
            if (!String.IsNullOrEmpty(jugador.Dni))
            {
                bool AltaPersonaFisicaJugadorExistente = true;
                AltaPersonaFisicaJugadorExistente = ConsultarDAO.AltaPersonaFisicaJugadorExistentePorDni(jugador.Dni, jugador.IdUsuario);
                //respuesta.Exito = AltaPersonaFisicaJugadorExistente;
                if (AltaPersonaFisicaJugadorExistente == true)
                {
                    respuesta.Errores.Add("Ya existe una persona física con los mismos datos para el usuario logueado y equipo seleccionado.");
                    respuesta.Exito = false;
                }
                ///// Si no se cargo un dni se Valida por Apellido,Nombre,Apodo.
                AltaPersonaFisicaJugadorExistente = ConsultarDAO.AltaPersonaFisicaJugadorExistente(jugador.Apellido, jugador.Nombre, jugador.Apodo, jugador.IdUsuario);
                //respuesta.Exito = AltaPersonaFisicaJugadorExistente;
                if (AltaPersonaFisicaJugadorExistente == true)
                {
                    respuesta.Errores.Add("Ya existe una persona física con los mismos datos para el usuario logueado y equipo seleccionado.");
                    respuesta.Exito = false;
                }
            }
            ///// Si no se cargo un dni se Valida por Apellido,Nombre,Apodo.
            else
            {
                bool AltaPersonaFisicaJugadorExistente = true;
                AltaPersonaFisicaJugadorExistente = ConsultarDAO.AltaPersonaFisicaJugadorExistente(jugador.Apellido, jugador.Nombre, jugador.Apodo, jugador.IdUsuario);
                //respuesta.Exito = AltaPersonaFisicaJugadorExistente;
                if (AltaPersonaFisicaJugadorExistente == true)
                {
                    respuesta.Errores.Add("Ya existe una persona física con los mismos datos para el usuario logueado y equipo seleccionado.");
                    respuesta.Exito = false;
                }
            }
            return respuesta;
        }
        public static Respuesta AltaEquipoRival(EquipoRival equipoRival)
        {
            Respuesta respuesta = new Respuesta();
            respuesta.Exito = true;
            respuesta.Errores = new List<string>();
            if (String.IsNullOrEmpty(equipoRival.NombreEquipo))
            {
                respuesta.Errores.Add("El nombre del equipo es dato obligatorio.");
                respuesta.Exito = false;
            }
            bool ValidarAltaEquipoRival = ConsultarDAO.ValidarAltaEquipoRival(equipoRival);
            if (ValidarAltaEquipoRival == true)
            {
                respuesta.Errores.Add("Ya existe un equipo rival con el mismo nombre ingresado.");
                respuesta.Exito = false;
            }
            return respuesta;
        }
        public static Respuesta AltaTorneo(Torneo torneo)
        {
            Respuesta respuesta = new Respuesta();
            respuesta.Errores = new List<string>();
            respuesta.Exito = true;
            if (String.IsNullOrEmpty(torneo.NombreTorneo))
            {
                respuesta.Errores.Add("El nombre del torneo es dato obligatorio.");
                respuesta.Exito = false;
            }
            bool ValidarAltaTorneoExistente = ConsultarDAO.BuscarTorneoExistente(torneo);
            if (ValidarAltaTorneoExistente == true)
            {
                respuesta.Errores.Add("Ya existe un torneo con el mismo nombre ingresado.");
                respuesta.Exito = false;
            }

            return respuesta;
        }
        public static Respuesta AltaEstadisticaPartido(EstadisticaPartido estadisticaPartido)
        {
            Respuesta respuesta = new Respuesta();
            respuesta.Errores = new List<string>();
            respuesta.Exito = true;
            return respuesta;
        }
        public static Respuesta AltaFichaTecnicaJugador(FichaTecnicaJugador ficha)
        {
            Respuesta respuesta = new Respuesta();
            if (ficha.IdJugador <= 0)
            {
                respuesta.Errores.Add("Error al agregar una ficha Técnica. IdJugador = 0");
                respuesta.Exito = false;
            }
            respuesta.Errores = new List<string>();

            return respuesta;
        }
        public static Respuesta AltaPartido(Partido partido)
        {
            Respuesta respuesta = new Respuesta();
            respuesta.Errores = new List<string>();
            if (partido.IdEquipoRival.ToString() == "SELECCIONE")
            {
                respuesta.Errores.Add("Debe seleccionar un equipo rival.");
                respuesta.Exito = false;
            }
            if (String.IsNullOrEmpty(partido.Marcador) || partido.Marcador.ToString() == "")
            {
                respuesta.Errores.Add("El campo marcador es obligatorio.");
                respuesta.Exito = false;
            }
            if (String.IsNullOrEmpty(partido.Resultado) || partido.Marcador.ToString() == "SELECCIONE")
            {
                respuesta.Errores.Add("El campo resultado es un dato obligatorio.");
                respuesta.Exito = false;
            }
            return respuesta;
        }
        public static Respuesta AltaJugadorCartera(JugadorCartera jugador)
        {
            Respuesta respuesta = new Respuesta();
            respuesta.Errores = new List<string>();
            respuesta.Exito = true;

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
            ///// Si no se cargo un dni se Valida por Apellido,Nombre,Apodo.
            else
            {
                bool AltaPersonaFisicaJugadorExistente = true;
                AltaPersonaFisicaJugadorExistente = ConsultarDAO.AltaPersonaFisicaJugadorExistente(jugador.Apellido, jugador.Nombre, jugador.Apodo, jugador.idUsuario);
                //respuesta.Exito = AltaPersonaFisicaJugadorExistente;
                if (AltaPersonaFisicaJugadorExistente == true)
                {
                    respuesta.Errores.Add("Ya existe una persona física con los mismos datos para el usuario logueado y equipo seleccionado.");
                    respuesta.Exito = false;
                }
            }
            return respuesta;
        }
        public static Respuesta AltaFichaTecnicaJugadorCartera(FichaTecnicaJugadorDeCartera ficha)
        {
            Respuesta respuesta = new Respuesta();
            respuesta.Errores = new List<string>();
            respuesta.Exito = true;
            if (ficha.IdJugador <= 0)
            {
                respuesta.Errores.Add("Error al agregar una ficha Técnica. IdJugador = 0");
                respuesta.Exito = false;
            }
            return respuesta;
        }
    }
}
