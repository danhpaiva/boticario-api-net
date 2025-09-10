using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BoticarioApi.Models;

public class Loja
{
    [Key]
    public int Id { get; set; }
    [ForeignKey("Endereco")]
    public int EnderecoId { get; set; }

    [Required]
    [StringLength(100)]
    public string Nome { get; set; }

    [StringLength(20)]
    public string Telefone { get; set; }

    public bool Ativo { get; set; }
}
