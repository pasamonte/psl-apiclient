﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasamonte.ApiClient.Core.Dto
{
    public class RespuestaValidarIdentificacion: RespuestaApi
    {
        public bool Validado { get; set; }
        public string Token { get; set; }
        public string Data { get; set; }
        public TypePacienteLight Paciente { get; set; }
    }
}
