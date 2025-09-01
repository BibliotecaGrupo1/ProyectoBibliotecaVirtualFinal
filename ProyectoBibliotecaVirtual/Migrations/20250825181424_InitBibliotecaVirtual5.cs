using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoBibliotecaVirtual.Migrations
{
    /// <inheritdoc />
    public partial class InitBibliotecaVirtual5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "USUARIOS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOMBRES = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    APELLIDOS = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NOMBRE_COMPLETO = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FECHA_NACIMIENTO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    USUARIO_EDAD = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USUARIOS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SESION_USUARIOS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    FECHA_REGISTRO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NOMBRE_USUARIO = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EMAIL = table.Column<string>(name: "E-MAIL", type: "nvarchar(max)", nullable: false),
                    CLAVE_USUARIO = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SESION_USUARIOS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SESION_USUARIOS_USUARIOS_ID",
                        column: x => x.ID,
                        principalTable: "USUARIOS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SESION_USUARIOS");

            migrationBuilder.DropTable(
                name: "USUARIOS");
        }
    }
}
