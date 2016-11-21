using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DeelnemerDatabase;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace DeelnemerAPI.Controllers
{
    [Route("api/deelnemer")]
    public class DeelnemerController : Controller
    {
        private IDeelnemerContext _context;

        public DeelnemerController(IDeelnemerContext context)
        {
            _context = context;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<PersonCreated> Get()
        {
            return _context.Deelnemers;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public PersonCreated Get(int id)
        {
            return _context.Deelnemers.Single(deelnemer => deelnemer.Id == id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
