using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaGestionEscolar.Migrations
{
    /// <inheritdoc />
    public partial class InitialCrate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estudiante",
                columns: table => new
                {
                    estudianteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    estudianteNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estudianteApellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estudianteCurso = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiante", x => x.estudianteId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estudiante");
        }
    }
}
