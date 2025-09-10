using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BoticarioApi.Models;

public class Cliente
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "O Nome é obrigatório")]
    public string Nome { get; set; }
    [Required(ErrorMessage = "O Email é obrigatório")]
    public string Email { get; set; }
    [Required(ErrorMessage = "A Senha é obrigatória")]
    public string Senha { get; set; }
    [Required(ErrorMessage = "O CPF é obrigatório")]
    [StringLength(14)]
    public string CPF { get; set; }
    [StringLength(20)]
    public string? Telefone { get; set; }
    public DateTime DataNascimento { get; set; }
    public DateTime DataCriacao { get; set; }
    public DateTime DataAtualizacao { get; set; }
    public bool Ativo { get; set; }
}
