using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BoticarioApi.Models;

public class AvaliacaoProduto
{
    [Key]
    public int Id { get; set; }

    [ForeignKey("Produto")]
    public int ProdutoId { get; set; }

    [ForeignKey("Cliente")]
    public int ClienteId { get; set; }

    [Range(1, 5)]
    public int Nota { get; set; }

    public string Comentario { get; set; }

    public DateTime DataCriacao { get; set; }
}
