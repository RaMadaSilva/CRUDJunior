using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDJunior.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aluno",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PrimeiroNome = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    UltimoNome = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    NomeCompleto_Id = table.Column<int>(type: "INTEGER", nullable: false),
                    CPF = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    CPF_Id = table.Column<int>(type: "INTEGER", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    Telefone = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Imagem = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aluno", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Assinatura",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AssinaturaId = table.Column<int>(type: "INTEGER", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    Inicio = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    Termino = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    Expirada = table.Column<bool>(type: "BIT", nullable: false),
                    AlunoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assinatura", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assinatura_Aluno_AssinaturaId",
                        column: x => x.AssinaturaId,
                        principalTable: "Aluno",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assinatura_AssinaturaId",
                table: "Assinatura",
                column: "AssinaturaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assinatura");

            migrationBuilder.DropTable(
                name: "Aluno");
        }
    }
}
