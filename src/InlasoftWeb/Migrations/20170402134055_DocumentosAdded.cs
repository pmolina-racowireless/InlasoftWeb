using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace InlasoftWeb.Migrations
{
    public partial class DocumentosAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Documentos",
                columns: table => new
                {
                    DocumentoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AbogadoId = table.Column<string>(nullable: true),
                    CasoId = table.Column<string>(nullable: true),
                    Comentario = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    DocumentoTipo = table.Column<string>(nullable: true),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Hora = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    LastModifiedDate = table.Column<DateTime>(nullable: true),
                    Path = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documentos", x => x.DocumentoId);
                    table.ForeignKey(
                        name: "FK_Documentos_Abogados_AbogadoId",
                        column: x => x.AbogadoId,
                        principalTable: "Abogados",
                        principalColumn: "AbogadoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Documentos_Casos_CasoId",
                        column: x => x.CasoId,
                        principalTable: "Casos",
                        principalColumn: "CasoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Documentos_AbogadoId",
                table: "Documentos",
                column: "AbogadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Documentos_CasoId",
                table: "Documentos",
                column: "CasoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Documentos");
        }
    }
}
