using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using BoticarioApi.Enum;
using System.Text.Json.Serialization;

namespace BoticarioApi.Models;

public class Promocao
{
    [Key]
    public int Id { get; set; }
    [ForeignKey("Categoria")]
    public int? AplicaEmCategoriaId { get; set; }

    [ForeignKey("Produto")]
    public int? AplicaEmProdutoId { get; set; }

    [Required]
    [StringLength(100)]
    public string Nome { get; set; }

    public TipoDesconto TipoDesconto { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Valor { get; set; }

    public DateTime DataInicio { get; set; }

    public DateTime DataFim { get; set; }

    public bool Ativa { get; set; }
}
