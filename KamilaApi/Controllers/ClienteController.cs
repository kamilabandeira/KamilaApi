using KamilaApi.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KamilaApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        //public IActionResult Banana()
        //{
        //    return Ok("Banana");
        //}

        [HttpGet]
        public IActionResult Index()
        {
            var listaDeClientes = new List<Cliente>();

            for (int i = 0; i < 10; i++)
            {
                listaDeClientes.Add(new Cliente());
            }

            return Ok(listaDeClientes);
        }
    }
}
