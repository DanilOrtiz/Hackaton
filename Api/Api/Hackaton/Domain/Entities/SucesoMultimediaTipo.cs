﻿using Hackaton.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackaton.Domain.Entities
{
    public class SucesoMultimediaTipo : Entidad
    {
        public string Nombre { get; set; }

        public virtual List<SucesoMultimedia> SucesosMultimedia { get; set; }
    }
}