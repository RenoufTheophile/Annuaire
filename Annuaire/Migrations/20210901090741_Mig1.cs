using Microsoft.EntityFrameworkCore.Migrations;

namespace Annuaire.Migrations
{
    public partial class Mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personne_Info_infoseed",
                table: "Personne");

            migrationBuilder.DropForeignKey(
                name: "FK_Result_Name_nametitle",
                table: "Result");

            migrationBuilder.DropForeignKey(
                name: "FK_Result_Registered_registereddate",
                table: "Result");

            migrationBuilder.RenameColumn(
                name: "registereddate",
                table: "Result",
                newName: "RegisteredDate");

            migrationBuilder.RenameColumn(
                name: "nametitle",
                table: "Result",
                newName: "NameTitle");

            migrationBuilder.RenameIndex(
                name: "IX_Result_registereddate",
                table: "Result",
                newName: "IX_Result_RegisteredDate");

            migrationBuilder.RenameIndex(
                name: "IX_Result_nametitle",
                table: "Result",
                newName: "IX_Result_NameTitle");

            migrationBuilder.RenameColumn(
                name: "last",
                table: "Personne",
                newName: "Last");

            migrationBuilder.RenameColumn(
                name: "infoseed",
                table: "Personne",
                newName: "InfoSeed");

            migrationBuilder.RenameIndex(
                name: "IX_Personne_infoseed",
                table: "Personne",
                newName: "IX_Personne_InfoSeed");

            migrationBuilder.AddColumn<string>(
                name: "PersonneService",
                table: "Personne",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SearchString",
                table: "Personne",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Personne_Info_InfoSeed",
                table: "Personne",
                column: "InfoSeed",
                principalTable: "Info",
                principalColumn: "seed",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Result_Name_NameTitle",
                table: "Result",
                column: "NameTitle",
                principalTable: "Name",
                principalColumn: "title",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Result_Registered_RegisteredDate",
                table: "Result",
                column: "RegisteredDate",
                principalTable: "Registered",
                principalColumn: "date",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personne_Info_InfoSeed",
                table: "Personne");

            migrationBuilder.DropForeignKey(
                name: "FK_Result_Name_NameTitle",
                table: "Result");

            migrationBuilder.DropForeignKey(
                name: "FK_Result_Registered_RegisteredDate",
                table: "Result");

            migrationBuilder.DropColumn(
                name: "PersonneService",
                table: "Personne");

            migrationBuilder.DropColumn(
                name: "SearchString",
                table: "Personne");

            migrationBuilder.RenameColumn(
                name: "RegisteredDate",
                table: "Result",
                newName: "registereddate");

            migrationBuilder.RenameColumn(
                name: "NameTitle",
                table: "Result",
                newName: "nametitle");

            migrationBuilder.RenameIndex(
                name: "IX_Result_RegisteredDate",
                table: "Result",
                newName: "IX_Result_registereddate");

            migrationBuilder.RenameIndex(
                name: "IX_Result_NameTitle",
                table: "Result",
                newName: "IX_Result_nametitle");

            migrationBuilder.RenameColumn(
                name: "Last",
                table: "Personne",
                newName: "last");

            migrationBuilder.RenameColumn(
                name: "InfoSeed",
                table: "Personne",
                newName: "infoseed");

            migrationBuilder.RenameIndex(
                name: "IX_Personne_InfoSeed",
                table: "Personne",
                newName: "IX_Personne_infoseed");

            migrationBuilder.AddForeignKey(
                name: "FK_Personne_Info_infoseed",
                table: "Personne",
                column: "infoseed",
                principalTable: "Info",
                principalColumn: "seed",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Result_Name_nametitle",
                table: "Result",
                column: "nametitle",
                principalTable: "Name",
                principalColumn: "title",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Result_Registered_registereddate",
                table: "Result",
                column: "registereddate",
                principalTable: "Registered",
                principalColumn: "date",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
