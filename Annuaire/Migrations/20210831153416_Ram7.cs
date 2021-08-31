using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Annuaire.Migrations
{
    public partial class Ram7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personne_Root_rootIdRoot",
                table: "Personne");

            migrationBuilder.DropForeignKey(
                name: "FK_Result_Personne_personneId",
                table: "Result");

            migrationBuilder.DropForeignKey(
                name: "FK_Result_Root_RootIdRoot",
                table: "Result");

            migrationBuilder.DropTable(
                name: "Root");

            migrationBuilder.DropIndex(
                name: "IX_Result_RootIdRoot",
                table: "Result");

            migrationBuilder.DropIndex(
                name: "IX_Personne_rootIdRoot",
                table: "Personne");

            migrationBuilder.DropColumn(
                name: "RootIdRoot",
                table: "Result");

            migrationBuilder.DropColumn(
                name: "rootIdRoot",
                table: "Personne");

            migrationBuilder.RenameColumn(
                name: "personneId",
                table: "Result",
                newName: "PersonneId");

            migrationBuilder.RenameIndex(
                name: "IX_Result_personneId",
                table: "Result",
                newName: "IX_Result_PersonneId");

            migrationBuilder.AddColumn<string>(
                name: "nametitle",
                table: "Result",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "registereddate",
                table: "Result",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "infoseed",
                table: "Personne",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Name",
                columns: table => new
                {
                    title = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    last = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    first = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Name", x => x.title);
                });

            migrationBuilder.CreateTable(
                name: "Registered",
                columns: table => new
                {
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    service = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registered", x => x.date);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Result_nametitle",
                table: "Result",
                column: "nametitle");

            migrationBuilder.CreateIndex(
                name: "IX_Result_registereddate",
                table: "Result",
                column: "registereddate");

            migrationBuilder.CreateIndex(
                name: "IX_Personne_infoseed",
                table: "Personne",
                column: "infoseed");

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
                name: "FK_Result_Personne_PersonneId",
                table: "Result",
                column: "PersonneId",
                principalTable: "Personne",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Result_Registered_registereddate",
                table: "Result",
                column: "registereddate",
                principalTable: "Registered",
                principalColumn: "date",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personne_Info_infoseed",
                table: "Personne");

            migrationBuilder.DropForeignKey(
                name: "FK_Result_Name_nametitle",
                table: "Result");

            migrationBuilder.DropForeignKey(
                name: "FK_Result_Personne_PersonneId",
                table: "Result");

            migrationBuilder.DropForeignKey(
                name: "FK_Result_Registered_registereddate",
                table: "Result");

            migrationBuilder.DropTable(
                name: "Name");

            migrationBuilder.DropTable(
                name: "Registered");

            migrationBuilder.DropIndex(
                name: "IX_Result_nametitle",
                table: "Result");

            migrationBuilder.DropIndex(
                name: "IX_Result_registereddate",
                table: "Result");

            migrationBuilder.DropIndex(
                name: "IX_Personne_infoseed",
                table: "Personne");

            migrationBuilder.DropColumn(
                name: "nametitle",
                table: "Result");

            migrationBuilder.DropColumn(
                name: "registereddate",
                table: "Result");

            migrationBuilder.DropColumn(
                name: "infoseed",
                table: "Personne");

            migrationBuilder.RenameColumn(
                name: "PersonneId",
                table: "Result",
                newName: "personneId");

            migrationBuilder.RenameIndex(
                name: "IX_Result_PersonneId",
                table: "Result",
                newName: "IX_Result_personneId");

            migrationBuilder.AddColumn<int>(
                name: "RootIdRoot",
                table: "Result",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "rootIdRoot",
                table: "Personne",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Root",
                columns: table => new
                {
                    IdRoot = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    infoseed = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Root", x => x.IdRoot);
                    table.ForeignKey(
                        name: "FK_Root_Info_infoseed",
                        column: x => x.infoseed,
                        principalTable: "Info",
                        principalColumn: "seed",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Result_RootIdRoot",
                table: "Result",
                column: "RootIdRoot");

            migrationBuilder.CreateIndex(
                name: "IX_Personne_rootIdRoot",
                table: "Personne",
                column: "rootIdRoot");

            migrationBuilder.CreateIndex(
                name: "IX_Root_infoseed",
                table: "Root",
                column: "infoseed");

            migrationBuilder.AddForeignKey(
                name: "FK_Personne_Root_rootIdRoot",
                table: "Personne",
                column: "rootIdRoot",
                principalTable: "Root",
                principalColumn: "IdRoot",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Result_Personne_personneId",
                table: "Result",
                column: "personneId",
                principalTable: "Personne",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Result_Root_RootIdRoot",
                table: "Result",
                column: "RootIdRoot",
                principalTable: "Root",
                principalColumn: "IdRoot",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
