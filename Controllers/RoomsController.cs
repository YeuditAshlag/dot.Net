using Appfor_thehotel.Controllers.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Appfor_thehotel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        private static List<Rooms> roomList = new List<Rooms>();
        // GET: api/<RoomsController>
        [HttpGet]
        public IEnumerable<Rooms> Get()
        {
            return roomList;
        }

        // GET api/<RoomsController>/5
        [HttpGet("{id}")]
        public ActionResult<Rooms> Get(int id)
        {
            Rooms room = roomList.Find(p => p.idRoom == id);

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
            roomList.Add(room);
        }

        // PUT api/<RoomsController>/5
        [HttpPut("{id}")]
        public ActionResult <Rooms> Put(int id, [FromBody] Rooms r)
        {
            Rooms room = roomList.Find(p => p.idRoom == id);

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
            Rooms room = roomList.Find(p => p.idRoom == id);
            if (room == null)
            {
                NotFound();
            }
            else
            {
                roomList.Remove(room);
                //room.numOfBeds--;
                room.IsFilled = true;
            }
        }
    }
}
