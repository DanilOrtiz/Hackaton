using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Departamentos;
using Farsiman.CertificacionDigital.Dominio.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.UENS
{
    public class UEN : Entidad
    {

        public UEN()
        { }

        public UEN(int usuarioAgregaId)
            : base(usuarioAgregaId)
        {
        }
        

        public string Descripcion { get; set; }
        public List<Departamento> Departamento { get; set; }

        public bool EsValido(ref string mensaje)
        {
            if (String.IsNullOrWhiteSpace(Descripcion))
            {
                mensaje = "La descripcion no puede quedar nula";
                return false;
            }

            if (Descripcion.Length > 80)
            {
                mensaje = "La descripcion sobrepasa el tamaño de 80 caracteres";
                return false;
            }

            return true;
        }



    }
}
