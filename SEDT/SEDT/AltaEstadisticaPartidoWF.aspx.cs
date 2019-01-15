using SEDT.Controlador;
using SEDT.Modelo.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SEDT
{
    public partial class AltaEstadisticaPartidoWF : Page
    {
        private static Usuario _usuarioActual;
        public static Usuario usuarioActual
        {
            get { return _usuarioActual; }
            set { _usuarioActual = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            ///// Listo mis equipos
            usuarioActual = (Usuario)HttpContext.Current.Session["loginUsuario"];
            List<EquipoUsuario> Misequipos = Consultar.ConsultarEquiposUsuario(new EquipoUsuario { IdUsuario = Master.usuarioActual.IdUsuario });
            string elemento_Misequipos = "<label for=\"fname\"> Mi Equipo(*):</label><select id=\"cmb_ConsultaJugadorWF_Equipo\" class=\"form-control\">";
            elemento_Misequipos += "<option value=\"" + 0 + "\">Seleccione</option>";
            foreach (EquipoUsuario equipo in Misequipos)
                elemento_Misequipos += "<option value=\"" + equipo.IdEquipoUsuario + "\">" + equipo.NombreEquipo + "</option>";
            elemento_Misequipos += "</select>";
            cmb_ComboEquipo.Controls.Add(new LiteralControl(elemento_Misequipos));

            ///// Listo los Torneos
            usuarioActual = (Usuario)HttpContext.Current.Session["loginUsuario"];
            List<Torneo> torneos = Consultar.ConsultarTorneo(new Torneo { IdEquipoUsuario = Master.usuarioActual.IdUsuario });
            string elemento_torneo = "<label for=\"fname\"> Torneo(*):</label><select id=\"cmb_ConsultaJugadorWF_Equipo\" class=\"form-control\">";
            elemento_torneo += "<option value=\"" + 0 + "\">Seleccione</option>";
            foreach (Torneo torneo in torneos)
                elemento_torneo += "<option value=\"" + torneo.IdTorneo + "\">" + torneo.NombreTorneo + "</option>";
            elemento_torneo += "</select>";
            cmb_Torneo.Controls.Add(new LiteralControl(elemento_torneo));

            ///// Listo los equipos Rivales
            usuarioActual = (Usuario)HttpContext.Current.Session["loginUsuario"];
            List<EquipoRival> equipos = Consultar.ConsultarEquipoRivalPorEquipoSeleccionado(new EquipoRival { IdEquipoUsuario = Master.usuarioActual.IdUsuario });
            string elemento_equipo = "<label for=\"fname\"> Equipo Rival(*):</label><select id=\"cmb_ConsultaJugadorWF_Equipo\" class=\"form-control\">";
            elemento_equipo += "<option value=\"" + 0 + "\">Seleccione</option>";
            foreach (EquipoRival equipo in equipos)
                elemento_equipo += "<option value=\"" + equipo.IdEquipoUsuario + "\">" + equipo.NombreEquipo + "</option>";
            elemento_equipo += "</select>";
            cmb_ComboEquipoRival.Controls.Add(new LiteralControl(elemento_equipo));

            ///// Listo Condiciones
            Hashtable tabla_condicion = Enumeraciones.Condicion();
            string elemento_condicion = "<label for=\"fname\">Condición:</label><select id=\"txt_AltaEtapaWF_Actividad_1_1\" class=\"form-control\">";
            foreach (DictionaryEntry elemento in tabla_condicion)
                elemento_condicion += "<option value=\"" + elemento.Key + "\">" + elemento.Value + "</option>";
            elemento_condicion += "</select>";
            cmb_ComboCondicion.Controls.Add(new LiteralControl(elemento_condicion));
        }


    }
}