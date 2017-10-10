using System;
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
                                       new MySqlParameter("Contraseña_in", usuario.Contraseña)};
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
                    listaUsuario.Contraseña = item["txContraseña"].ToString();
                    lista.Add(listaUsuario);
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
                                      new MySqlParameter("NombreTorneo_in", equipo.IdUsuario)};
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
    }
}
