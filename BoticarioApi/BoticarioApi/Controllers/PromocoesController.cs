using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BoticarioApi.Data;
using BoticarioApi.Models;

namespace BoticarioApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromocoesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PromocoesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Promocoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Promocao>>> GetPROMOCOES()
        {
            return await _context.PROMOCOES.ToListAsync();
        }

        // GET: api/Promocoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Promocao>> GetPromocao(int id)
        {
            var promocao = await _context.PROMOCOES.FindAsync(id);

            if (promocao == null)
            {
                return NotFound();
            }

            return promocao;
        }

        // PUT: api/Promocoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPromocao(int id, Promocao promocao)
        {
            if (id != promocao.Id)
            {
                return BadRequest();
            }

            _context.Entry(promocao).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PromocaoExists(id))
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

        // POST: api/Promocoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Promocao>> PostPromocao(Promocao promocao)
        {
            _context.PROMOCOES.Add(promocao);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPromocao", new { id = promocao.Id }, promocao);
        }

        // DELETE: api/Promocoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePromocao(int id)
        {
            var promocao = await _context.PROMOCOES.FindAsync(id);
            if (promocao == null)
            {
                return NotFound();
            }

            _context.PROMOCOES.Remove(promocao);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PromocaoExists(int id)
        {
            return _context.PROMOCOES.Any(e => e.Id == id);
        }
    }
}
