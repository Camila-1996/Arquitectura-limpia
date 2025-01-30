using APIPrj.Application.Interfaces.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace APIPrj.WebApi.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturaController : ControllerBase
    {
        private readonly IFacturaRepository _facturaRepository;
        public FacturaController(IFacturaRepository facturaRepository)
        {
            _facturaRepository = facturaRepository;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFactura(int id)
        {
            var factura = await _facturaRepository.GetByIdAsync(id);
            if (factura == null) return NotFound();
            return Ok(factura);
        }
    }
}
