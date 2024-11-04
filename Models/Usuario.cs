using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebPostgreSQL.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Column("UsuarioId")]
        [Display(Name ="Código")]
        public int UsuarioId { get; set; }

        [Column("Nome_Usuario")]
        [Display(Name = "Nome")]
        public string? Nome_Usuario  { get; set; }

        [Column("Senha_Usuario")]
        [Display(Name = "Senha")]
        public string? Senha_Usuario  { get; set; }

        [Column("Nivel_Acesso")]
        [Display(Name = "Nivel Acesso")]
        public string? Nivel_Acesso  { get; set; }
    }
}
