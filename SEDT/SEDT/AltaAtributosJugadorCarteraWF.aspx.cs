using SEDT.Controlador;
using SEDT.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using System.Web.UI;

namespace SEDT
{
    public partial class AltaAtributosJugadorCarteraWF : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var idJugadorCartera = ((int)HttpContext.Current.Session["personaJugador"]);
            if (idJugadorCartera > 0)
            {
                JugadorCartera jugador = Consultar.JugadorCarteraPorID(idJugadorCartera);
                ApeNom_label.Text = jugador.Apellido + " " + jugador.Nombre;
                Apodo_label.Text = jugador.Apodo;
            }
        }

        //=============================================================
        //=============================================================
        [WebMethod]
        public static Respuesta GuardarDatos(FichaTecnicaJugadorDeCartera obj)
        {
            Respuesta resultado = new Respuesta();
            string asd = HttpContext.Current.Request.Form["PiernaHabil"].ToString();
            try
            {
                resultado = Agregar.AltaFichaTecnicaJugadorDeCartera(obj);
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
