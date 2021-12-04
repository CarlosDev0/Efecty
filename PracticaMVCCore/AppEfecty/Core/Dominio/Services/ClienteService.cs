using Dominio.Dto;
using Dominio.Entities;
using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Services
{

    public class ClienteService : IServiceCliente
    {
        private readonly IBDRepository _clienteRepository;
        public ClienteService(IBDRepository prestamoRepository)
        {
            _clienteRepository = prestamoRepository;
        }
        public async Task<IEnumerable<Cliente>> GetCliente()
        {
            var respuesta =  _clienteRepository.ConsultarClientes();

            return respuesta;
        }

        public DtoRespuesta GuardarCliente(Cliente cliente)
        {
            var respuesta = _clienteRepository.GuardarClientes(cliente);
            
            return respuesta;
            
        }
    }
}
