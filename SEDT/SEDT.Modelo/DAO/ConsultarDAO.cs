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
    }
}
