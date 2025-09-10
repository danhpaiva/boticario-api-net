using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BoticarioApi.Models;

public class ItemPedido
{
    [Key]
    public int Id { get; set; }

    [ForeignKey("Pedido")]
    public int PedidoId { get; set; }

    [ForeignKey("Produto")]
    public int ProdutoId { get; set; }

    public int Quantidade { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal PrecoUnitario { get; set; }
}
