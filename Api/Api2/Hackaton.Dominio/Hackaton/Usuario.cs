using Hackaton.Dominio.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Domain.Entities
{
    public class Usuario : Entidad
    {
        public string Nombre { get; set; }
        public byte[] Clave { get; set; }
        public int CiudadId { get; set; }
        public int PerfilId { get; set; }
        public string ImagenUrl { get; set; }
        public string Correo { get; set; }
       // public virtual Ciudad Ciudad { get; set; }
        public virtual Perfil Perfil { get; set; }

        public virtual List<Suceso> Sucesos { get; set; }
        public virtual List<SucesoComentario> SucesosComentarios { get; set; }
        public virtual List<SucesoValoracion> SucesosValoraciones { get; set; }
        public virtual List<Empresa> Empresas{ get; set; }

        public bool EsValido(ref string mensaje)
        {
            if (string.IsNullOrWhiteSpace(Nombre))
            {
                mensaje = "El nombre de usuario es necesario.";
                return false;
            }

            if (PerfilId == 0)
            {
                mensaje = "El perfil del usuario es requerido.";
                return false;
            }

            return true;
        }
    }
}