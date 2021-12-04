using Dominio.Dto;
using Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces
{
    public interface IServiceCliente
    {

        Task<IEnumerable<Cliente>> GetCliente();
        DtoRespuesta GuardarCliente(Cliente cliente);
    }
}
