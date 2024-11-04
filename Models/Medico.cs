using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebPostgreSQL.Models
{
    [Table("Medico")]
    public class Medico
    {
        [Column("MedicoId")]
        [Display(Name ="Código")]
        public int MedicoId { get; set; }

        [Column("CROSP_Medico")]
        [Display(Name = "CROSP")]
        [Required]
        [MaxLength(20)] 
        public string? CROSP_Medico  { get; set; }

        [Column("Nome_Medico")]
        [Display(Name = "Nome do Medico")]
        [Required]
        [MaxLength(100)]
        public string? Nome_Medico  { get; set; }
    }
}
