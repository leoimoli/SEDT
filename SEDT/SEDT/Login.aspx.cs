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
    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [WebMethod]
        public static Respuesta LoginUsuario(Usuario obj)
        {
            List<Modelo.Entidades.Usuario> usuarios = new List<Usuario>();
            Respuesta resultado = new Respuesta();
            try
            {
                usuarios = Consultar.LoginUsuario(obj);
                if (usuarios.Count == 0) { throw new Exception("El usuario ingresado/contraseña incorrecta."); }
                else
                {
                    HttpContext.Current.Session["loginUsuario"] = usuarios.First();
                    resultado.Exito = true;
                }
            }
            catch (Exception e)
            {
                resultado.Exito = false;
                resultado.Errores = new List<string>();
                resultado.Errores.Add(e.Message);
            }
            return resultado;
        }
        [WebMethod]
        public static Respuesta GuardarUsuario(Usuario obj)
        {
            Respuesta resultado = new Respuesta();
            try
            {
                resultado = Agregar.AltaUsuario(obj);
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