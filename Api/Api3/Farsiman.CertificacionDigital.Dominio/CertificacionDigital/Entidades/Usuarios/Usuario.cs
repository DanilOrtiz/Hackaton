using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades;
using Farsiman.CertificacionDigital.Dominio.Core;
//using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Solicitantes;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Proyectos;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Solicitantes;

namespace Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Usuarios
{
    public class Usuario : Entidad
    {

        public Usuario()
        { }

        public Usuario(int usuarioAgregaId)
            : base(usuarioAgregaId)
        {
        }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public byte[] Clave { get; set; }
        public int CodigoColaborador { get; set; }
        public string CorreoElectronico { get; set; }
        public int PerfilId { get; set; }
        //public virtual Perfil Perfil { get; set; }
        public List<Solicitante> Solicitante { get; set; }
        public List<Proyecto> Proyecto { get; set; }

        public bool EsValido(ref string mensaje)
        {

            if (string.IsNullOrWhiteSpace(Nombre))
            {
                mensaje = "El nombre es requerido";
                return false;
            }

            if (string.IsNullOrWhiteSpace(Apellido))
            {
                mensaje = "El apellido es requerido;";
                return false;
            }

            if (CodigoColaborador <= 0)
            {
                mensaje = "El códgio del colaborador es invalido";
                return false;
            }

            if (string.IsNullOrWhiteSpace(CorreoElectronico))
            {
                mensaje = "El correo electrónico";
                return false;
            }

            if (PerfilId <= 0)
            {
                mensaje = "El perfil es invalido";
                return false;
            }

            return true;
        }
        public bool EsClaveValida(byte[] claveComparar)
        {
            string claveLocal = HasToString(Clave);
            string claveString = HasToString(claveComparar);

            return claveLocal == claveString;
        }

      string HasToString(byte[] hash)
        {
            return string.Join("", hash.Select(b => b.ToString("x2")).ToArray());
        }

    }

 

}
