using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Usuario")]
public class Usuario
{
    [Column("Id")]
    [Display(Name = "Codigo")]
    public int Id { get; set; }

    [Column("Nome")]
    [Display(Name = "Nome")]
    public string Nome { get; set; }
}