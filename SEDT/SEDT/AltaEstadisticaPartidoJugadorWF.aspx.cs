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
    public partial class AltaEstadisticaPartidoJugadorWF : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var idPartido = ((int)HttpContext.Current.Session["AltaEstadisticaPartido"]);
            if (idPartido > 0)
            {
                Partido partido = Consultar.BuscarDatosPartidoPorId(idPartido);
                //ApeNom_label.Text = jugador.Apellido + ", " + jugador.Nombre;
                //Apodo_label.Text = jugador.Apodo;
                //DNI_label.Text = jugador.Dni;
                //Telefono_label.Text = jugador.Telefono;
                //imagenJugador.Src = jugador.Imagen;
            }
        }
    }
}