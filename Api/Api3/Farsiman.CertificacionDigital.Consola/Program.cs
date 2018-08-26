using Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital;
using Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Dtos.Usuarios;
using Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Servicios.Login;
using Farsiman.CertificacionDigital.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farsiman.CertificacionDigital.Consola
{
    class Program
    {
        static void Main(string[] args)
        {

            //Login();
            AgregarUsuario();
        }


        private static void Login()
        {

            var credenciales = new UsuarioLoginDto()
            {
             Clave = "123",
             Correo = "maynor.fuentes@farsiman.com"

            };

            var loginServicio = Contenedor.Resolve<ILoginServiceAplicacion>();

            loginServicio.SonCredencialesValidas(credenciales);

            Console.WriteLine(credenciales.Respuesta);
            Console.ReadKey();
        
        }

        private static void AgregarUsuario()
        {
            //var usuariosServicio = Contenedor.Resolve<IUsuarioAplicacionService>();
            //var usuarionuevo = new UsuarioAgregarDto()
            //{
            //    Nombre = "Maynor",
            //    Apellido = "Fuentes",
            //    Clave = "123",
            //    PerfilId = 2,
            //    CorreoElectronico = "maynor.fuentes@farsiman.com",
            //    CodigoColaborador = 4246

            //};

            //usuariosServicio.AgregarUsuario(usuarionuevo);
                    
        }
    }
}
