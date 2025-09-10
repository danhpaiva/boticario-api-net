using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BoticarioApi.Data;
using BoticarioApi.Models;

namespace BoticarioApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemPedidosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ItemPedidosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/ItemPedidos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemPedido>>> GetITENS_PEDIDOS()
        {
            return await _context.ITENS_PEDIDOS.ToListAsync();
        }

        // GET: api/ItemPedidos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ItemPedido>> GetItemPedido(int id)
        {
            var itemPedido = await _context.ITENS_PEDIDOS.FindAsync(id);

            if (itemPedido == null)
            {
                return NotFound();
            }

            return itemPedido;
        }

        // PUT: api/ItemPedidos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutItemPedido(int id, ItemPedido itemPedido)
        {
            if (id != itemPedido.Id)
            {
                return BadRequest();
            }

            _context.Entry(itemPedido).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemPedidoExists(id))
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

        // POST: api/ItemPedidos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ItemPedido>> PostItemPedido(ItemPedido itemPedido)
        {
            _context.ITENS_PEDIDOS.Add(itemPedido);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetItemPedido", new { id = itemPedido.Id }, itemPedido);
        }

        // DELETE: api/ItemPedidos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItemPedido(int id)
        {
            var itemPedido = await _context.ITENS_PEDIDOS.FindAsync(id);
            if (itemPedido == null)
            {
                return NotFound();
            }

            _context.ITENS_PEDIDOS.Remove(itemPedido);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ItemPedidoExists(int id)
        {
            return _context.ITENS_PEDIDOS.Any(e => e.Id == id);
        }
    }
}
