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
    public class ActualizarDAO
    {
        public static MySql.Data.MySqlClient.MySqlConnection connection = new MySqlConnection(ConfigurationManager.AppSettings.Get("DB"));
        public static int ActualizarEquipoUsuario(EquipoUsuario equipo)
        {
            int id = 1;
            connection.Open();
            string proceso = "ActualizarEquipoUsuario";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Nombre_in", equipo.NombreEquipo);
            cmd.Parameters.AddWithValue("ImagenEscudo_in", equipo.ImagenEscudo);
            cmd.Parameters.AddWithValue("IdUsuario_in", equipo.IdUsuario);
            cmd.Parameters.AddWithValue("Siglas_in", equipo.Siglas);
            cmd.Parameters.AddWithValue("SitioWeb_in", equipo.SitioWeb);
            cmd.Parameters.AddWithValue("TelefonoDeContacto_in", equipo.TelefonoDeContacto);
            cmd.Parameters.AddWithValue("Id", equipo.IdEquipoUsuario);
            cmd.ExecuteNonQuery();
            connection.Close();
            return id;
        }
        public static int ActualizarPersonaFisicaJugador(PersonaFisicaJugador jugador)
        {
            int id = 1;
            connection.Open();
            ///PROCEDIMIENTO
            string proceso = "ActualizarPersonaFisicaJugador";
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
            cmd.Parameters.AddWithValue("Id", jugador.IdPersonaFisicaJugador);
            cmd.ExecuteNonQuery();
            connection.Close();
            return id;
        }
        public static int ActualizarFichaTecnicaJugador(FichaTecnicaJugador ficha)
        {
            int id = 1;
            connection.Open();
            string proceso = "ActualizarFichaTecnicaJugador";
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
            cmd.Parameters.AddWithValue("Id", ficha.IdFichaTecnicaJugador);
            cmd.ExecuteNonQuery();
            connection.Close();
            return id;
        }
        public static int ActualizarTorneo(Torneo torneo)
        {
            int id = 1;
            connection.Open();
            string proceso = "ActualizarTorneo";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("NombreTorneo_in", torneo.NombreTorneo);
            cmd.Parameters.AddWithValue("Descripcion_in", torneo.Descripcion);
            cmd.Parameters.AddWithValue("IdEquipoUsuario_in", torneo.IdEquipoUsuario);
            cmd.Parameters.AddWithValue("Id", torneo.IdTorneo);
            cmd.ExecuteNonQuery();
            connection.Close();
            return id;
        }
        public static int ActualizarEquipoRival(EquipoRival equipoRival)
        {
            int id = 1;
            connection.Open();
            string proceso = "ActualizarEquipoRival";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("NombreEquipo_in", equipoRival.NombreEquipo);
            cmd.Parameters.AddWithValue("ImagenEscudo_in", equipoRival.ImagenEscudo);
            cmd.Parameters.AddWithValue("IdEquipoUsuario_in", equipoRival.IdEquipoUsuario);
            cmd.Parameters.AddWithValue("Id", equipoRival.IdEquipoRival);
            cmd.ExecuteNonQuery();
            connection.Close();
            return id;
        }
    }
}
