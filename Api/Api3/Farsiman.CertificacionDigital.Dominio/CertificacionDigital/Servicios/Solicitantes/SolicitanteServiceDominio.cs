using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Solicitantes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Servicios.Solicitantes
{
    public class SolicitanteServiceDominio : ISolicitanteServiceDominio
    {


        public bool SonDatosValidos(Solicitante solicitante, out string mensajeError)
        {
            if (solicitante.Departamento.Activo == false)
            {
                mensajeError = "El departamento se encuentra desativado.";
                return false;

            }

            var esCorreoValido = Regex.IsMatch(solicitante.Correo,
                @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));


            if (esCorreoValido == false)
            {
                mensajeError = "El correo no tiene un formato valido.";
                return false;
            }



            mensajeError = "";
            return true;
        }

    }
}
