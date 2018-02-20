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
    public partial class ConsultaJugadorWF : Page
    {
        private static Usuario _usuarioActual;
        public static Usuario usuarioActual
        {
            get { return _usuarioActual; }
            set { _usuarioActual = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

            usuarioActual = (Usuario)HttpContext.Current.Session["loginUsuario"];
            List<EquipoUsuario> equipos = Consultar.ConsultarEquiposUsuario(new EquipoUsuario { IdUsuario = Master.usuarioActual.IdUsuario });
            string elemento_equipo = "<label for=\"fname\"> Equipo:</label><select id=\"cmb_ConsultaJugadorWF_Equipo\" class=\"form-control\">";
            elemento_equipo += "<option value=\"" + 0 + "\">Seleccione</option>";
            foreach (EquipoUsuario equipo in equipos)
                elemento_equipo += "<option value=\"" + equipo.IdEquipoUsuario + "\">" + equipo.NombreEquipo + "</option>";
            elemento_equipo += "</select>";

            ConsultaJugador_ComboEquipo.Controls.Add(new LiteralControl(elemento_equipo));
        }

        //=============================================================
        //=============================================================
        [WebMethod]
        public static Respuesta ConsultarDatos(PersonaFisicaJugador obj)
        {
            Respuesta respuesta = new Respuesta();
            try
            {
                // Obtenemos el usuario de Sesión.
                obj.IdUsuario = usuarioActual.IdUsuario;
                respuesta.ResultadoConsultar = Consultar.ConsultarJugadores(obj);
                respuesta.Exito = true;
            }
            catch (Exception e)
            {
                respuesta.Exito = false;
                respuesta.Errores = new List<string>();
                respuesta.Errores.Add(e.Message);
            }
            return respuesta;
        }
        //=============================================================
        //=============================================================
    }
}