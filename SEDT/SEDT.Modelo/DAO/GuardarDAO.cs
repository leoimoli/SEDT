using System;
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
            string proceso = "GuardarEquipo";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Nombre_in", equipo.NombreEquipo);
            cmd.Parameters.AddWithValue("Division_in", equipo.ImagenEscudo);
            cmd.Parameters.AddWithValue("Descripcion_in", equipo.IdUsuario);
            cmd.ExecuteNonQuery();
            connection.Close();
            return id;
        }
    }
}
