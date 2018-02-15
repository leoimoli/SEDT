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
using System.Collections;

namespace SEDT.Modelo.DAO
{
    public class EnumerableDAO
    {
        public static MySqlConnection connection = new MySqlConnection(ConfigurationManager.AppSettings.Get("DB"));

        public static Hashtable ObtenerActividadesEntrenamiento()
        {
            Hashtable actividades = new Hashtable();

            actividades.Add("1", "Físico");
            actividades.Add("2", "Táctico");
            actividades.Add("3", "Técnico");
            actividades.Add("4", "Fútbol");

            return actividades;
        }

        public static Hashtable ObtenerLugaresEntrenamiento()
        {
            Hashtable actividades = new Hashtable();

            actividades.Add("1", "Cancha principal");
            actividades.Add("2", "Cancha auxiliar");
            actividades.Add("3", "Gimnasio cubierto");
            actividades.Add("4", "Polideportivo");

            return actividades;
        }
    }
}
