using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoBibliotecaVirtual.Migrations
{
    /// <inheritdoc />
    public partial class InitBibliotecaVirtual4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "ADMINISTRADORES",
                newName: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "ADMINISTRADORES",
                newName: "id");
        }
    }
}
