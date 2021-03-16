using KamilaApi.Model;
using Microsoft.AspNetCore.Http;
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

        [HttpPost]
        //public ActionResult Create(IFormCollection collection)
        public ActionResult Create(string parametro)
        {
            
            return Ok(parametro);
        }

        [HttpPut]
        public ActionResult Inserir(int id)
        {
            var retorno = "";
            try
            {
                retorno = "entrei no try";
            
            }
            catch
            {
                retorno = "entrei no catch";
            }

            return Ok(retorno);
        }


        [HttpDelete]
        public ActionResult Delete(int id)
        {
            return Ok("DELETE OK");
        }
       
    }
}
