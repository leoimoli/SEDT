﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEDT.Modelo.Entidades;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace SEDT.Modelo.DAO
{
    public class ConsultarDAO
    {
        public static MySql.Data.MySqlClient.MySqlConnection connection = new MySqlConnection(ConfigurationManager.AppSettings.Get("DB"));
        public static bool ValidarAltaEquipoUsuarioExistente(EquipoUsuario equipo)
        {
            bool ValidarExistencia;
            connection.Open();
            DataTable dt = new DataTable();

            /// PROCEDIMIENTO

            MySqlParameter[] oParam = {
                                      new MySqlParameter("Nombre_in", equipo.NombreEquipo),
                                      new MySqlParameter("idUsuario_in", equipo.IdUsuario)};
            string proceso = "BuscarNombreEquipoExistente";
            MySqlDataAdapter da = new MySqlDataAdapter(proceso, connection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddRange(oParam);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                ValidarExistencia = true;
            }
            else
            {
                ValidarExistencia = false;
            }
            connection.Close();
            return ValidarExistencia;
        }

        public static List<EquipoUsuario> ConsultarEquiposUsuario(EquipoUsuario equipo)
        {
            connection.Open();
            List<EquipoUsuario> lista = new List<EquipoUsuario>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;

            //string BuscarJugador = "Select * From tPersona";
            //MySqlDataAdapter dt = new MySqlDataAdapter(BuscarJugador, connection);
            //DataTable Tabla = new DataTable();
            //dt.Fill(Tabla);
            //if (Tabla.Rows.Count > 0)
            //{
            //    DtoJugadores li = new DtoJugadores();
            //    DataSet ds = new DataSet();
            //    dt.Fill(ds, "tPersona");
            //    foreach (DataRow item in ds.Tables[0].Rows)
            //    {
            //        DtoJugadores dtoLista = new DtoJugadores();
            //        dtoLista.IdPersona = int.Parse(item["idPersona"].ToString());
            //        dtoLista.Apellido = item["txApellido"].ToString();
            //        dtoLista.Nombre = item["txNombre"].ToString();
            //        lista.Add(dtoLista);
            //    }
            //}
            //connection.Close();
            //return lista;
        }

        public static bool AltaPersonaFisicaJugadorExistentePorDni(string dni, int idUsuario)
        {
            bool ValidarExistencia;
            connection.Open();
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("txDni_in", dni), new MySqlParameter("idUsuario_in", idUsuario) };
            string proceso = "AltaPersonaFisicaJugadorExistentePorDni";
            MySqlDataAdapter da = new MySqlDataAdapter(proceso, connection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddRange(oParam);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                ValidarExistencia = true;
            }
            else
            {
                ValidarExistencia = false;
            }
            connection.Close();
            return ValidarExistencia;
        }
        public static bool AltaPersonaFisicaJugadorExistente(string apellido, string nombre, string apodo, int idUsuario)
        {
            bool ValidarExistencia;
            connection.Open();
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("txApellido_in", apellido),  new MySqlParameter("txNombre_in", nombre),  new MySqlParameter("txApodo_in", apodo), new MySqlParameter("idUsuario_in", idUsuario) };
            string proceso = "AltaPersonaFisicaJugadorExistente";
            MySqlDataAdapter da = new MySqlDataAdapter(proceso, connection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddRange(oParam);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                ValidarExistencia = true;
            }
            else
            {
                ValidarExistencia = false;
            }
            connection.Close();
            return ValidarExistencia;
        }
        public static bool ValidarAltaEquipoRival(EquipoRival equipoRival)
        {
            bool ValidarExistencia;
            connection.Open();
            DataTable dt = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("NombreEquipo_in", equipoRival.NombreEquipo),
                                      new MySqlParameter("IdEquipoUsuario_in", equipoRival.IdEquipoUsuario)};
            string proceso = "BuscarNombreEquipoRivalExistente";
            MySqlDataAdapter da = new MySqlDataAdapter(proceso, connection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddRange(oParam);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                ValidarExistencia = true;
            }
            else
            {
                ValidarExistencia = false;
            }
            connection.Close();
            return ValidarExistencia;
        }
        public static bool BuscarTorneoExistente(Torneo torneo)
        {
            bool ValidarExistencia;
            connection.Open();
            DataTable dt = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("NombreTorneo_in", torneo.NombreTorneo),
                                      new MySqlParameter("IdEquipoUsuario_in", torneo.IdEquipoUsuario)};
            string proceso = "BuscarTorneoExistente";
            MySqlDataAdapter da = new MySqlDataAdapter(proceso, connection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddRange(oParam);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                ValidarExistencia = true;
            }
            else
            {
                ValidarExistencia = false;
            }
            connection.Close();
            return ValidarExistencia;
        }
        public static int BuscarUltimoPartidoRegistrado()
        {
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "select MAX(idPartido) From tPartidos";
            Int32 partido = (Int32)cmd.ExecuteScalar();
            connection.Close();
            int idPartido = partido;
            return idPartido;
        }
    }
}
