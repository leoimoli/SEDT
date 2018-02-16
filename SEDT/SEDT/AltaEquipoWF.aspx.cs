using SEDT.Controlador;
using SEDT.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.Services;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace SEDT
{
    public partial class AltaEquipoWF : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        //=============================================================
        //=============================================================
        [WebMethod]
        public static Respuesta GuardarDatos(EquipoUsuario obj)
        {
            Respuesta resultado = new Respuesta();
            try
            {
                resultado = Agregar.AltaEquipoUsuario(obj);
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