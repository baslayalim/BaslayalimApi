using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BaslayalimApi.Controllers.V1
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class ControlController : ControllerBase
    {
        // GET: api/<ControlController>
        [HttpGet]
        public string Get()
        {
            return "Api V1.0 True";
        }

        // GET api/<ControlController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ControlController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ControlController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ControlController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
