using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectWebAPI.Data;

namespace ProjectWebAPI.Controllers
{
    // htttps://localhost:7184/api/Cliente
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {

        private readonly ApplicationDBContext dbContext;

        public ClienteController(ApplicationDBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetClientes()
        {

            var clientes = dbContext.Clientes.ToList();
            // 200
            return Ok(clientes);

        }

        [HttpGet]
        [Route("{id:guid}")]
        public IActionResult GetClienteById(Guid id) {
            var cliente = dbContext.Clientes.Find(id);

            if (cliente is null)
            {
                return NotFound();
            }

            return Ok(cliente);
        }


    }
}
