using Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Dtos.Departamentos;
using Farsiman.CertificacionDigital.Dominio.CertificacionDigital.Entidades.Departamentos;
using Farsiman.CertificacionDigital.Dominio.Core.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Servicios.Departamentos
{
    public class DepartamentoAplicacionService : IDepartamentoAplicacionService
    {
        private readonly IRepositorio<Departamento> _departamentoRepositorio;

        public DepartamentoAplicacionService(IRepositorio<Departamento> departamentoRepositorio)
        {

            _departamentoRepositorio = departamentoRepositorio;

        }

        public void AgregarDepartamento(DepartamentoAgregarDto departamentoNuevo)
        {
            var departamento = departamentoNuevo.MapTo<Departamento>();

            string mensaje = "";


            if (!departamento.EsValido(ref mensaje))
            {
                departamentoNuevo.Respuesta = mensaje;
                departamentoNuevo.RespuestaTipo = Core.RespuestaTipo.Validacion;
                return;

            }

            _departamentoRepositorio.Agregar(departamento);
            _departamentoRepositorio.UnitOfWork.Commit();


            departamentoNuevo.Respuesta = "Ok";
            departamentoNuevo.RespuestaTipo = Core.RespuestaTipo.Ok;
        }

        public void EditarDepartamento(DepartamentoEditDto departamentoEdit)
        {
            var departamento = (from d in _departamentoRepositorio.AsQueryable()
                                where d.Id == departamentoEdit.Id
                                select d).FirstOrDefault();

            departamento.Descripcion = departamentoEdit.Descripcion;
            departamento.Activo = departamentoEdit.Activo;
            departamento.UENId = departamentoEdit.UENId;

            string mensaje="";

            if (!departamento.EsValido(ref mensaje))
            {

                departamentoEdit.Respuesta = mensaje;
                departamentoEdit.RespuestaTipo = Core.RespuestaTipo.Validacion;
                return;
            }

            _departamentoRepositorio.UnitOfWork.Commit();
            departamentoEdit.Respuesta = "Ok";
            departamentoEdit.RespuestaTipo = Core.RespuestaTipo.Ok;
        }

        public List<Dtos.Departamentos.DepartamentoDto> ObtenerDepartamentosActivos()
        {
            var departamento = _departamentoRepositorio.ObtenerTodos();

            return AutoMapper.Mapper.Map<List<DepartamentoDto>>(departamento);
        }
    }
}
