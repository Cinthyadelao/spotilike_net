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
    public class ArtistesController : ControllerBase
    {
        private readonly SpotilikeContext _context;

        public ArtistesController(SpotilikeContext context)
        {
            _context = context;
        }

        // GET: api/Artistes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Artiste>>> GetArtistes()
        {
            return await _context.Artistes.ToListAsync();
        }

        // GET: api/Artistes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Artiste>> GetArtiste(int id)
        {
            var artiste = await _context.Artistes.FindAsync(id);

            if (artiste == null)
            {
                return NotFound();
            }

            return artiste;
        }

        // PUT: api/Artistes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArtiste(int id, Artiste artiste)
        {
            if (id != artiste.Id)
            {
                return BadRequest();
            }

            _context.Entry(artiste).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArtisteExists(id))
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

        // POST: api/Artistes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Artiste>> PostArtiste(Artiste artiste)
        {
            _context.Artistes.Add(artiste);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetArtiste", new { id = artiste.Id }, artiste);
        }

        // DELETE: api/Artistes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArtiste(int id)
        {
            var artiste = await _context.Artistes.FindAsync(id);
            if (artiste == null)
            {
                return NotFound();
            }

            _context.Artistes.Remove(artiste);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ArtisteExists(int id)
        {
            return _context.Artistes.Any(e => e.Id == id);
        }
    }
}
