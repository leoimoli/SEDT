using SEDT.Controlador;
using SEDT.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace SEDT
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Respuesta respuesta = new Respuesta();

                int idUsuario = Convert.ToInt32(((Usuario)HttpContext.Current.Session["loginUsuario"]).IdUsuario);
                respuesta.ConsultaDefault = Consultar.ConsultaDefault(idUsuario);
                respuesta.Exito = true;
            }
            catch (Exception ex)
            {
                //resultado.Exito = false;
                //resultado.Errores = new List<string>();
                //resultado.Errores.Add(e.Message);
            }

        }

    }
}
