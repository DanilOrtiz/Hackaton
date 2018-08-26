using Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Dtos.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital
{
    public interface IUsuarioAplicacionService
    {
        void AgregarUsuario(UsuarioAgregarDto usuarioNuevo);
        void EditarUsuario(UsuarioEditDto usuarioEdit);
        List<UsuarioDto> ObtenerUsuariosActivos();
        List<UsuarioConPerilDto> ObtenerUsuariosProgramadores();
    }
}
