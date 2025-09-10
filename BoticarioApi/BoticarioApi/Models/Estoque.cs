using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BoticarioApi.Models;

public class Estoque
{
    [Key]
    public int Id { get; set; }

    [ForeignKey("Produto")]
    public int ProdutoId { get; set; }

    [ForeignKey("Loja")]
    public int LojaId { get; set; }

    public int Quantidade { get; set; }

    public DateTime DataUltimaAtualizacao { get; set; }
}
