﻿using SEDT.Modelo.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDT.Controlador
{
    public static class Agregar
    {
        public static Respuesta AltaEquipoUsuario(Modelo.Entidades.EquipoUsuario equipo)
        {
            Respuesta respuesta = new Respuesta();
            respuesta.Errores = new List<string>();
            try
            {
                respuesta = Validar.AltaEquipoUsuario(equipo);
                if (respuesta.Exito == true)
                {
                    respuesta.Id = GuardarDAO.AltaEquipoUsuario(equipo);
                }
            }
            catch (Exception ex)
            {
                respuesta.Exito = false;
                respuesta.Errores.Add(ex.Message);
            }
            return respuesta;
        }
        public static Respuesta AltaPersonaFisicaJugador(Modelo.Entidades.PersonaFisicaJugador jugador)
        {
            Respuesta respuesta = new Respuesta();
            respuesta.Errores = new List<string>();
            try
            {
                respuesta = Validar.AltaPersonaFisicaJugador(jugador);
                if (respuesta.Exito == true)
                {
                    respuesta.Id = GuardarDAO.AltaPersonaFisicaJugador(jugador);
                }
            }
            catch (Exception ex)
            {
                respuesta.Exito = false;
                respuesta.Errores.Add(ex.Message);
            }
            return respuesta;
        }
        public static Respuesta AltaFichaTecnicaJugador(Modelo.Entidades.FichaTecnicaJugador ficha)
        {
            Respuesta respuesta = new Respuesta();
            respuesta.Errores = new List<string>();
            try
            {
                respuesta = Validar.AltaFichaTecnicaJugador(ficha);
                if (respuesta.Exito == true)
                {
                    respuesta.Id = GuardarDAO.AltaFichaTecnicaJugador(ficha);
                }
            }
            catch (Exception ex)
            {
                respuesta.Exito = false;
                respuesta.Errores.Add(ex.Message);
            }
            return respuesta;
        }
        public static Respuesta AltaEquipoRival(Modelo.Entidades.EquipoRival equipoRival)
        {
            Respuesta respuesta = new Respuesta();
            respuesta.Errores = new List<string>();
            try
            {
                respuesta = Validar.AltaEquipoRival(equipoRival);
                if (respuesta.Exito == true)
                {
                    respuesta.Id = GuardarDAO.AltaEquipoRival(equipoRival);
                }
            }
            catch (Exception ex)
            {
                respuesta.Exito = false;
                respuesta.Errores.Add(ex.Message);
            }
            return respuesta;
        }
        public static Respuesta AltaTorneo(Modelo.Entidades.Torneo torneo)
        {
            Respuesta respuesta = new Respuesta();
            respuesta.Errores = new List<string>();
            try
            {
                respuesta = Validar.AltaTorneo(torneo);
                if (respuesta.Exito == true)
                {
                    respuesta.Id = GuardarDAO.AltaTorneo(torneo);
                }
            }
            catch (Exception ex)
            {
                respuesta.Exito = false;
                respuesta.Errores.Add(ex.Message);
            }
            return respuesta;
        }
    }
}
