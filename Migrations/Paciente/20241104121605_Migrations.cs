using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Projeto_Fatec.Migrations.ContextoPacienteMigrations
{
    /// <inheritdoc />
    public partial class Migrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Paciente",
                columns: table => new
                {
                    PacienteId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome_Paciente = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Cpf_Paciente = table.Column<string>(type: "character varying(14)", maxLength: 14, nullable: false),
                    DTNascimento_Paciente = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Sexo_Paciente = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    Telefone_Paciente = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: true),
                    EstadoCivil_Paciente = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    UF_Paciente = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: true),
                    CEP_Paciente = table.Column<string>(type: "character varying(9)", maxLength: 9, nullable: true),
                    Municipio_Paciente = table.Column<string>(type: "character varying(70)", maxLength: 70, nullable: true),
                    Bairro_Paciente = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Logradouro_Paciente = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Numero_Paciente = table.Column<string>(type: "character varying(8)", maxLength: 8, nullable: true),
                    UsuarioId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paciente", x => x.PacienteId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paciente");
        }
    }
}
