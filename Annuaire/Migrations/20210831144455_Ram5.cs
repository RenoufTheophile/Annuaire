using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Annuaire.Migrations
{
    public partial class Ram5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "infoseed",
                table: "Personne",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Info",
                columns: table => new
                {
                    seed = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    results = table.Column<int>(type: "int", nullable: false),
                    page = table.Column<int>(type: "int", nullable: false),
                    version = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Info", x => x.seed);
                });

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

            migrationBuilder.CreateTable(
                name: "Result",
                columns: table => new
                {
                    email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    nametitle = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    registereddate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonneId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Result", x => x.email);
                    table.ForeignKey(
                        name: "FK_Result_Name_nametitle",
                        column: x => x.nametitle,
                        principalTable: "Name",
                        principalColumn: "title",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Result_Personne_PersonneId",
                        column: x => x.PersonneId,
                        principalTable: "Personne",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Result_Registered_registereddate",
                        column: x => x.registereddate,
                        principalTable: "Registered",
                        principalColumn: "date",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personne_infoseed",
                table: "Personne",
                column: "infoseed");

            migrationBuilder.CreateIndex(
                name: "IX_Result_nametitle",
                table: "Result",
                column: "nametitle");

            migrationBuilder.CreateIndex(
                name: "IX_Result_PersonneId",
                table: "Result",
                column: "PersonneId");

            migrationBuilder.CreateIndex(
                name: "IX_Result_registereddate",
                table: "Result",
                column: "registereddate");

            migrationBuilder.AddForeignKey(
                name: "FK_Personne_Info_infoseed",
                table: "Personne",
                column: "infoseed",
                principalTable: "Info",
                principalColumn: "seed",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personne_Info_infoseed",
                table: "Personne");

            migrationBuilder.DropTable(
                name: "Info");

            migrationBuilder.DropTable(
                name: "Result");

            migrationBuilder.DropTable(
                name: "Name");

            migrationBuilder.DropTable(
                name: "Registered");

            migrationBuilder.DropIndex(
                name: "IX_Personne_infoseed",
                table: "Personne");

            migrationBuilder.DropColumn(
                name: "infoseed",
                table: "Personne");
        }
    }
}
