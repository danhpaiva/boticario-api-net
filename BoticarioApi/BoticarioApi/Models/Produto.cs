using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BoticarioApi.Models;

public class Produto
{
    [Key]
    public int Id { get; set; }
    [ForeignKey("Categoria")]
    public int CategoriaId { get; set; }

    [Required]
    [StringLength(100)]
    public string Nome { get; set; }

    [StringLength(500)]
    public string Descricao { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Preco { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal PesoKg { get; set; }

    public bool Ativo { get; set; }

    public DateTime DataCriacao { get; set; }

    public DateTime DataAtualizacao { get; set; }
}
