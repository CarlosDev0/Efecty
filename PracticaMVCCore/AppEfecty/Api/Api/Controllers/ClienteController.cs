using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        
        private readonly IServiceCliente _clienteService;

        public ClienteController(IServiceCliente clienteService) {
            _clienteService = clienteService;
        }
        
        [HttpGet]
        public async Task<IEnumerable<Cliente>> Get()
        {
            var respuesta = await _clienteService.GetCliente();
            return respuesta;
        }
    }
}
