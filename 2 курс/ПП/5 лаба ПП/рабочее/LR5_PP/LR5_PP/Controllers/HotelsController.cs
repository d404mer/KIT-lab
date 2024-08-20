using LR5_PP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LR5_PP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private HotelsContext? _db;
        public HotelsController(HotelsContext hotelsContext)
        {
            _db = hotelsContext;
        }

        //// GET: api/<HotelsController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hotel>>> Get()
        {
            return await _db.Hotels.ToListAsync(); ;

        }
        // GET api/<HotelsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Hotel>> Get(int id)
        {
            Hotel hotel = await _db.Hotels.FirstOrDefaultAsync(x => x.Id == id);
            if (hotel == null)
                return NotFound();
            return new ObjectResult(hotel);
        }

        // POST api/<HotelsController>
        [HttpPost]
        public async Task<ActionResult<Hotel>> Post(Hotel hotel)
        {
            if (hotel == null)
            {
                return BadRequest();
            }
            _db.Hotels.Add(hotel);
            await _db.SaveChangesAsync();
            return Ok(hotel);
        }
        // PUT api/<HotelsController>/5

        [HttpPost("{id}")]

        public async Task<ActionResult<Hotel>> Put(Hotel hotel)
        {
            if (hotel == null)
            {
                return BadRequest();
            }
            if (!_db.Hotels.Any(x =>  x.Id == hotel.Id))
            {
                return NotFound();
            }
            _db.Update(hotel);
            await _db.SaveChangesAsync();
            return Ok(hotel);
        }
        // DELETE api/<HotelsController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Hotel>> Delete(int id)
        {
            Hotel hotel = _db.Hotels.FirstOrDefault(x => x.Id == id);
            if (hotel == null)
            {
                return NotFound();
            }
            _db.Hotels.Remove(hotel);
            await _db.SaveChangesAsync();
            return Ok(hotel); ;

        }




        }
    }
