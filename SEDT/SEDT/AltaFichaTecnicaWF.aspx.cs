using SEDT.Controlador;
using SEDT.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Web.Services;
using System.Web.UI;

namespace SEDT
{
    public partial class AltaFichaTecnicaWF : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        //=============================================================
        //=============================================================
        [WebMethod]
        public static Respuesta GuardarDatos(PersonaFisicaJugador obj)
        {
            Respuesta resultado = new Respuesta();
            try
            {
                resultado = Agregar.AltaPersonaFisicaJugador(obj);
            }
            catch (Exception e)
            {
                resultado.Exito = false;
                resultado.Errores = new List<string>();
                resultado.Errores.Add(e.Message);
            }
            return resultado;
        }
        //=============================================================
        //=============================================================
    }
}