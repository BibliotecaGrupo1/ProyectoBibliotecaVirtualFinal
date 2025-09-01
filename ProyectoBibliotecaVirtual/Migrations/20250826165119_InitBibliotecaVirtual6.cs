using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoBibliotecaVirtual.Migrations
{
    /// <inheritdoc />
    public partial class InitBibliotecaVirtual6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LIBROS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOMBRE_LIBRO = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NOMBRE_AUTOR = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FECHA_PUBLICACION = table.Column<int>(type: "int", nullable: false),
                    GENERO_LIBRO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ESTADO_LIBRO = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LIBROS", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LIBROS");
        }
    }
}
