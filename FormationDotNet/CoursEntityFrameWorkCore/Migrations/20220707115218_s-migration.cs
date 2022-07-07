using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoursEntityFrameWorkCore.Migrations
{
    public partial class smigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personnes_Adresses_AdresseId",
                table: "Personnes");

            migrationBuilder.DropIndex(
                name: "IX_Personnes_AdresseId",
                table: "Personnes");

            migrationBuilder.DropColumn(
                name: "AdresseId",
                table: "Personnes");

            migrationBuilder.AddColumn<int>(
                name: "PersonneId",
                table: "Adresses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Adresses_PersonneId",
                table: "Adresses",
                column: "PersonneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Adresses_Personnes_PersonneId",
                table: "Adresses",
                column: "PersonneId",
                principalTable: "Personnes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "AdresseId",
                table: "Personnes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Personnes_AdresseId",
                table: "Personnes",
                column: "AdresseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personnes_Adresses_AdresseId",
                table: "Personnes",
                column: "AdresseId",
                principalTable: "Adresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
