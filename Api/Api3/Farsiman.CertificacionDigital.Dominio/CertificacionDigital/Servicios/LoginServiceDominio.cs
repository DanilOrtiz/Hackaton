using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Servicios
{
    public  class LoginServiceDominio : ILoginServiceDominio
    {
        public  bool SonCredencialesValidas(Entidades.Usuarios.Usuario usuario, byte[] clave, out string mensajeError)
        {
            if (usuario == null)
            {
                mensajeError = "El usuario es requerido";
                return false;
            }

            if (!usuario.Activo)
            {
                mensajeError = "El usuario no está activo";
                return false;
            }

            if (clave == null)
            {
                mensajeError = "La clave es requerida";
                return false;
            }

            if (!usuario.EsClaveValida(clave))
            {
                mensajeError = "Credenciales invalidas";
                return false;
            }


            mensajeError = "OK";
            return true;
        }
    }
}
