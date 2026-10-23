using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaGestionEscolar.Migrations
{
    /// <inheritdoc />
    public partial class AgregarMaestro : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Maestro",
                columns: table => new
                {
                    maestroId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    maestroNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    maestroApellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    maestroEspecialidad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maestro", x => x.maestroId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Maestro");
        }
    }
}
