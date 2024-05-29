using Microsoft.AspNetCore.Mvc;
using Patient.Server.Service.API.Models;
using Patient.Server.Service.API.RequestModels;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Patient.Server.Service.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockOnHandController : ControllerBase
    {
        // POST api/<StockOnHandController>
        [HttpPost]
        [Route("stockOnHand")]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.OK)]
        public async Task<ActionResult> UpdateStockOnHand([FromBody] StockOnHandUpdateRequest request, CancellationToken ct = default)
        {
            var result = new StockOnHandUpdatedResponse
            {
                IsErrored = false,
                ErrorMessage = string.Empty
            };
            return Ok(result);
        }
    }
}
