using Appfor_thehotel.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Appfor_thehotel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        public PersonsController(DataContext contxt)
        {

        }

        // GET: api/<PersonsController>
        [HttpGet]
        public IEnumerable<Persons> Get()
        {
            return DataContext.allPersons;
        }

        // GET api/<PersonsController>/5
        [HttpGet("{id}")]
        public ActionResult<Persons> Get(int id)
        {
            Persons person = DataContext.allPersons.Find(p => p.idPerson == id);

            if (person == null)
            {
                return NotFound();
            }

            return Ok(person);
        }

        // POST api/<PersonsController>
        [HttpPost]
        public void Post([FromBody] Persons person)
        {
            DataContext.allPersons.Add(person); 
        }

        // PUT api/<PersonsController>/5
        [HttpPut("{id}")]
        public ActionResult<Persons> Put(int id, [FromBody] Persons p)
        {

            Persons person = DataContext.allPersons.Find(p => p.idPerson == id);

            if (person == null)
            {
                return NotFound();
            }

            person.name = p.name;
            person.fName = p.fName;
            person.numPhone = p.numPhone;

            return Ok(person);
        }

        // DELETE api/<PersonsController>/5
        [HttpDelete("{id}")]
        public ActionResult <Persons> Delete(int id)
        {
            Persons person = DataContext.allPersons.Find(p => p.idPerson == id);

            if (person == null)
            {
                return NotFound();
            }

            DataContext.allPersons.Remove(person);

            return NoContent();
        }
    }
}
