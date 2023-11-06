using Appfor_thehotel.Controllers.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Appfor_thehotel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatesController : ControllerBase
    {
        private static List<Dates> dateList= new List<Dates>();
        // GET: api/<DatesController>
        [HttpGet]
        public IEnumerable<Dates> Get()
        {
            return dateList;
        }

        // GET api/<DatesController>/5
        [HttpGet("{id}")]
        public ActionResult<Dates> Get(DateTime start)
        {
            Dates date = dateList.Find(p => p.start ==start);

            if (date == null)
            {
                return NotFound();
            }

            return Ok(start);
        }

        // POST api/<DatesController>
        [HttpPost]
        public void Post([FromBody] DateTime start,DateTime end)
        {
            dateList.Add(new Dates(start,end));
        }

        // PUT api/<DatesController>/5
        [HttpPut("{id}")]
        //public ActionResult<Dates> Put(List<Persons> allpersons, int id, [FromBody] Dates date)
        //{
        //    Persons person = allpersons.Find(p => p.idPerson == id);

        //    if (id == null)
        //    {
        //        return NotFound();
        //    }
        //    allpersons[id].time = date;
        //    dateList.Add(date);
        //    date.IsCatch = true;

        //    return Ok(date);
        //}

        // DELETE api/<DatesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            
        }
    }
}
