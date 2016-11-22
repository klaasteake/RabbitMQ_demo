using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DeelnemerDatabase;
using DeelnemerAPI.Services;
using DeelnemerAPI.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace DeelnemerAPI.Controllers
{
    [Route("api/deelnemer")]
    public class DeelnemerController : Controller
    {
        private IDeelnemerContext _context;
        private IDeelnemerService _service;

        public DeelnemerController(IDeelnemerContext context, IDeelnemerService service)
        {
            _context = context;
            _service = service;
        }

        // GET: api/deelnemer
        [HttpGet]
        public IEnumerable<PersonCreated> Get()
        {
            return _context.Deelnemers;
        }

        // GET api/deelnemer/5
        [HttpGet("{id}")]
        public PersonCreated Get(int id)
        {
            return _context.Deelnemers.Single(deelnemer => deelnemer.Id == id);
        }

        // POST api/deelnemer
        [HttpPost]
        public IActionResult Post([FromBody] CreatePerson createPerson)
        {
            if(createPerson == null)
            {
                return BadRequest(new { Message = "Server kon verzonden bericht niet correct lezen"});
            }
            _service.Execute(createPerson);
            return Ok();       
        }

        // PUT api/deelnemer/5
        [HttpPut()]
        public IActionResult Put([FromBody] UpdatePerson updatePerson)
        {
            if (updatePerson == null)
            {
                return BadRequest(new { Message = "Server kon verzonden bericht niet correct lezen" });
            }
            _service.Execute(updatePerson);
            return Ok();
        }

        // DELETE api/deelnemer/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.Execute(new DeletePerson { Id = id });
            return Ok();
        }
    }
}
