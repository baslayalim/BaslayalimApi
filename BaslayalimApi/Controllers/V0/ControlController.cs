using Microsoft.AspNetCore.Mvc;

namespace BaslayalimApi.Controllers.V0
{
    [ApiVersion("0.0")]
    [Route("api/[controller]")]
    [ApiController]
    public class ControlController : ControllerBase
    {
        // api/Control
        // GET: api/<ControlController>
        [HttpGet]
        public string Get()
        {
            return "Api Test True";
        }

        // api/Control/5
        // GET api/<ControlController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "Get value " + id;
        }

        // api/Control/ControlList?nameapp=Nam&surnameapp=SurN
        [HttpGet("ControlList")]
        public Models.V0.ControlClass Control(string nameapp, string surnameapp)
        {
            BaslayalimApi.Code.Basla bs = new Code.Basla();
            return new Models.V0.ControlClass
            {
                Name = "Name" + nameapp,
                SurName = "SurName" + surnameapp,
                NameSurName = bs.nameplussurname("Müslüm", "Gürses")
            };
        }

        // api/Control/
        // { "Name" : "Name 1",	"SurName" : "SurName 2",	"NameSurName" : "NameSurName 3" }
        // POST api/<ControlController>
        [HttpPost]
        public string Post([FromBody] Models.V0.ControlClass _ControlClass)
        {
            return "Post : " + _ControlClass.Name;
        }

        // api/Control/5
        // PUT api/<ControlController>/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] string value)
        {
            return "Put : " + id + " " + value;
        }

        // api/Control/77
        // DELETE api/<ControlController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return "Delete value" + id;
        }

    }
}
