using Microsoft.AspNetCore.Mvc;
using System.Security.Policy;
using WellHeader.Entities;

namespace WellHeader.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FieldsController : ControllerBase
    {

        private readonly ILogger<WellsController> _logger;
        
        public FieldsController(ILogger<WellsController> logger)
        {
            _logger = logger;
        }


        // GET: /Fields
        [HttpGet]
        public IEnumerable<Field> Get()
        {
            List<Field> fields = new List<Field>();
            Field f1 = new Field();
            f1.FieldName = "Name 1";
            f1.FieldID = 1;

            Field f2 = new Field();
            f2.FieldName = "Name 2";
            f2.FieldID = 2;


            fields.Add(f1);
            fields.Add(f2);
            return fields;
        }

        // GET Fields/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<FieldsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<FieldsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FieldsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
