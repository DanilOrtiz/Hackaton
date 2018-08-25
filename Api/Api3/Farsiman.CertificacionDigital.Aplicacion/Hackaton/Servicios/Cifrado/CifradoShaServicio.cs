using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Servicios.Cifrado
{
    public class CifradoShaServicio : ICifradoServicio
    {
        public byte[] Cifrar(string texto)
        {
            SHA1 sha = new SHA1CryptoServiceProvider();

            var textoEnBinario = System.Text.UTF8Encoding.ASCII.GetBytes(texto);

            return sha.ComputeHash(textoEnBinario);
        }
    }
}
