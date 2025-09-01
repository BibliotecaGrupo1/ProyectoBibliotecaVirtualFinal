using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoBibliotecaVirtual.Migrations
{
    /// <inheritdoc />
    public partial class InitBibliotecaVirtual1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ADMINISTRADORES",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USER_ADMIN = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ADMIN_TAG = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ADMIN_ID = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FECHA_NACIMIENTO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FECHA_REGISTRO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ADMIN_EDAD = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    CLAVE_ADMIN = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ADMINISTRADORES", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ADMINISTRADORES");
        }
    }
}
