using BoticarioApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BoticarioApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<AvaliacaoProduto> AVALIACOES_PRODUTOS { get; set; }
    public DbSet<Categoria> CATEGORIAS { get; set; }
    public DbSet<Cliente> CLIENTES { get; set; }
    public DbSet<Endereco> ENDERECOS { get; set; }
    public DbSet<Estoque> ESTOQUES { get; set; }
    public DbSet<ItemPedido> ITENS_PEDIDOS { get; set; }
    public DbSet<Loja> LOJAS { get; set; }
    public DbSet<Pagamento> PAGAMENTOS { get; set; }
    public DbSet<Pedido> PEDIDOS { get; set; }
    public DbSet<Produto> PRODUTOS { get; set; }
    public DbSet<Promocao> PROMOCOES { get; set; }
}
