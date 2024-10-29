using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebPostgreSQL.Models
{
    [Table("Paciente")]
    public class Paciente
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("Nome_Paciente")]
        [Display(Name = "Nome")]
        public string? Nome_Paciente { get; set; }

        [Column("Cpf_Paciente")]
        [Display(Name = "CPF")]
        public string? Cpf_Paciente { get; set; }

        [Column("Genero_Paciente")]
        [Display(Name = "Gênero")]
        public string? Genero_Paciente { get; set; }

        [Column("EstadoCivil_Paciente")]
        [Display(Name = "Estado Civil")]
        public string? EstadoCivil_Paciente { get; set; }

        [Column("Telefone_Paciente")]
        [Display(Name = "Telefone")]
        public string? Telefone_Paciente { get; set; }

        [Column("Email_Paciente")]
        [Display(Name = "Email")]
        public string? Email_Paciente { get; set; }

        [Column("CEP_Paciente")]
        [Display(Name = "CEP")]
        public string? CEP_Paciente { get; set; }

        [Column("UF_Paciente")]
        [Display(Name = "UF")]
        public string? UF_Paciente { get; set; }

        [Column("Cidade_Paciente")]
        [Display(Name = "Cidade")]
        public string? Cidade_Paciente { get; set; }

        [Column("Logradouro_Paciente")]
        [Display(Name = "Logradouro")]
        public string? Logradouro_Paciente { get; set; }

        [Column("Comorbidade_Paciente")]
        [Display(Name = "Comorbidade")]
        public string? Comorbidade_Paciente { get; set; }

        [Column("Alergia_Paciente")]
        [Display(Name = "Alergia")]
        public string? Alergia_Paciente { get; set; }

        [Column("UsoMedicamentos_Paciente")]
        [Display(Name = "Alergia")]
        public string? UsoMedicamentos_Paciente { get; set; }

        [Column("HistoricoCirurgias_Paciente")]
        [Display(Name = "Histórico de Cirurgias")]
        public string? HistoricoCirurgias_Paciente { get; set; }

        [Column("Gestacao_Paciente")]
        [Display(Name = "Gestação")]
        public string? Gestacao_Paciente { get; set; }

        [Column("TratamentoAnteriores_Paciente")]
        [Display(Name = "Tratamentos Anteriores")]
        public string? TratamentoAnteriores_Paciente { get; set; }

        // [Column("TratamentoAnteriores_Paciente")]
        // [Display(Name = "Tratamentos Anteriores")]
        // public string? TratamentoAnteriores_Paciente { get; set; }
    }
}