using SEDT.Controlador;
using SEDT.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SEDT
{
    public partial class AltaEquipoWF : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_OnClick(object sender, EventArgs e)
        {
            try
            {
                Respuesta respuesta = Agregar.AltaEquipoUsuario(new EquipoUsuario {
                    NombreEquipo = txAgregar_Equipo_Nombre.Text,
                    Siglas = txAgregar_Equipo_Siglas.Text,
                    SitioWeb = txAgregar_Equipo_SitioWeb.Text,
                    TelefonoDeContacto = txAgregar_Equipo_Telefono.Text
                });
                // TODO: Mostrar mensaje según la respuesta.-
                // Falta chequear el tema de la imagen.-
            }
            catch (Exception ex)
            {
                // TODO: Mostrar mensaje según la respuesta.-
            }
        }
    }
}