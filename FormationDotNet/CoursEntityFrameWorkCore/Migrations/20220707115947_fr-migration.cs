using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoursEntityFrameWorkCore.Migrations
{
    public partial class frmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adresses_Personnes_PersonneId",
                table: "Adresses");

            migrationBuilder.DropIndex(
                name: "IX_Adresses_PersonneId",
                table: "Adresses");

            migrationBuilder.DropColumn(
                name: "PersonneId",
                table: "Adresses");

            migrationBuilder.CreateTable(
                name: "AdressePersonne",
                columns: table => new
                {
                    AdressesId = table.Column<int>(type: "int", nullable: false),
                    PersonnesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdressePersonne", x => new { x.AdressesId, x.PersonnesId });
                    table.ForeignKey(
                        name: "FK_AdressePersonne_Adresses_AdressesId",
                        column: x => x.AdressesId,
                        principalTable: "Adresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdressePersonne_Personnes_PersonnesId",
                        column: x => x.PersonnesId,
                        principalTable: "Personnes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdressePersonne_PersonnesId",
                table: "AdressePersonne",
                column: "PersonnesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdressePersonne");

            migrationBuilder.AddColumn<int>(
                name: "PersonneId",
                table: "Adresses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Adresses_PersonneId",
                table: "Adresses",
                column: "PersonneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Adresses_Personnes_PersonneId",
                table: "Adresses",
                column: "PersonneId",
                principalTable: "Personnes",
                principalColumn: "Id");
        }
    }
}
