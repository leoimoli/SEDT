using SEDT.Modelo.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEDT.Modelo.Entidades;

namespace SEDT.Controlador
{
    public static class Agregar
    {
        public static Respuesta AltaUsuario(Modelo.Entidades.Usuario usuario)
        {
            Respuesta respuesta = new Respuesta();
            respuesta.Exito = true;
            respuesta.Errores = new List<string>();
            try
            {
                respuesta = Validar.AltaUsuario(usuario);
                if (respuesta.Exito == true)
                {
                    respuesta.Id = GuardarDAO.AltaUsuario(usuario);
                }
            }
            catch (Exception ex)
            {
                respuesta.Exito = false;
                respuesta.Errores.Add(ex.Message);
            }
            return respuesta;
        }
        public static Respuesta AltaEquipoUsuario(Modelo.Entidades.EquipoUsuario equipo)
        {
            Respuesta respuesta = new Respuesta();
            respuesta.Exito = true;
            respuesta.Errores = new List<string>();
            try
            {
                PlanDePago _plan = new PlanDePago();
                _plan = ConsultarDAO.PlanDePagoUsuario(equipo.IdUsuario);
                respuesta = Validar.AltaEquipoUsuario(equipo, _plan);
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
            PlanDePago _plan = new PlanDePago();
            Respuesta respuesta = new Respuesta();
            respuesta.Exito = true;
            respuesta.Errores = new List<string>();
            try
            {
                _plan = ConsultarDAO.PlanDePagoUsuario(jugador.IdUsuario);
                respuesta = Validar.AltaPersonaFisicaJugador(jugador, _plan);
                if (respuesta.Exito == true)
                {
                    //Byte[] bitmapData = new Byte[jugador.Imagen.Length];
                    //bitmapData = Convert.FromBase64String(FixBase64ForImage(jugador.Imagen));
                    //jugador.Imagen = bitmapData;
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
            respuesta.Exito = true;
            respuesta.Errores = new List<string>();
            try
            {
                respuesta = Validar.AltaFichaTecnicaJugador(ficha);
                if (respuesta.Exito == true)
                {
                    respuesta.Id = GuardarDAO.AltaFichaTecnica(ficha);
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
            respuesta.Exito = true;
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

        //public static Respuesta DatosPartido(Partido partido)
        //{
        //    Respuesta respuesta = new Respuesta();
        //    respuesta.Exito = true;
        //    respuesta.Errores = new List<string>();
        //    try
        //    {
        //        string condicion = partido.Condicion;

        //        respuesta = Validar.AltaPartido(partido);
        //        if (respuesta.Exito == true)
        //        {
        //            //Byte[] bitmapData = new Byte[jugador.Imagen.Length];
        //            //bitmapData = Convert.FromBase64String(FixBase64ForImage(jugador.Imagen));
        //            //jugador.Imagen = bitmapData;
        //            respuesta.Id = GuardarDAO.AltaPartido(partido);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        respuesta.Exito = false;
        //        respuesta.Errores.Add(ex.Message);
        //    }
        //    return respuesta;
        //}

        public static Respuesta AltaTorneo(Modelo.Entidades.Torneo torneo)
        {
            Respuesta respuesta = new Respuesta();
            respuesta.Exito = true;
            respuesta.Errores = new List<string>();
            try
            {
                respuesta = Validar.AltaTorneo(torneo);
                if (respuesta.Exito)
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
        public static Respuesta AltaPartido(Modelo.Entidades.Partido partido)
        {
            Respuesta respuesta = new Respuesta();
            respuesta.Exito = true;
            respuesta.Errores = new List<string>();
            try
            {
                respuesta = Validar.AltaPartido(partido);
                if (respuesta.Exito == true)
                {
                    int resultadoA = Convert.ToInt32(partido.MarcadorLocal);
                    int resultadoB = Convert.ToInt32(partido.MarcadorVisitante);
                    partido.Marcador = partido.MarcadorLocal + "a" + partido.MarcadorVisitante;
                    string condicion = partido.Condicion;
                    if (condicion == "1") { condicion = "LOCAL"; } else { condicion = "VISITANTE"; }
                   
                    if (condicion == "LOCAL")
                    {
                        if (resultadoA > resultadoB)
                        {
                            partido.Resultado = "GANO";
                        }
                        else if (resultadoA < resultadoB)
                        {
                            partido.Resultado = "PERDIO";
                        }
                        else
                        {
                            partido.Resultado = "EMPATO";
                        }
                        partido.Condicion = condicion;
                        respuesta.Id = GuardarDAO.AltaPartido(partido);
                    }
                    else
                    {
                        if (resultadoA > resultadoB)
                        {
                            partido.Resultado = "PERDIO";
                        }
                        else if (resultadoA < resultadoB)
                        {
                            partido.Resultado = "GANO";
                        }
                        else
                        {
                            partido.Resultado = "EMPATO";
                        }
                        partido.Condicion = condicion;
                        respuesta.Id = GuardarDAO.AltaPartido(partido);
                    }
                }
            }
            catch (Exception ex)
            {
                respuesta.Exito = false;
                respuesta.Errores.Add(ex.Message);
            }
            return respuesta;
        }
        public static Respuesta AltaEstadisticaPartido(Modelo.Entidades.EstadisticaPartido estadisticaPartido)
        {
            Respuesta respuesta = new Respuesta();
            respuesta.Exito = true;
            respuesta.Errores = new List<string>();
            try
            {
                respuesta = Validar.AltaEstadisticaPartido(estadisticaPartido);
                if (respuesta.Exito == true)
                {
                    //respuesta.Id = GuardarDAO.AltaEstadisticaPartido(estadisticaPartido);
                }
            }
            catch (Exception ex)
            {
                respuesta.Exito = false;
                respuesta.Errores.Add(ex.Message);
            }
            return respuesta;
        }
        public static Respuesta AltaEntrenamiento(Modelo.Entidades.Entrenamiento entrenamiento)
        {
            Respuesta respuesta = new Respuesta();
            respuesta.Exito = true;
            respuesta.Errores = new List<string>();
            try
            {
                //respuesta = Validar.AltaEntrenamiento(entrenamiento);
                if (respuesta.Exito == true)
                {
                    respuesta.Id = GuardarDAO.AltaEntrenamiento(entrenamiento);
                }
            }
            catch (Exception ex)
            {
                respuesta.Exito = false;
                respuesta.Errores.Add(ex.Message);
            }
            return respuesta;
        }
        public static Respuesta AltaTurnoEntrenamiento(Modelo.Entidades.TurnoEntrenamiento turnoentrenamiento)
        {
            Respuesta respuesta = new Respuesta();
            respuesta.Exito = true;
            respuesta.Errores = new List<string>();
            try
            {
                //respuesta = Validar.AltaEntrenamiento(entrenamiento);
                if (respuesta.Exito == true)
                {
                    respuesta.Id = GuardarDAO.AltaTurnoEntrenamiento(turnoentrenamiento);
                }
            }
            catch (Exception ex)
            {
                respuesta.Exito = false;
                respuesta.Errores.Add(ex.Message);
            }
            return respuesta;
        }
        public static Respuesta AltaEtapasEntrenamiento(Modelo.Entidades.EtapasEntrenamiento etapasentrenamiento)
        {
            Respuesta respuesta = new Respuesta();
            respuesta.Exito = true;
            respuesta.Errores = new List<string>();
            try
            {
                //respuesta = Validar.AltaEntrenamiento(entrenamiento);
                if (respuesta.Exito == true)
                {
                    respuesta.Id = GuardarDAO.AltaEtapasEntrenamiento(etapasentrenamiento);
                }
            }
            catch (Exception ex)
            {
                respuesta.Exito = false;
                respuesta.Errores.Add(ex.Message);
            }
            return respuesta;
        }
        public static Respuesta AltaJugadorCartera(Modelo.Entidades.JugadorCartera jugador)
        {
            Respuesta respuesta = new Respuesta();
            respuesta.Exito = true;
            respuesta.Errores = new List<string>();
            try
            {
                respuesta = Validar.AltaJugadorCartera(jugador);
                if (respuesta.Exito == true)
                {
                    respuesta.Id = GuardarDAO.AltaJugadorCartera(jugador);
                }
            }
            catch (Exception ex)
            {
                respuesta.Exito = false;
                respuesta.Errores.Add(ex.Message);
            }
            return respuesta;
        }
        public static Respuesta AltaFichaTecnicaJugadorDeCartera(Modelo.Entidades.FichaTecnicaJugadorDeCartera ficha)
        {
            Respuesta respuesta = new Respuesta();
            respuesta.Exito = true;
            respuesta.Errores = new List<string>();
            try
            {
                respuesta = Validar.AltaFichaTecnicaJugadorCartera(ficha);
                if (respuesta.Exito == true)
                {
                    respuesta.Id = GuardarDAO.AltaFichaTecnicaJugadorCartera(ficha);
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

