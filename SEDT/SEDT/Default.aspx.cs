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
        public DefaultConsulta DatosDefault { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Respuesta respuesta = new Respuesta();

                int idUsuario = Convert.ToInt32(((Usuario)HttpContext.Current.Session["loginUsuario"]).IdUsuario);
                DatosDefault = Consultar.ConsultaDefault(idUsuario);
                AsignarDatosUsuario();
                respuesta.Exito = true;
            }
            catch (Exception ex)
            {
                //resultado.Exito = false;
                //resultado.Errores = new List<string>();
                //resultado.Errores.Add(e.Message);
            }

        }

        private void AsignarDatosUsuario()
        {
            repeaterEquipos.DataSource = DatosDefault.EquiposUsuario;
            repeaterEquipos.DataBind();

            repeaterJugadores.DataSource = DatosDefault.JugadoresUsuario;
            repeaterJugadores.DataBind();

            repeaterPartidos.DataSource = DatosDefault.PartidosUsuario;
            repeaterPartidos.DataBind();
        }
    }
}
