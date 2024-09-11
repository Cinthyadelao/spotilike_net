using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Spotilike;
using Spotilike.Models;

namespace Spotilike.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MorceauxController : ControllerBase
    {
        private readonly SpotilikeContext _context;

        public MorceauxController(SpotilikeContext context)
        {
            _context = context;
        }

        // GET: api/Morceaux
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Morceau>>> GetMorceaux()
        {
            return await _context.Morceaux.ToListAsync();
        }

        // GET: api/Morceaux/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Morceau>> GetMorceau(int id)
        {
            var morceau = await _context.Morceaux.FindAsync(id);

            if (morceau == null)
            {
                return NotFound();
            }

            return morceau;
        }

        // PUT: api/Morceaux/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMorceau(int id, Morceau morceau)
        {
            if (id != morceau.Id)
            {
                return BadRequest();
            }

            _context.Entry(morceau).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MorceauExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Morceaux
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Morceau>> PostMorceau(Morceau morceau)
        {
            _context.Morceaux.Add(morceau);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMorceau", new { id = morceau.Id }, morceau);
        }

        // DELETE: api/Morceaux/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMorceau(int id)
        {
            var morceau = await _context.Morceaux.FindAsync(id);
            if (morceau == null)
            {
                return NotFound();
            }

            _context.Morceaux.Remove(morceau);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MorceauExists(int id)
        {
            return _context.Morceaux.Any(e => e.Id == id);
        }
    }
}
