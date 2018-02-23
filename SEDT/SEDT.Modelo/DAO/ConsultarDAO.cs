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
        public static DefaultConsulta ConsultaDefault(int idUsuario)
        {
            ////// Busco el Plan del usuario Logueado....
            PlanDePago _plan = new PlanDePago();
            _plan = PlanDePagoUsuario(idUsuario);
            ////// Busco las competencias del usuario Logueado....
            int competencias = 0;
            connection.Close();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "select count(*) as total from ttorneo where idUsuario = '" + idUsuario + "'";
            competencias = int.Parse(cmd.ExecuteScalar().ToString());
            ////// Busco los equipos del usuario Logueado....
            List<EquipoUsuario> _equiposUsuario = new List<EquipoUsuario>();
            _equiposUsuario = ConsultarEquipoPorUsuarioLogueado(idUsuario);

            ////// Busco los idEquipoUsuario del usuario Logueado....
            List<int> cantidadEquipo = new List<int>();
            cantidadEquipo = ConsultarEquipoPorUsuarioLogueadoID(idUsuario);

            string filtro = string.Empty;
            if (cantidadEquipo.Count > 0)
            {
                foreach (var id in cantidadEquipo)
                {
                    if (filtro == string.Empty)
                    {
                        filtro += "(" + id;
                    }
                    else
                    {
                        filtro += "," + id;
                    }
                }
                filtro += ")";
            }
            int cantidadEquipos = cantidadEquipo.Count();
            ////// Busco los partidos con los idEquipo del usuario Logueado.... 
            List<PartidoConsultaDefault> _partido = new List<PartidoConsultaDefault>();
            _partido = BuscarUltimosPartidosDelUsuario(filtro);
            ////// Busco la Cantidad de partidos del usuario Logueado....
            int partidos = 0;
            connection.Close();
            connection.Open();
            MySqlCommand cmd2 = new MySqlCommand();
            cmd2.Connection = connection;
            cmd2.CommandText = "select count(*) as total from tpartidos where idEquipoPropio in('" + filtro + "')";
            partidos = int.Parse(cmd2.ExecuteScalar().ToString());
            ////// Busco la Cantidad de jugadores del usuario Logueado....
            int jugadores = 0;
            connection.Close();
            connection.Open();
            MySqlCommand cmd3 = new MySqlCommand();
            cmd3.Connection = connection;
            cmd3.CommandText = "select count(*) as total from tpersonafisicajugador where idUsuario = '" + idUsuario + "'";
            jugadores = int.Parse(cmd3.ExecuteScalar().ToString());
            ///// Busco los ultimos jugadores ingresados del usuario Logueado.... 
            List<JugadoresConsultaDefault> _jugador = new List<JugadoresConsultaDefault>();
            _jugador = BuscarUltimosJugadoresDelUsuario(idUsuario, filtro);

            ///// Asigno lo obtenido al default......
            DefaultConsulta listaDefault = new DefaultConsulta();
            listaDefault.plan = _plan;
            listaDefault.CantidadEquipos = cantidadEquipo.Count;
            listaDefault.EquiposUsuario = _equiposUsuario;
            listaDefault.CantidadCompetencias = competencias;
            listaDefault.CantidadEquipos = cantidadEquipos;
            listaDefault.CantidadPartidos = partidos;
            listaDefault.PartidosUsuario = _partido;
            listaDefault.CantidadJugadores = jugadores;
            listaDefault.JugadoresUsuario = _jugador;
            return listaDefault;

        }

        private static List<EquipoUsuario> ConsultarEquipoPorUsuarioLogueado(int idUsuario)
        {
            connection.Close();
            connection.Open();
            List<EquipoUsuario> lista = new List<EquipoUsuario>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                          new MySqlParameter("idUsuario_in", idUsuario)};
            string proceso = "ConsultarEquipoPorUsuarioLogueado";
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
                    EquipoUsuario listaEquipo = new EquipoUsuario();
                    listaEquipo.IdEquipoUsuario = Convert.ToInt32(item["IdEquipoUsuario"].ToString());
                    listaEquipo.NombreEquipo = item["txNombreEquipo"].ToString();
                    listaEquipo.Imagen = item["ImagenEscudo"].ToString();
                    lista.Add(listaEquipo);
                }
            }
            connection.Close();
            return lista;
        }
        private static List<JugadoresConsultaDefault> BuscarUltimosJugadoresDelUsuario(int idUsuario, string filtro)
        {
            connection.Close();
            connection.Open();
            List<JugadoresConsultaDefault> lista = new List<JugadoresConsultaDefault>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                     new MySqlParameter("idUsuario_in", idUsuario)};
            string proceso = "ConsultarUltimosJugadoresDelUsuario";
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
                    JugadoresConsultaDefault listajugador = new JugadoresConsultaDefault();
                    listajugador.Apellido = item["apellido"].ToString();
                    listajugador.Nombre = item["nombre"].ToString();
                    listajugador.Imagen = item["imagen"].ToString();
                    listajugador.NombreEquipo = item["nombreequipo"].ToString();
                    listajugador.Posicion = item["posicion"].ToString();
                    lista.Add(listajugador);
                }
            }
            connection.Close();
            return lista;
        }
        private static List<PartidoConsultaDefault> BuscarUltimosPartidosDelUsuario(string filtro)
        {
            connection.Open();
            List<PartidoConsultaDefault> lista = new List<PartidoConsultaDefault>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                       new MySqlParameter("filtroID_in", filtro)};
            string proceso = "ConsultarUltimosPartidosDelUsuario";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            DataSet ds = new DataSet();
            dt.Fill(ds, "tpartido");
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    PartidoConsultaDefault listaPartido = new PartidoConsultaDefault();
                    listaPartido.EquipoPropio = item["txEquipoPropio"].ToString();
                    listaPartido.EquipoRival = item["txEquipoRival"].ToString();
                    listaPartido.Resultado = item["txResultado"].ToString();
                    listaPartido.FechaPartido = Convert.ToDateTime(item["txFechaPartido"].ToString());
                    listaPartido.NombreTorneo = item["txNombreTorneo"].ToString();
                    lista.Add(listaPartido);
                }
            }
            connection.Close();
            return lista;
        }
        private static List<int> ConsultarEquipoPorUsuarioLogueadoID(int idUsuario)
        {
            connection.Close();
            connection.Open();
            List<int> lista = new List<int>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("idUsuario_in", idUsuario)};
            string proceso = "ConsultarEquipoPorUsuarioLogueadoID";
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
                    List<int> listaID = new List<int>();
                    int valor = Convert.ToInt32(item["idEquipoUsuario"].ToString());
                    listaID.Add(valor);
                    lista = listaID;
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
            cmd.CommandText = "select count(*) as total from tequipousuario where idUsuario = '" + equipo.IdUsuario + "'";
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
                    //jugador.Peso = item["txPeso"].ToString();
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
            connection.Close();
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


