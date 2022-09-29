using FootballRest.Managers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FootballRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FootballsController : ControllerBase
    {
  
            private readonly FootballsManager _manager = new FootballsManager();
            // Get: api/<IPAsController>
            [ProducesResponseType(StatusCodes.Status200OK)]
            [HttpGet]
            public IEnumerable<FootballPlayerLibrary.Class1> Get()
            {
                return _manager.GetAll();
            }

            // Get: api/<IPAsController>/5
            [ProducesResponseType(StatusCodes.Status200OK)]
            [ProducesResponseType(StatusCodes.Status404NotFound)]
            [HttpGet("{id}")]
            public ActionResult<FootballPlayerLibrary.Class1> Get(int id)
            {
            FootballPlayerLibrary.Class1 footballPlayer = _manager.GetById(id);
                if (footballPlayer == null) return NotFound("No such class, id: " + "" + id);
                return Ok(footballPlayer);

            }

            // POST: api/<IPAsController>
            [ProducesResponseType(StatusCodes.Status201Created)]
            [HttpPost]
            public ActionResult<FootballPlayerLibrary.Class1> Post([FromBody] FootballPlayerLibrary.Class1 value)
            {
            FootballPlayerLibrary.Class1 footballPlayer = _manager.Add(value);
                return Ok(footballPlayer);
            }

            // PUT: api/<IPAsController>
            [ProducesResponseType(StatusCodes.Status200OK)]
            [ProducesResponseType(StatusCodes.Status404NotFound)]
            [HttpPut("{id}")]
            public ActionResult<FootballPlayerLibrary.Class1> Put(int id, [FromBody] FootballPlayerLibrary.Class1 value)
            {
            FootballPlayerLibrary.Class1 footballPlayer = _manager.Update(id, value);
                if (footballPlayer == null) return NotFound("There is no IPA on Id!" + " " + id);
                return Ok(value);
            }

            // DELETE api/<IPAsController>/5
            [ProducesResponseType(StatusCodes.Status200OK)]
            [ProducesResponseType(StatusCodes.Status404NotFound)]
            [HttpDelete("{id}")]
            public ActionResult<FootballPlayerLibrary.Class1> Delete(int id)
            {
            FootballPlayerLibrary.Class1 footballPlayer = _manager.Delete(id);
                if (footballPlayer == null) return NotFound("There is no IPA on Id" + " " + id);
                return Ok(footballPlayer);
            }
        }
}
