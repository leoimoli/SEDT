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
        protected void Page_Load(object sender, EventArgs e)
        {
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
                respuesta.Resultado = Consultar.ConsultarJugadores(obj);
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