using SEDT.Controlador;
using SEDT.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SEDT
{
    public partial class AltaEquipoWF : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Habilitar_Botones(true);
            }
        }

        protected void btnGuardar_OnClick(object sender, EventArgs e)
        {
            try
            {
                /*Respuesta respuesta = Agregar.AltaEquipoUsuario(new EquipoUsuario {
                    NombreEquipo = txAgregar_Equipo_Nombre.Text,
                    Siglas = txAgregar_Equipo_Siglas.Text,
                    SitioWeb = txAgregar_Equipo_SitioWeb.Text,
                    TelefonoDeContacto = txAgregar_Equipo_Telefono.Text
                });*/
                //Mensaje_Exito("asd");
                Habilitar_Campos(true);
                Habilitar_Botones(false);
                UpdatePanel_AltaEquipo.Update();
                // TODO: Mostrar mensaje según la respuesta.-
                // Falta chequear el tema de la imagen.-
            }
            catch (Exception ex)
            {
                // TODO: Mostrar mensaje según la respuesta.-
            }
        }

        protected void btnNuevo_OnClick(object sender, EventArgs e)
        {
            try
            {
                Limpiar_Campos();
                Habilitar_Campos(false);
                Habilitar_Botones(true);
                UpdatePanel_AltaEquipo.Update();
            }
            catch (Exception ex)
            {
                // TODO: Mostrar mensaje según la respuesta.-
            }
        }

        protected void btnLimpiar_OnClick(object sender, EventArgs e)
        {
            try
            {
                Limpiar_Campos();
                Habilitar_Botones(true);
                UpdatePanel_AltaEquipo.Update();
            }
            catch (Exception ex)
            {
                // TODO: Mostrar mensaje según la respuesta.-
            }
        }

        private void Habilitar_Campos(bool valor)
        {
            txAgregar_Equipo_Nombre.ReadOnly = valor;
            txAgregar_Equipo_Siglas.ReadOnly = valor;
            txAgregar_Equipo_SitioWeb.ReadOnly = valor;
            txAgregar_Equipo_Telefono.ReadOnly = valor;
        }

        private void Limpiar_Campos()
        {
            txAgregar_Equipo_Nombre.Text = string.Empty;
            txAgregar_Equipo_Siglas.Text = string.Empty;
            txAgregar_Equipo_SitioWeb.Text = string.Empty;
            txAgregar_Equipo_Telefono.Text = string.Empty;
        }

        private void Habilitar_Botones(bool valor)
        {
            btnGuardar.Visible = valor;
            btnLimpiar.Visible = valor;
            btnNuevo.Visible = !valor;
        }

        private void Mensaje_Exito(string valor)
        {
            // Define the name and type of the client scripts on the page.
            String csname1 = "PopupScript";
            Type cstype = this.GetType();

            StringBuilder cstext1 = new StringBuilder();
            cstext1.Append("<script type=text/javascript> alert('asdasd'); </");
            cstext1.Append("script>");

            // Get a ClientScriptManager reference from the Page class.
            ClientScriptManager cs = Page.ClientScript;
            cs.RegisterStartupScript(cstype, csname1, cstext1.ToString(), true);
        }
    }
}