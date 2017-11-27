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
    public partial class ConsultaPartidoWF : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            }
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