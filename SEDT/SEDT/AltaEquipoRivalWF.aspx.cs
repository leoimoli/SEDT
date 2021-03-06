﻿using SEDT.Controlador;
using SEDT.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;

namespace SEDT
{
    public partial class AltaEquipoRivalWF : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        //=============================================================
        //=============================================================
        [WebMethod]
        public static Respuesta GuardarDatos(EquipoRival obj)
        {
            Respuesta resultado = new Respuesta();
            try
            {
                obj.IdUsuario = ((Usuario)HttpContext.Current.Session["loginUsuario"]).IdUsuario;
                resultado = Agregar.AltaEquipoRival(obj);
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