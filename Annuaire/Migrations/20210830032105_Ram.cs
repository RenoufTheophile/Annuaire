using Microsoft.EntityFrameworkCore.Migrations;

namespace Annuaire.Migrations
{
    public partial class Ram : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Service",
                table: "Personne",
                newName: "service");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Personne",
                newName: "date");

            migrationBuilder.RenameColumn(
                name: "Telephone",
                table: "Personne",
                newName: "phone");

            migrationBuilder.RenameColumn(
                name: "Prenom",
                table: "Personne",
                newName: "last");

            migrationBuilder.RenameColumn(
                name: "Nom",
                table: "Personne",
                newName: "first");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "service",
                table: "Personne",
                newName: "Service");

            migrationBuilder.RenameColumn(
                name: "date",
                table: "Personne",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "phone",
                table: "Personne",
                newName: "Telephone");

            migrationBuilder.RenameColumn(
                name: "last",
                table: "Personne",
                newName: "Prenom");

            migrationBuilder.RenameColumn(
                name: "first",
                table: "Personne",
                newName: "Nom");
        }
    }
}
