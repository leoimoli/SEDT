using SEDT.Controlador;
using SEDT.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using System.Web.UI;

namespace SEDT
{
    public partial class AltaFichaTecnicaWF : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var idJugador = ((int) HttpContext.Current.Session["personaJugador"]);
            if (idJugador > 0)
            {
                PersonaFisicaJugador jugador = Consultar.JugadorPorID(idJugador);
                ApeNom_label.Text = jugador.Apellido + " " + jugador.Nombre;
                Apodo_label.Text = jugador.Apodo;
                DNI_label.Text = jugador.Dni;
                Telefono_label.Text = jugador.Telefono;
                imagenJugador.Src = jugador.Imagen;
            }
        }
        //=============================================================
        //=============================================================
        [WebMethod]
        public static Respuesta GuardarDatos(FichaTecnicaJugador obj)
        {
            Respuesta resultado = new Respuesta();
            try
            {
                obj.IdJugador = ((int)HttpContext.Current.Session["personaJugador"]);
                resultado = Agregar.AltaFichaTecnicaJugador(obj);
            }
            catch (Exception e)
            {
                resultado.Exito = false;
                resultado.Errores = new List<string>();
                resultado.Errores.Add(e.Message);
            }
            return resultado;
        }
        //=============================================================
        //=============================================================
    }
}