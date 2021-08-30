using Microsoft.EntityFrameworkCore.Migrations;

namespace Annuaire.Migrations
{
    public partial class Ram2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "age",
                table: "Personne",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "title",
                table: "Personne",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "age",
                table: "Personne");

            migrationBuilder.DropColumn(
                name: "title",
                table: "Personne");
        }
    }
}
