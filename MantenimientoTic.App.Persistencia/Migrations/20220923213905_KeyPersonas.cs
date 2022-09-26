using Microsoft.EntityFrameworkCore.Migrations;

namespace MantenimientoTic.App.Persistencia.Migrations
{
    public partial class KeyPersonas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Personas",
                newName: "PersonaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PersonaId",
                table: "Personas",
                newName: "Id");
        }
    }
}
