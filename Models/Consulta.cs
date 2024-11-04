using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebPostgreSQL.Models
{
    [Table("Consulta")]
    public class Consulta
    {
        [Column("ConsultaId")]
        [Display(Name = "Código")]
        public int ConsultaId { get; set; }

        [Column("Descricao_Consulta")]
        [Display(Name = "Descrição ou Queixa")]
        [MaxLength(300)]
        public string? Descricao_Consulta { get; set; }

        [Column("Comodidade_Consulta")]
        [Display(Name = "Comodidade do Paciente")]
        [MaxLength(300)]
        public string? Comodidade_Consulta { get; set; }

        [Column("Poblemas_Consulta")]
        [Display(Name = "Problemas Pos Consulta")]
        [MaxLength(500)]
        public string? Poblemas_Consulta { get; set; }

        [Column("ExameClinico_Consulta")]
        [Display(Name = "Exames do Paciente")]
        [MaxLength(500)]
        public string? ExameClinico_Consulta { get; set; }

        [Column("RaioX_Consulta")]
        [Display(Name = "RaioX do Paciente")]
        [MaxLength(500)]
        public string? RaioX_Consulta { get; set; }

        [Column("Tratamento_Consulta")]
        [Display(Name = "Tratamento Pos Consulta")]
        [MaxLength(500)]
        public string? Tratamento_Consulta { get; set; }

        [Column("DTConsulta_Consulta")]
        [Display(Name = "Data Da Consulta Do Paciente")]
        public DateTime? DTConsulta_Consulta { get; set; }

        [ForeignKey("Medico")]
        [Column("MedicoId")]
        [Display(Name = "Médico Responsável")]
        public int MedicoId { get; set; }  // Propriedade da chave estrangeira

        [ForeignKey("Paciente")]
        [Column("PacienteId")]
        [Display(Name = "Codigo do Paciente")]
        public int PacienteId { get; set; }  // Propriedade da chave estrangeira

        [ForeignKey("Usuario")]
        [Column("UsuarioId")]
        [Display(Name = "Usuario Responsavel Pelo Login")]
        public int UsuarioId { get; set; }  // Propriedade da chave estrangeira
    }
}
