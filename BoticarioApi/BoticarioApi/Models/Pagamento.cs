using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using BoticarioApi.Enum;
using System.Text.Json.Serialization;

namespace BoticarioApi.Models;

public class Pagamento
{
    [Key]
    public int Id { get; set; }

    [ForeignKey("Pedido")]
    public int PedidoId { get; set; }

    public MetodoPagamento Metodo { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Valor { get; set; }

    public StatusPagamento Status { get; set; }

    public DateTime DataPagamento { get; set; }

    [StringLength(100)]
    public string CodigoTransacao { get; set; }
}
