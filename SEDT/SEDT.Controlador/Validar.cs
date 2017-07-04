using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEDT.Modelo.Entidades;
using SEDT.Modelo.DAO;

namespace SEDT.Controlador
{
    public static class Validar
    {
        public static Respuesta AltaEquipoUsuario(EquipoUsuario equipo)
        {
            Respuesta respuesta = new Respuesta();
            respuesta.Errores = new List<string>();
            if (String.IsNullOrEmpty(equipo.NombreEquipo))
            {
                respuesta.Errores.Add("El nombre del equipo es dato obligatorio.");
                respuesta.Exito = false;
            }

            bool ValidarAltaEquipoUsuarioExistente = ConsultarDAO.ValidarAltaEquipoUsuarioExistente(equipo);
            if (ValidarAltaEquipoUsuarioExistente == true)
            {
                respuesta.Errores.Add("Ya existe para el usuario logueado un equipo con el mismo nombre ingresado.");
                respuesta.Exito = false;
            }
            return respuesta;
        }
    }
}
