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
        public static List<Usuario> LoginUsuario(Usuario usuario)
        {
            connection.Open();
            List<Usuario> lista = new List<Usuario>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("Dni_in", usuario.Dni),
                                       new MySqlParameter("Contraseña_in", usuario.Contraseña),
             new MySqlParameter("Estado_in", usuario.Estado)};
            string proceso = "LoginUsuario";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            DataSet ds = new DataSet();
            dt.Fill(ds, "tUsuarios");
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    Usuario listaUsuario = new Usuario();
                    listaUsuario.IdUsuario = Convert.ToInt32(item["idUsuario"].ToString());
                    listaUsuario.Apellido = item["txApellido"].ToString();
                    listaUsuario.Nombre = item["txNombre"].ToString();
                    listaUsuario.Dni = item["txDni"].ToString();
                    listaUsuario.Email = item["txEmail"].ToString();
                    listaUsuario.Telefono = item["txTelefono"].ToString();
                    listaUsuario.IdPlanDePago = Convert.ToInt32(item["idPlanDePago"].ToString());
                    listaUsuario.FechaDeAlta = Convert.ToDateTime(item["dtFechaDeAlta"].ToString());
                    listaUsuario.FechaUltimaConexion = Convert.ToDateTime(item["dtFechaUltimaConexion"].ToString());
                    listaUsuario.Contraseña = item["txContrasena"].ToString();
                    listaUsuario.Estado = item["txEstado"].ToString();
                    lista.Add(listaUsuario);
                }
            }
            connection.Close();
            return lista;
        }
        public static int CantidadEquiposRegistrados(EquipoUsuario equipo)
        {
            int CantidadEquiposRegistrados = 0;
            connection.Close();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "select count(*) as total from sedt_desarrollo.tequipousuario where idUsuario = '" + equipo.IdUsuario + "'";
            Int32 Cantidad = int.Parse(cmd.ExecuteScalar().ToString());
            CantidadEquiposRegistrados = Cantidad;
            connection.Close();
            return CantidadEquiposRegistrados;
        }

        public static int CantidadJugadoresRegistrados(int idUsuario)
        {
            int CantidadJugadoresRegistrados = 0;
            connection.Close();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "select count(*) as total from sedt_desarrollo.tpersonafisicajugador where idUsuario = '" + idUsuario + "'";
            Int32 Cantidad = int.Parse(cmd.ExecuteScalar().ToString());
            CantidadJugadoresRegistrados = Cantidad;
            connection.Close();
            return CantidadJugadoresRegistrados;
        }

        public static PlanDePago PlanDePagoUsuario(int idUsuario)
        {
            connection.Close();
            connection.Open();
            PlanDePago lista = new PlanDePago();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                new MySqlParameter("idUsuario_in", idUsuario) };
            string proceso = "ConsultarPlanDePagoUsuario";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            DataSet ds = new DataSet();
            dt.Fill(ds, "tUsuarios");
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    PlanDePago plan = new PlanDePago();
                    plan.IdPlanDePago = Convert.ToInt32(item["IdPlanDePago"].ToString());
                    plan.NombreDePlan = item["txNombreDePlan"].ToString();
                    plan.Dias = Convert.ToInt32(item["txDias"].ToString());
                    plan.CantidadEquipos = Convert.ToInt32(item["txCantidadEquipos"].ToString());
                    plan.CantidadJugadores = Convert.ToInt32(item["txCantidadJugadores"].ToString());
                    lista = plan;
                }
            }
            connection.Close();
            return lista;
        }
        private static string querytpersonafisicajugador
        {
            get
            {
                return
                @"SELECT 
                jugador.idUsuario,
                jugador.idPersonaFisicaJugador as IdJugador,
                jugador.txNombre as Nombre ,
                jugador.txApellido as Apellido,
                jugador.txApodo as Apodo,
                ficha.txPosicionDeCampo as Posicion,
                ficha.txAltura as Altura,
                ficha.txPeso as Peso
                FROM tpersonafisicajugador as jugador
                left join tfichatecnica as ficha on ficha.idJugador = jugador.idPersonaFisicaJugador "
            ;
            }
        }
        public static List<PersonaFisicaJugadorConsultar> BuscarJugadorPorFiltros(PersonaFisicaJugador Listajugador)
        {

            List<PersonaFisicaJugadorConsultar> lista = new List<PersonaFisicaJugadorConsultar>();
            string filtros = string.Empty;
            if (!string.IsNullOrEmpty(Listajugador.Dni.Trim()))
            {
                filtros += string.IsNullOrEmpty(filtros)
                    ? " where txDni = " + Listajugador.Dni
                    : " and  txDni = " + Listajugador.Dni;
            }
            if (!string.IsNullOrEmpty(Listajugador.Apellido.Trim()))
            {
                filtros += string.IsNullOrEmpty(filtros)
                    ? " where txApellido like '%" + Listajugador.Apellido + "%' "
                    : " and  txApellido like '%" + Listajugador.Apellido + "%' ";
            }
            if (!string.IsNullOrEmpty(Listajugador.Nombre.Trim()))
            {
                filtros += string.IsNullOrEmpty(filtros)
                    ? " where txNombre like '%" + Listajugador.Nombre + "%' "
                    : " and  txNombre like '%" + Listajugador.Nombre + "%' ";
            }
            if (!string.IsNullOrEmpty(Listajugador.Apodo.Trim()))
            {
                filtros += string.IsNullOrEmpty(filtros)
                    ? " where txApodo like '%" + Listajugador.Apodo + "%' "
                    : " and  txApodo like '%" + Listajugador.Apodo + "%' ";
            }
            if (Listajugador.IdUsuario > 0)
            {
                filtros += Listajugador.IdUsuario < 0
                    ? " where idUsuario = " + Listajugador.IdUsuario
                    : " and  idUsuario = " + Listajugador.IdUsuario;
            }
            string sqlQuery = querytpersonafisicajugador + filtros;

            using (var connect = connection)
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sqlQuery, connect);
                MySqlDataReader r = cmd.ExecuteReader();

                while (r.Read()) lista.Add(SqlToEntityPersonaFisicaJugadorConsultar(r));

                connection.Close();
            }



            return lista;
        }
        private static PersonaFisicaJugadorConsultar SqlToEntityPersonaFisicaJugadorConsultar(MySqlDataReader item)
        {
            PersonaFisicaJugadorConsultar jugador = new PersonaFisicaJugadorConsultar();
            jugador.Nombre = (item["Nombre"] != DBNull.Value) ? (string)item["Nombre"].ToString() : string.Empty;
            jugador.Apellido = (item["Apellido"] != DBNull.Value) ? (string)item["Apellido"].ToString() : string.Empty;
            jugador.Apodo = (item["Apodo"] != DBNull.Value) ? (string)item["Apodo"].ToString() : string.Empty;
            jugador.Posicion = (item["Posicion"] != DBNull.Value) ? (string)item["Posicion"].ToString() : string.Empty;
            jugador.Altura = (item["Altura"] != DBNull.Value) ? (string)item["Altura"].ToString() : string.Empty;
            jugador.Peso = (item["Peso"] != DBNull.Value) ? (string)item["Peso"].ToString() : string.Empty;
            return jugador;
        }
        public static JugadorCartera ConsultarJugadorCarteraPorID(int idJugador)
        {
            connection.Open();
            JugadorCartera lista = new JugadorCartera();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                new MySqlParameter("idJugador_in", idJugador) };
            string proceso = "ConsultarJugadorCarteraPorId";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            DataSet ds = new DataSet();
            dt.Fill(ds, "tJugadorCartera");
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    JugadorCartera jugador = new JugadorCartera();
                    jugador.Apellido = item["txApellido"].ToString();
                    jugador.Nombre = item["txNombre"].ToString();
                    jugador.Apodo = item["txApodo"].ToString();
                    lista = jugador;
                }
            }
            connection.Close();
            return lista;
        }
        public static PersonaFisicaJugador ConsultarJugadorPorID(int idJugador)
        {
            connection.Open();
            PersonaFisicaJugador lista = new PersonaFisicaJugador();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                new MySqlParameter("idJugador_in", idJugador) };
            string proceso = "ConsultarJugadorPorId";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            DataSet ds = new DataSet();
            dt.Fill(ds, "tpersonafisicajugador");
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    PersonaFisicaJugador jugador = new PersonaFisicaJugador();
                    jugador.Dni = item["txDni"].ToString();
                    jugador.Apellido = item["txApellido"].ToString();
                    jugador.Nombre = item["txNombre"].ToString();
                    jugador.Apodo = item["txApodo"].ToString();
                    jugador.FechaNacimiento = Convert.ToDateTime(item["dtFechaNacimiento"].ToString());
                    jugador.Altura = item["txTelefono"].ToString();
                    jugador.Peso = item["txPeso"].ToString();
                    jugador.Imagen = item["ImagenJugador"].ToString();
                    lista = jugador;
                }
            }
            connection.Close();
            return lista;
        }
        public static bool ValidarUsuarioExistente(string dni)
        {
            bool ValidarExistencia;
            connection.Open();
            DataTable dt = new DataTable();

            /// PROCEDIMIENTO

            MySqlParameter[] oParam = {
                                      new MySqlParameter("Dni_in", dni) };
            string proceso = "BuscarUsuarioExistentePorDni";
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
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("idUsuario_in", equipo.IdUsuario)};
            string proceso = "ConsultarEquiposUsuarioPorIdUsuario";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            DataSet ds = new DataSet();
            dt.Fill(ds, "tequipoUsuario");
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    EquipoUsuario listaEquipos = new EquipoUsuario();
                    listaEquipos.IdEquipoUsuario = Convert.ToInt32(item["idEquipoUsuario"].ToString());
                    listaEquipos.NombreEquipo = item["txNombreEquipo"].ToString();
                    listaEquipos.Siglas = item["txSiglas"].ToString();
                    listaEquipos.SitioWeb = item["txSitioWeb"].ToString();
                    listaEquipos.TelefonoDeContacto = item["txTelefonoDeContacto"].ToString();
                    lista.Add(listaEquipos);
                }
            }
            connection.Close();
            return lista;
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
        // TODO:
        public static int BuscarJugador()
        {
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "select MAX(idPersonaFisicaJugador) FROM tpersonafisicajugador";
            Int32 idJugador = (Int32)cmd.ExecuteScalar();
            connection.Close();
            return idJugador;
        }
    }
}
