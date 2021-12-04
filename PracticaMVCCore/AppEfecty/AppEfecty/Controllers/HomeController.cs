using AppEfecty.Models;
using Dominio.Dto;
using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AppEfecty.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IServiceCliente _clienteService;
        
        public HomeController(IServiceCliente clienteService, ILogger<HomeController> logger)
        {
            _logger = logger;
            _clienteService = clienteService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ConsultaClientes() {
            return View();
        }
        public IActionResult GuardarCliente(DtoRecepcionCliente dtocliente)
        {

            Cliente clienteAGuardar = new Cliente();
            clienteAGuardar.estadoCivil = dtocliente.estadoCivil;
            clienteAGuardar.nombreApellidos = dtocliente.nombreApellidos;
            clienteAGuardar.tipoDocumento = dtocliente.tipoDocumento;
            clienteAGuardar.valorGanar = dtocliente.valorGanar;
            clienteAGuardar.fechaNacimiento = Convert.ToDateTime(dtocliente.fechaNacimiento);
            var respuesta = _clienteService.GuardarCliente(clienteAGuardar);
            
            if (respuesta != null)
            {
                if (respuesta.respuesta == 1)
                {
                    return Ok(dtocliente);
                }
                else
                {
                    return NotFound();
                }
            }
            else {
                return NotFound();
            }
            
        }
        
        public async Task<IEnumerable<Cliente>> ConsultarClientes()
        {
            var respuesta = await _clienteService.GetCliente();
            return respuesta;
        }
            public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
