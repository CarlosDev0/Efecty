using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Dto
{
    public class DtoRecepcionCliente
    {
        public string nombreApellidos { get; set; }
        public string tipoDocumento { get; set; }
        public string fechaNacimiento { get; set; }
        public string valorGanar { get; set; }
        public string estadoCivil { get; set; }
    }
}
