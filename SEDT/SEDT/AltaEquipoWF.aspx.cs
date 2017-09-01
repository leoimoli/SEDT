using SEDT.Controlador;
using SEDT.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services;
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
            }
        }

        //=============================================================
        //=============================================================

        [WebMethod]
        public static string GuardarDatos(EquipoUsuario obj)
        {
            //
            return "it worked";
        }

        //=============================================================
        //=============================================================

    }
}