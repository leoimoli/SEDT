using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SEDT
{
    public static class ValoresConstantes
    {
        public static string[] TipoDeEntrenamiento
        {
            get
            {
                return new string[] { "FÍSICO", "FÍSICO-TÉCNICO", "TÁCTICO", "FÚTBOL" };
            }
        }
        public static string[] LugarDeEntrenamiento
        {
            get
            {
                return new string[] { "CANCHA PRINCIPAL", "CANCHA AUXILIAR", "GIMNASIO" };
            }
        }

        public static string[] Condicion
        {
            get
            {
                return new string[] { "LOCAL", "VISITANTE" };
            }
        }
    }
}