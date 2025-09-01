using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoBibliotecaVirtual.Migrations
{
    /// <inheritdoc />
    public partial class InitBibliotecaVirtual7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ESTADO_LIBRO",
                table: "LIBROS");

            migrationBuilder.DropColumn(
                name: "GENERO_LIBRO",
                table: "LIBROS");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ESTADO_LIBRO",
                table: "LIBROS",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GENERO_LIBRO",
                table: "LIBROS",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
