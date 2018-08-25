using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Servicios.Cifrado
{
    public interface ICifradoServicio
    {
        byte[] Cifrar(String texto);
    }
}
