using Microsoft.EntityFrameworkCore.Migrations;

namespace Annuaire.Migrations
{
    public partial class Ram4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "page",
                table: "Personne",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "results",
                table: "Personne",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "seed",
                table: "Personne",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "version",
                table: "Personne",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "page",
                table: "Personne");

            migrationBuilder.DropColumn(
                name: "results",
                table: "Personne");

            migrationBuilder.DropColumn(
                name: "seed",
                table: "Personne");

            migrationBuilder.DropColumn(
                name: "version",
                table: "Personne");
        }
    }
}
