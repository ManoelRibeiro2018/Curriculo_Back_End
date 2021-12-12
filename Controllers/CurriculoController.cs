using Curriculo.Model;
using Microsoft.AspNetCore.Mvc;

namespace Curriculo.Controllers
{
    [Route("api/curriculo")]
    public class CurriculoController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] CurriculoMain curriculo)
        {
            return Ok();
        }
    }
}
