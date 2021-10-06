using Microsoft.EntityFrameworkCore.Migrations;

namespace SeguimientoAcademico.App.Persistencia.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "genero",
                table: "Personas",
                newName: "Genero");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Genero",
                table: "Personas",
                newName: "genero");
        }
    }
}
