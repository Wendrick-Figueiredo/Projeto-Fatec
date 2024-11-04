using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Projeto_Fatec.Migrations.ContextoConsultaMigrations
{
    /// <inheritdoc />
    public partial class Migrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Consulta",
                columns: table => new
                {
                    ConsultaId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descricao_Consulta = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: true),
                    Comodidade_Consulta = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: true),
                    Poblemas_Consulta = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    ExameClinico_Consulta = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    RaioX_Consulta = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    Tratamento_Consulta = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    DTConsulta_Consulta = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    MedicoId = table.Column<int>(type: "integer", nullable: false),
                    PacienteId = table.Column<int>(type: "integer", nullable: false),
                    UsuarioId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consulta", x => x.ConsultaId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Consulta");
        }
    }
}
