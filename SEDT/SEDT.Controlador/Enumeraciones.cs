using SEDT.Modelo.DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDT.Controlador
{
    public static class Enumeraciones
    {
        public static Hashtable Actividad_Entrenamiento()
        {
            return EnumerableDAO.ObtenerActividadesEntrenamiento();
        }
        public static Hashtable Lugar_Entrenamiento()
        {
            return EnumerableDAO.ObtenerLugaresEntrenamiento();
        }

        public static Hashtable Condicion()
        {
            return EnumerableDAO.ObtenerCondicion();
        }
    }
}
