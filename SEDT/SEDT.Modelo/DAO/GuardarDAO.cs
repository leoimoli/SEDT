﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEDT.Modelo.Entidades;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace SEDT.Modelo.DAO
{
    public class GuardarDAO
    {
        public static MySql.Data.MySqlClient.MySqlConnection connection = new MySqlConnection(ConfigurationManager.AppSettings.Get("DB"));
        public static int AltaEquipoUsuario(EquipoUsuario equipo)
        {
            int id = 1;
            connection.Open();
            string proceso = "AltaEquipoUsuario";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Nombre_in", equipo.NombreEquipo);
            cmd.Parameters.AddWithValue("ImagenEscudo_in", equipo.ImagenEscudo);
            cmd.Parameters.AddWithValue("IdUsuario_in", equipo.IdUsuario);
            cmd.Parameters.AddWithValue("Siglas_in", equipo.Siglas);
            cmd.Parameters.AddWithValue("SitioWeb_in", equipo.SitioWeb);
            cmd.Parameters.AddWithValue("TelefonoDeContacto_in", equipo.TelefonoDeContacto);
            cmd.ExecuteNonQuery();
            connection.Close();
            return id;
        }
        public static int AltaPersonaFisicaJugador(PersonaFisicaJugador jugador)
        {
            int id = 1;
            connection.Open();
            ///PROCEDIMIENTO
            string proceso = "AltaPersonaFisicaJugador";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("txDni_in", jugador.Dni);
            cmd.Parameters.AddWithValue("txApellido_in", jugador.Apellido);
            cmd.Parameters.AddWithValue("txNombre_in", jugador.Nombre);
            cmd.Parameters.AddWithValue("txApodo_in", jugador.Apodo);
            cmd.Parameters.AddWithValue("dtFechaNacimiento_in", jugador.FechaNacimiento);
            cmd.Parameters.AddWithValue("txAltura_in", jugador.Altura);
            cmd.Parameters.AddWithValue("txPeso_in", jugador.Peso);
            cmd.Parameters.AddWithValue("imagen_in", jugador.Imagen);
            cmd.Parameters.AddWithValue("idUsuario_in", jugador.idUsuario);
            cmd.ExecuteNonQuery();
            connection.Close();
            return id;
        }
        public static int AltaFichaTecnicaJugador(FichaTecnicaJugador ficha)
        {
            int id = 1;
            connection.Open();
            string proceso = "AltaFichaTecnicaJugador";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("PosicionDeCampo_in", ficha.PosicionDeCampo);
            cmd.Parameters.AddWithValue("PiernaHabil_in", ficha.PiernaHabil);
            cmd.Parameters.AddWithValue("NivelPiernaHabil_in", ficha.NivelPiernaHabil);
            cmd.Parameters.AddWithValue("PiernaInhabil_in", ficha.PiernaInhabil);
            cmd.Parameters.AddWithValue("NivelPiernaInhabil_in", ficha.NivelPiernaInhabil);
            cmd.Parameters.AddWithValue("JuegoAereo_in", ficha.JuegoAereo);
            cmd.Parameters.AddWithValue("NivelDefensivo_in", ficha.NivelDefensivo);
            cmd.Parameters.AddWithValue("NivelOfensivo_in", ficha.NivelOfensivo);
            cmd.Parameters.AddWithValue("Velocidad_in", ficha.Velocidad);
            cmd.Parameters.AddWithValue("PredisposiciónEntrenamiento_in", ficha.PredisposiciónEntrenamiento);
            cmd.Parameters.AddWithValue("TecnicaIndividual_in", ficha.TecnicaIndividual);
            cmd.Parameters.AddWithValue("DisciplinaTactica_in", ficha.DisciplinaTactica);
            cmd.Parameters.AddWithValue("IdPersonaFisicaJugador_in", ficha.IdPersonaFisicaJugador);
            cmd.ExecuteNonQuery();
            connection.Close();
            return id;
        }
        public static int AltaTorneo(Torneo torneo)
        {
            int id = 1;
            connection.Open();
            string proceso = "AltaTorneo";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("NombreTorneo_in", torneo.NombreTorneo);
            cmd.Parameters.AddWithValue("Descripcion_in", torneo.Descripcion);
            cmd.Parameters.AddWithValue("IdEquipoUsuario_in", torneo.IdEquipoUsuario);
            cmd.ExecuteNonQuery();
            connection.Close();
            return id;
        }

        public static int AltaEquipoRival(EquipoRival equipoRival)
        {
            int id = 1;
            connection.Open();
            string proceso = "AltaEquipoRival";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("NombreEquipo_in", equipoRival.NombreEquipo);
            cmd.Parameters.AddWithValue("ImagenEscudo_in", equipoRival.ImagenEscudo);
            cmd.Parameters.AddWithValue("IdEquipoUsuario_in", equipoRival.IdEquipoUsuario);
            cmd.ExecuteNonQuery();
            connection.Close();
            return id;
        }
        public static int AltaPartido(Partido partido)
        {
            int id = 1;
            connection.Open();
            string proceso = "AltaPartido";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("FechaPartido_in", partido.FechaPartido);
            cmd.Parameters.AddWithValue("IdEquipoRival_in", partido.IdEquipoRival);
            cmd.Parameters.AddWithValue("txMarcador_in", partido.Marcador);
            cmd.Parameters.AddWithValue("txResultado_in", partido.Resultado);
            cmd.Parameters.AddWithValue("IdTorneo_in", partido.IdTorneo);
            cmd.ExecuteNonQuery();
            connection.Close();
            return id;
        }
    }
    //cmd.Parameters.AddWithValue("txFechaDisputada_in", partido.FechaDisputada);
    //cmd.Parameters.AddWithValue("txEquipoRival_in", partido.EquipoRival);
    //cmd.Parameters.AddWithValue("txSistemaTacticoPropio_in", partido.SistemaTacticoPropio);
    //cmd.Parameters.AddWithValue("intCornersFavor_in", partido.CornersFavor);
    //cmd.Parameters.AddWithValue("intCornersRival_in", partido.CornersRival);
    //cmd.Parameters.AddWithValue("intFaltasCometidasPropias_in", partido.FaltasCometidasPropias);
    //cmd.Parameters.AddWithValue("intFaltasRival_in", partido.FaltasRival);
    //cmd.Parameters.AddWithValue("intPenalesPropios_in", partido.PenalesPropios);
    //cmd.Parameters.AddWithValue("intPenalesRival_in", partido.PenalesRival);
    //cmd.Parameters.AddWithValue("intPosesionPropia_in", partido.PosesionPropia);
    //cmd.Parameters.AddWithValue("intPosesionRival_in", partido.PosesionRival);
}
