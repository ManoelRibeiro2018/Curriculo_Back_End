using Curriculo.Model;
using Microsoft.AspNetCore.Mvc;

namespace Curriculo.Controllers
{
    [Route("api/curriculo")]
    public class CurriculoController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }
        
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] CurriculoMain curriculo)
        {
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }

        
    }
}
