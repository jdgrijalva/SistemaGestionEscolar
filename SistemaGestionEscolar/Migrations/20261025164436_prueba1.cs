using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaGestionEscolar.Migrations
{
    /// <inheritdoc />
    public partial class prueba1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Libros",
                columns: table => new
                {
                    libroId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    libroTitulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    libroAutor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    libroAnioPublicacion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libros", x => x.libroId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Libros");
        }
    }
}
