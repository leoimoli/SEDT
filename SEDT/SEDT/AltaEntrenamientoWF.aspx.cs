using SEDT.Controlador;
using SEDT.Modelo.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Web.Services;
using System.Web.UI;

namespace SEDT
{
    public partial class AltaEntrenamientoWF : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Hashtable tabla_actividad = Enumeraciones.Actividad_Entrenamiento();
            string elemento_actividad = "<label for=\"fname\">Tipo de Actividad:</label><select id=\"txt_AltaEtapaWF_Actividad_1_1\" class=\"form-control\">";
            foreach (DictionaryEntry elemento in tabla_actividad)
                elemento_actividad += "<option value=\"" + elemento.Key + "\">" + elemento.Value + "</option>";
            elemento_actividad += "</select>";

            Hashtable tabla_lugar = Enumeraciones.Lugar_Entrenamiento();
            string elemento_lugar = "<label for=\"fname\">Lugar de entrenamiento:</label><select class=\"form-control\">";                                                            
            foreach (DictionaryEntry elemento in tabla_lugar)
                elemento_lugar += "<option value=\"" + elemento.Key + "\">" + elemento.Value + "</option>";
            elemento_lugar += "</select>";

            List<EquipoUsuario> equipos = Consultar.ConsultarEquiposUsuario(new EquipoUsuario { IdUsuario = Master.usuarioActual.IdUsuario });
            string elemento_equipo = "<label for=\"fname\"> Equipo:</label><select class=\"form-control\">";
            foreach (EquipoUsuario equipo in equipos)
                elemento_equipo += "<option value=\"" + equipo.IdEquipoUsuario + "\">" + equipo.NombreEquipo + "</option>";
            elemento_equipo += "</select>";

            AltaEntrenamiento_ComboLugar.Controls.Add(new LiteralControl(elemento_actividad));
            AltaEntrenamiento_ComboActividad.Controls.Add(new LiteralControl(elemento_lugar));
            AltaEntrenamiento_ComboEquipo.Controls.Add(new LiteralControl(elemento_equipo));
        }

        [WebMethod]
        public static Respuesta GuardarDatos(Entrenamiento obj)
        {
            Respuesta resultado = new Respuesta();
            resultado.Exito = true;
            try
            {

                //resultado = Agregar.AltaEntrenamiento(obj);
            }
            catch (Exception e)
            {
                resultado.Exito = false;
                resultado.Errores = new List<string>();
                resultado.Errores.Add(e.Message);
            }
            return resultado;
        }
    }
}