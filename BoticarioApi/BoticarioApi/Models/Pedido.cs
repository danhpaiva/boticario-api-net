using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using BoticarioApi.Enum;
using System.Text.Json.Serialization;

namespace BoticarioApi.Models;

public class Pedido
{
    [Key]
    public int Id { get; set; }

    [ForeignKey("Cliente")]
    public int ClienteId { get; set; }

    [ForeignKey("Endereco")]
    public int EnderecoEnvioId { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal ValorTotal { get; set; }

    public StatusPedido Status { get; set; }

    public DateTime DataCriacao { get; set; }

    public DateTime DataAtualizacao { get; set; }
}
