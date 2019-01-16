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
        public static int AltaUsuario(Usuario usuario)
        {
            int id = 1;
            usuario.IdPlanDePago = 4;
            connection.Close();
            connection.Open();
            string proceso = "AltaUsuario";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Apellido_in", usuario.Apellido);
            cmd.Parameters.AddWithValue("Nombre_in", usuario.Nombre);
            cmd.Parameters.AddWithValue("Dni_in", usuario.Dni);
            cmd.Parameters.AddWithValue("Email_in", usuario.Email);
            cmd.Parameters.AddWithValue("Telefono_in", usuario.Telefono);
            cmd.Parameters.AddWithValue("IdPlanDePago_in", usuario.IdPlanDePago);
            usuario.FechaDeAlta = DateTime.Now;
            cmd.Parameters.AddWithValue("FechaDeAlta_in", usuario.FechaDeAlta);
            cmd.Parameters.AddWithValue("FechaUltimaConexion_in", usuario.FechaUltimaConexion);
            cmd.Parameters.AddWithValue("Contraseña_in", usuario.Contraseña);
            usuario.Estado = "ACTIVO";
            cmd.Parameters.AddWithValue("Estado_in", usuario.Estado);
            cmd.ExecuteNonQuery();
            connection.Close();
            return id;
        }
        public static int AltaEquipoUsuario(EquipoUsuario equipo)
        {
            int id = 1;
            connection.Close();
            connection.Open();
            string proceso = "AltaEquipoUsuario";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Nombre_in", equipo.NombreEquipo);
            cmd.Parameters.AddWithValue("ImagenEscudo_in", equipo.Imagen);
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
            int id = 0;
            connection.Close();
            connection.Open();
            string proceso = "AltaPersonaFisicaJugador";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Dni_in", jugador.Dni);
            cmd.Parameters.AddWithValue("Apellido_in", jugador.Apellido);
            cmd.Parameters.AddWithValue("Nombre_in", jugador.Nombre);
            cmd.Parameters.AddWithValue("Apodo_in", jugador.Apodo);
            cmd.Parameters.AddWithValue("FechaNacimiento_in", jugador.FechaNacimiento);
            //cmd.Parameters.AddWithValue("Peso_in", jugador.Peso);
            //cmd.Parameters.AddWithValue("imagen_in", jugador.Imagen);
            cmd.Parameters.AddWithValue("Telefono_in", jugador.Telefono);
            cmd.Parameters.AddWithValue("imagen_in", jugador.Imagen);
            cmd.Parameters.AddWithValue("idUsuario_in", jugador.IdUsuario);

            MySqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                id = Convert.ToInt32(r["ID"].ToString());
            }
            connection.Close();
            return id;
        }
        public static int AltaFichaTecnica(FichaTecnicaJugador ficha)
        {

            string[] p = ficha.Peso.Split(':');
            string peso = p[1];
            string[] a = ficha.Altura.Split(':');
            string altura = a[1];
            int id = 1;
            connection.Close();
            connection.Open();
            string proceso = "AltaFichaTecnica";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("PosicionDeCampo_in", ficha.PosicionDeCampo);
            cmd.Parameters.AddWithValue("PiernaHabil_in", ficha.PiernaHabil);
            cmd.Parameters.AddWithValue("Altura_in", altura);
            cmd.Parameters.AddWithValue("Peso_in", peso);
            ///// Cualidades Fisicas
            cmd.Parameters.AddWithValue("Salto_in", ficha.Salto);
            cmd.Parameters.AddWithValue("Velocidad_in", ficha.Velocidad);
            cmd.Parameters.AddWithValue("Resistencia_in", ficha.Resistencia);
            cmd.Parameters.AddWithValue("Fuerza_in", ficha.Fuerza);
            ///// Cualidades Tecnicas
            cmd.Parameters.AddWithValue("ControlDeBalon_in", ficha.ControlDeBalon);
            cmd.Parameters.AddWithValue("Regates_in", ficha.Regates);
            cmd.Parameters.AddWithValue("Definicion_in", ficha.Definicion);
            cmd.Parameters.AddWithValue("Marcaje_in", ficha.Marcaje);
            cmd.Parameters.AddWithValue("PaseCorto_in", ficha.PaseCorto);
            cmd.Parameters.AddWithValue("PaseLargo_in", ficha.PaseLargo);
            cmd.Parameters.AddWithValue("Remate_in", ficha.Remate);
            cmd.Parameters.AddWithValue("TiroLibre_in", ficha.TiroLibre);
            ///// Cualidades tacticas
            cmd.Parameters.AddWithValue("DisciplinaTactica_in", ficha.DisciplinaTactica);
            cmd.Parameters.AddWithValue("NivelDefensivo_in", ficha.NivelDefensivo);
            cmd.Parameters.AddWithValue("NivelOfensivo_in", ficha.NivelOfensivo);

            cmd.Parameters.AddWithValue("IdJugador_in", ficha.IdJugador);
            cmd.ExecuteNonQuery();
            connection.Close();
            return id;
        }
        public static int AltaFichaTecnicaJugadorCartera(FichaTecnicaJugadorDeCartera ficha)
        {
            int id = 1;
            connection.Close();
            connection.Open();
            string proceso = "AltaFichaTecnicaJugadorCartera";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("PosicionDeCampo_in", ficha.PosicionDeCampo);
            cmd.Parameters.AddWithValue("PiernaHabil_in", ficha.PiernaHabil);
            cmd.Parameters.AddWithValue("Altura_in", ficha.Altura);
            cmd.Parameters.AddWithValue("Peso_in", ficha.Peso);
            ///// Cualidades Fisicas
            cmd.Parameters.AddWithValue("Salto_in", ficha.Salto);
            cmd.Parameters.AddWithValue("Velocidad_in", ficha.Velocidad);
            cmd.Parameters.AddWithValue("Resistencia_in", ficha.Resistencia);
            cmd.Parameters.AddWithValue("Fuerza_in", ficha.Fuerza);
            ///// Cualidades Tecnicas
            cmd.Parameters.AddWithValue("ControlDeBalon_in", ficha.ControlDeBalon);
            cmd.Parameters.AddWithValue("Regates_in", ficha.Regates);
            cmd.Parameters.AddWithValue("Definicion_in", ficha.Definicion);
            cmd.Parameters.AddWithValue("Marcaje_in", ficha.Marcaje);
            cmd.Parameters.AddWithValue("PaseCorto_in", ficha.PaseCorto);
            cmd.Parameters.AddWithValue("PaseLargo_in", ficha.PaseLargo);
            cmd.Parameters.AddWithValue("Remate_in", ficha.Remate);
            cmd.Parameters.AddWithValue("TiroLibre_in", ficha.TiroLibre);
            ///// Cualidades tacticas
            cmd.Parameters.AddWithValue("DisciplinaTactica_in", ficha.DisciplinaTactica);
            cmd.Parameters.AddWithValue("NivelDefensivo_in", ficha.NivelDefensivo);
            cmd.Parameters.AddWithValue("NivelOfensivo_in", ficha.NivelOfensivo);

            cmd.Parameters.AddWithValue("IdJugador_in", ficha.IdJugador);
            cmd.ExecuteNonQuery();
            connection.Close();
            return id;
        }
        public static int AltaTorneo(Torneo torneo)
        {
            int id = 1;
            connection.Close();
            connection.Open();
            string proceso = "AltaTorneo";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("NombreTorneo_in", torneo.NombreTorneo);
            cmd.Parameters.AddWithValue("Descripcion_in", torneo.Descripcion);
            cmd.Parameters.AddWithValue("FormatoTorneo_in", torneo.FormatoTorneo);
            cmd.Parameters.AddWithValue("DuracionPartido_in", torneo.DuracionPartidos);
            cmd.Parameters.AddWithValue("IdUsuario_in", torneo.IdEquipoUsuario);
            cmd.Parameters.AddWithValue("Imagen_in", torneo.ImagenTorneo);
            cmd.ExecuteNonQuery();
            connection.Close();
            return id;
        }
        public static int AltaEquipoRival(EquipoRival equipoRival)
        {
            int id = 1;
            connection.Close();
            connection.Open();
            string proceso = "AltaEquipoRival";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("NombreEquipo_in", equipoRival.NombreEquipo);
            cmd.Parameters.AddWithValue("ImagenEscudo_in", equipoRival.ImagenEscudo);
            cmd.Parameters.AddWithValue("IdEquipoUsuario_in", equipoRival.IdUsuario);
            cmd.ExecuteNonQuery();
            connection.Close();
            return id;
        }
        public static int AltaJugadorCartera(JugadorCartera jugador)
        {
            int id = 0;
            connection.Close();
            connection.Open();
            string proceso = "AltaJugadorCartera";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Apellido_in", jugador.Apellido);
            cmd.Parameters.AddWithValue("Nombre_in", jugador.Nombre);
            cmd.Parameters.AddWithValue("Apodo_in", jugador.Apodo);
            cmd.Parameters.AddWithValue("Telefono_in", jugador.Telefono);
            cmd.Parameters.AddWithValue("Email_in", jugador.Email);
            cmd.Parameters.AddWithValue("RedSocial_in", jugador.RedSocial);
            cmd.Parameters.AddWithValue("EquipoObservado_in", jugador.EquipoObservado);
            cmd.Parameters.AddWithValue("EquipoRival_in", jugador.EquipoRival);
            cmd.Parameters.AddWithValue("FechaPartido_in", jugador.FechaPartido);
            cmd.Parameters.AddWithValue("idUsuario_in", jugador.idUsuario);
            MySqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                id = Convert.ToInt32(r["ID"].ToString());
            }
            connection.Close();
            return id;
        }
        public static int AltaPartido(Partido partido)
        {
            int id = 0;
            int idUltimoPartido = 0;
            connection.Close();
            connection.Open();
            string proceso = "AltaPartido";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("FechaPartido_in", partido.FechaPartido);
            cmd.Parameters.AddWithValue("IdEquipoRival_in", partido.IdEquipoRival);
            cmd.Parameters.AddWithValue("txMarcador_in", partido.Marcador);
            cmd.Parameters.AddWithValue("txResultado_in", partido.Resultado);
            cmd.Parameters.AddWithValue("IdTorneo_in", partido.IdTorneo);
            cmd.Parameters.AddWithValue("IdEquipoUsuario_in", partido.IdEquipoUsuario);
            cmd.Parameters.AddWithValue("Condicion_in", partido.Condicion);
            MySqlDataReader r = cmd.ExecuteReader();
            connection.Close();
            while (r.Read())
            {
                idUltimoPartido = Convert.ToInt32(r["ID"].ToString());
            }

            //int idRegistroUltimoPartido = ConsultarDAO.BuscarUltimoPartidoRegistrado();
            return id;
        }
        public static int AltaEstadisticaPartido(EstadisticaPartido estadisticaPartido)
        {
            int id = 0;
            connection.Close();
            connection.Open();
            string proceso = "AltaEstadisticaPartido";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("CornersPropio_in", estadisticaPartido.CornersPropio);
            cmd.Parameters.AddWithValue("CornersRival_in", estadisticaPartido.CornersRival);
            cmd.Parameters.AddWithValue("FaltasRecibidas_in", estadisticaPartido.FaltasRecibidas);
            cmd.Parameters.AddWithValue("FaltasCometidas_in", estadisticaPartido.FaltasCometidas);
            cmd.Parameters.AddWithValue("PenalesRecibidos_in", estadisticaPartido.PenalesRecibidos);
            cmd.Parameters.AddWithValue("PenalesCometidos_in", estadisticaPartido.PenalesCometidos);
            cmd.Parameters.AddWithValue("OffsidePropio_in", estadisticaPartido.OffsidePropio);
            cmd.Parameters.AddWithValue("OffsideRival_in", estadisticaPartido.OffsideRival);
            cmd.Parameters.AddWithValue("PosesionPropia_in", estadisticaPartido.PosesionPropia);
            cmd.Parameters.AddWithValue("PosesioRival_in", estadisticaPartido.PosesioRival);
            cmd.Parameters.AddWithValue("TirosPropios_in", estadisticaPartido.TirosPropios);
            cmd.Parameters.AddWithValue("TirosRivales_in", estadisticaPartido.TirosRivales);
            cmd.Parameters.AddWithValue("TirosAlArcoPropios_in", estadisticaPartido.TirosAlArcoPropios);
            cmd.Parameters.AddWithValue("TirosAlArcoRivales_in", estadisticaPartido.TirosAlArcoRivales);
            cmd.Parameters.AddWithValue("CantidadPasesPropios_in", estadisticaPartido.CantidadPasesPropios);
            cmd.Parameters.AddWithValue("CantidadPasesRivales_in", estadisticaPartido.CantidadPasesRivales);
            cmd.Parameters.AddWithValue("idPartido_in", estadisticaPartido.idPartido);
            cmd.ExecuteNonQuery();
            connection.Close();
            return id;
        }
        public static int AltaEntrenamiento(Entrenamiento entrenamiento)
        {
            int id = 1;
            connection.Close();
            connection.Open();
            string proceso = "AltaEntrenamiento";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("FechaEntrenamiento_in", entrenamiento.FechaEntrenamiento);
            cmd.Parameters.AddWithValue("CantidadTurnoEntrenamiento_in", entrenamiento.CantidadTurnoEntrenamiento);
            cmd.Parameters.AddWithValue("IdEquipo_in", entrenamiento.IdEquipo);
            cmd.ExecuteNonQuery();
            connection.Close();
            return id;
        }
        public static int AltaTurnoEntrenamiento(TurnoEntrenamiento turnoentrenamiento)
        {
            int id = 1;
            connection.Close();
            connection.Open();
            string proceso = "AltaTurnoEntrenamiento";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("IdEntrenamiento_in", turnoentrenamiento.IdEntrenamiento);
            cmd.Parameters.AddWithValue("Horario_in", turnoentrenamiento.Horario);
            cmd.Parameters.AddWithValue("LugarEntrenamiento_in", turnoentrenamiento.LugarEntrenamiento);
            cmd.Parameters.AddWithValue("CantidadEtapas_in", turnoentrenamiento.CantidadEtapas);
            cmd.ExecuteNonQuery();
            connection.Close();
            return id;
        }
        public static int AltaEtapasEntrenamiento(EtapasEntrenamiento etapasentrenamiento)
        {
            int id = 1;
            connection.Close();
            connection.Open();
            string proceso = "AltaEtapasEntrenamiento";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("MaterialesDeTrabajo_in", etapasentrenamiento.MaterialesDeTrabajo);
            cmd.Parameters.AddWithValue("Descripcion_in", etapasentrenamiento.Descripcion);
            cmd.Parameters.AddWithValue("IdTurno_in", etapasentrenamiento.IdTurno);
            cmd.ExecuteNonQuery();
            connection.Close();
            return id;
        }
    }
}
