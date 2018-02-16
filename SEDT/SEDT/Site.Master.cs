using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Principal;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using System.Web.Services;
using SEDT.Modelo.Entidades;

namespace SEDT
{
    public partial class SiteMaster : MasterPage
    {
        private const string AntiXsrfTokenKey = "__AntiXsrfToken";
        private const string AntiXsrfUserNameKey = "__AntiXsrfUserName";
        private string _antiXsrfTokenValue;
        public Usuario usuarioActual { get; set; }

        protected void Page_Init(object sender, EventArgs e)
        {
            // The code below helps to protect against XSRF attacks
            var requestCookie = Request.Cookies[AntiXsrfTokenKey];
            Guid requestCookieGuidValue;
            if (requestCookie != null && Guid.TryParse(requestCookie.Value, out requestCookieGuidValue))
            {
                // Use the Anti-XSRF token from the cookie
                _antiXsrfTokenValue = requestCookie.Value;
                Page.ViewStateUserKey = _antiXsrfTokenValue;
            }
            else
            {
                // Generate a new Anti-XSRF token and save to the cookie
                _antiXsrfTokenValue = Guid.NewGuid().ToString("N");
                Page.ViewStateUserKey = _antiXsrfTokenValue;

                var responseCookie = new HttpCookie(AntiXsrfTokenKey)
                {
                    HttpOnly = true,
                    Value = _antiXsrfTokenValue
                };
                if (FormsAuthentication.RequireSSL && Request.IsSecureConnection)
                {
                    responseCookie.Secure = true;
                }
                Response.Cookies.Set(responseCookie);
            }

            if (HttpContext.Current.Session["loginUsuario"] == null) {
                usuarioActual = null;
                Response.Redirect("~/Login");
            }
            else
            {
                // Obtenemos el usuario de Sesión.
                usuarioActual = (Usuario)HttpContext.Current.Session["loginUsuario"];

                // Generamos el HTML con el contenido a mostrar.
                string usuario_html_top = "<img src=\"Template/production/images/user.png\" alt=\"\">";
                usuario_html_top += usuarioActual.Nombre + " " + usuarioActual.Apellido;
                usuario_html_top += "<span class=\"fa fa-angle-down\"></span>";

                string usuario_html_left = "<span>Bienvenido,</span>";
                usuario_html_left += "<h2>" + usuarioActual.Nombre + " " + usuarioActual.Apellido + "</h2>";

                // Insertamos el HTML dentro del DIV que corresponda.
                Master_Usuario_Top.Controls.Add(new LiteralControl(usuario_html_top));
                Master_Usuario_Left.Controls.Add(new LiteralControl(usuario_html_left));
            }
            Page.PreLoad += master_Page_PreLoad;
        }

        protected void master_Page_PreLoad(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Set Anti-XSRF token
                ViewState[AntiXsrfTokenKey] = Page.ViewStateUserKey;
                ViewState[AntiXsrfUserNameKey] = Context.User.Identity.Name ?? String.Empty;
            }
            else
            {
                // Validate the Anti-XSRF token
                if ((string)ViewState[AntiXsrfTokenKey] != _antiXsrfTokenValue
                    || (string)ViewState[AntiXsrfUserNameKey] != (Context.User.Identity.Name ?? String.Empty))
                {
                    throw new InvalidOperationException("Validation of Anti-XSRF token failed.");
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_LoggingOut(object sender, LoginCancelEventArgs e)
        {
            Context.GetOwinContext().Authentication.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
        }

        [WebMethod]
        public static void Desloguear()
        {
            HttpContext.Current.Session["loginUsuario"] = null;
        }
    }

}