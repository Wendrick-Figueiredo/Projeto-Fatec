using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebPostgreSQL.Models
{
    [Table("Paciente")]
    public class Paciente
    {
        [Column("PacienteId")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("Nome_Paciente")]
        [Display(Name = "Nome do Paciente")]
        [Required]
        [MaxLength(100)] // Limite para nome do paciente
        public string? Nome_Paciente { get; set; }

        [Column("Cpf_Paciente")]
        [Display(Name = "CPF do Paciente")]
        [Required]
        [MaxLength(14)] // Limite para CPF
        public string? Cpf_Paciente { get; set; }

        [Column("DTNascimento_Paciente")]
        [Display(Name = "Data Nascimento do Paciente")]
        public DateTime? DTNascimento_Paciente { get; set; }

        [Column("Sexo_Paciente")]
        [Display(Name = "Sexo do Paciente")]
        [MaxLength(10)] // Limite para gênero
        public string? Sexo_Paciente { get; set; }

        [Column("Telefone_Paciente")]
        [Display(Name = "Telefone do Paciente")]
        [MaxLength(15)] // Limite para telefone (com DDD)
        public string? Telefone_Paciente { get; set; }

        [Column("EstadoCivil_Paciente")]
        [Display(Name = "Estado Civil")]
        [MaxLength(20)] // Limite para estado civil
        public string? EstadoCivil_Paciente { get; set; }

        [Column("UF_Paciente")]
        [Display(Name = "UF")]
        [MaxLength(2)] // Limite para UF
        public string? UF_Paciente { get; set; }

        [Column("CEP_Paciente")]
        [Display(Name = "CEP")]
        [MaxLength(9)] // Limite para CEP (sem hífen)
        public string? CEP_Paciente { get; set; }

        [Column("Municipio_Paciente")]
        [Display(Name = "Cidade")]
        [MaxLength(70)] // Limite para cidade
        public string? Cidade_Paciente { get; set; }

        [Column("Bairro_Paciente")]
        [Display(Name = "Bairro")]
        [MaxLength(100)] // Limite para bairro
        public string? Bairro_Paciente { get; set; }

        [Column("Logradouro_Paciente")]
        [Display(Name = "Logradouro")]
        [MaxLength(100)] // Limite para logradouro
        public string? Logradouro_Paciente { get; set; }

        [Column("Numero_Paciente")]
        [Display(Name = "Numero da Casa")]
        [MaxLength(8)] // Limite para número da casa
        public string? Numero_Paciente { get; set; }

        [ForeignKey("Usuario")]
        [Column("UsuarioId")]
        [Display(Name = "Usuario Responsavel Pelo Login")]
        public int UsuarioId { get; set; }  // Propriedade da chave estrangeira
    }
}
