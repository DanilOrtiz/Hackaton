﻿using Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Dtos.Certificaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farsiman.CertificacionDigital.Aplicacion.CertificacionDigital.Servicios.Certificaciones
{
    public interface ICertificacionAplicacionService
    {
        void AgregarCertificacion(CertificacionAgregarDto nuevaCertificacion);
        List<CertificacionDto> ObtenerCertificacionActivas();

    }
}