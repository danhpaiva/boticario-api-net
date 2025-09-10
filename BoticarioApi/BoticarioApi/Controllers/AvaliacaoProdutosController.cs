using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BoticarioApi.Data;
using BoticarioApi.Models;

namespace BoticarioApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvaliacaoProdutosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AvaliacaoProdutosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/AvaliacaoProdutos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AvaliacaoProduto>>> GetAVALIACOES_PRODUTOS()
        {
            return await _context.AVALIACOES_PRODUTOS.ToListAsync();
        }

        // GET: api/AvaliacaoProdutos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AvaliacaoProduto>> GetAvaliacaoProduto(int id)
        {
            var avaliacaoProduto = await _context.AVALIACOES_PRODUTOS.FindAsync(id);

            if (avaliacaoProduto == null)
            {
                return NotFound();
            }

            return avaliacaoProduto;
        }

        // PUT: api/AvaliacaoProdutos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAvaliacaoProduto(int id, AvaliacaoProduto avaliacaoProduto)
        {
            if (id != avaliacaoProduto.Id)
            {
                return BadRequest();
            }

            _context.Entry(avaliacaoProduto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AvaliacaoProdutoExists(id))
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

        // POST: api/AvaliacaoProdutos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AvaliacaoProduto>> PostAvaliacaoProduto(AvaliacaoProduto avaliacaoProduto)
        {
            _context.AVALIACOES_PRODUTOS.Add(avaliacaoProduto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAvaliacaoProduto", new { id = avaliacaoProduto.Id }, avaliacaoProduto);
        }

        // DELETE: api/AvaliacaoProdutos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAvaliacaoProduto(int id)
        {
            var avaliacaoProduto = await _context.AVALIACOES_PRODUTOS.FindAsync(id);
            if (avaliacaoProduto == null)
            {
                return NotFound();
            }

            _context.AVALIACOES_PRODUTOS.Remove(avaliacaoProduto);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AvaliacaoProdutoExists(int id)
        {
            return _context.AVALIACOES_PRODUTOS.Any(e => e.Id == id);
        }
    }
}
