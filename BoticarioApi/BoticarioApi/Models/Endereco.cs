using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BoticarioApi.Models;

public class Endereco
{
    [Key]
    public int Id { get; set; }

    [ForeignKey("Cliente")]
    public int ClienteId { get; set; }

    [Required]
    [StringLength(150)]
    public string Logradouro { get; set; }

    [Required]
    [StringLength(10)]
    public string Numero { get; set; }

    [StringLength(50)]
    public string Complemento { get; set; }

    [Required]
    [StringLength(100)]
    public string Bairro { get; set; }

    [Required]
    [StringLength(100)]
    public string Cidade { get; set; }

    [Required]
    [StringLength(2)]
    public string Estado { get; set; }

    [Required]
    [StringLength(9)]
    public string Cep { get; set; }

    public bool Principal { get; set; }
}
