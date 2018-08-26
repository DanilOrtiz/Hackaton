using Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Dtos.UENS;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.UENS;
using Farsiman.CertificacionDigital.Dominio.Core.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital
{
    public class UENSAplicacionesService : IUENSAplicacionService
    {

        private readonly IRepositorio<UEN> _uenRepositorio;


        public UENSAplicacionesService(IRepositorio<UEN> uenRepositorio)
        {

            _uenRepositorio = uenRepositorio;

        }

        public void AgregarUEN(Dtos.UENS.UENSAgregarDto uenNuevo)
        {
            var uen = uenNuevo.MapTo<UEN>();
            string mensaje = "";

            if (!uen.EsValido(ref mensaje))
            {

                uenNuevo.Respuesta = mensaje;
                return;
            }

            _uenRepositorio.Agregar(uen);
            _uenRepositorio.UnitOfWork.Commit();



        }

        public void EditarUEN(UENEditDto uenEdit)
        {
            var uen = (from u in _uenRepositorio.AsQueryable()
                       where u.Id == uenEdit.Id
                       select u).FirstOrDefault();

            uen.Descripcion = uenEdit.Descripcion;
            uen.Activo = uenEdit.Activo;

            _uenRepositorio.UnitOfWork.Commit();

        }

        public List<Dtos.UENS.UENSDto> ObtenerUENSActivos()
        {
            var uen = _uenRepositorio.ObtenerTodos();

            return (from u in uen
                    select new UENSDto
                    {
                        Descripcion = u.Descripcion,
                        Id = u.Id,
                        Activo = u.Activo,
                        FechaAgrega = u.FechaAgrega,
                        UsuarioAgregaId = 1
                    }).ToList();
        }
    }
}
