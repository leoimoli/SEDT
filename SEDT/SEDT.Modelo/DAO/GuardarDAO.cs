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
            string proceso = "AltaEquipoUsuario";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Nombre_in", equipo.NombreEquipo);
            cmd.Parameters.AddWithValue("ImagenEscudo_in", equipo.ImagenEscudo);
            cmd.Parameters.AddWithValue("IdUsuario_in", equipo.IdUsuario);
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
    }
}
