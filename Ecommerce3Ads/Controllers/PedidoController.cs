using Ecommerce3Ads.Context;
using Ecommerce3Ads.DTO;
using Ecommerce3Ads.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ecommerce3Ads.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public PedidoController()
        {
            _dataContext = new DataContext();
            
        }

        // GET: api/<PedidoController>
        [HttpGet]
        public ActionResult<List<Pedido>> Get()
        {
            var pedidos = _dataContext.Pedido.ToList<Pedido>();
            return pedidos;
        }

        // GET api/<PedidoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PedidoController>
        [HttpPost]
        public ActionResult<Pedido> Post([FromBody] Pedido pedido)
        {
            if (ModelState.IsValid)
            {
                _dataContext.Pedido.Add(pedido);
                _dataContext.SaveChanges();
                return pedido;
            }
            return BadRequest(ModelState);
        }

        // PUT api/<PedidoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PedidoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
