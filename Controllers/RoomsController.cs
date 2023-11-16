using Appfor_thehotel.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Appfor_thehotel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {

        public RoomsController (DataContext contxt)
        {

        }
        // GET: api/<RoomsController>
        [HttpGet]
        public IEnumerable<Rooms> Get()
        {
            return DataContext.roomList;
        }

        // GET api/<RoomsController>/5
        [HttpGet("{id}")]
        public ActionResult<Rooms> Get(int id)
        {
            Rooms room = DataContext.roomList.Find(p => p.idRoom == id);

            if (room == null)
            {
                return NotFound();
            }

            return Ok(room);
        }

        // POST api/<RoomsController>
        [HttpPost]
        public void Post([FromBody] Rooms room)
        {
            DataContext.roomList.Add(room);
        }

        // PUT api/<RoomsController>/5
        [HttpPut("{id}")]
        public ActionResult <Rooms> Put(int id, [FromBody] Rooms r)
        {
            Rooms room = DataContext.roomList.Find(p => p.idRoom == id);

            if (room == null)
            {
                return NotFound();
            }

            room.idRoom = r.idRoom;
            room.numOfBeds = r.numOfBeds;
            room.IsFilled = r.IsFilled;

            return Ok(room);
        }

        // DELETE api/<RoomsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Rooms room = DataContext.roomList.Find(p => p.idRoom == id);
            if (room == null)
            {
                NotFound();
            }
            else
            {
                DataContext.roomList.Remove(room);
                //room.numOfBeds--;
                room.IsFilled = true;
            }
        }
    }
}
