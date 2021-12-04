using Dominio.Dto;
using Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Interfaces
{
    public interface IBDRepository
    {
        IEnumerable<Cliente> ConsultarClientes();
        DtoRespuesta GuardarClientes(Cliente cliente);
    }
}
