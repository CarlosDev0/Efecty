using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entities
{
    public class Cliente
    {
        public int IdPersona { get; set; }
        public string nombreApellidos { get; set; }
        public string tipoDocumento { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string valorGanar { get; set; }
        public string estadoCivil { get; set; }
        
    }
}
