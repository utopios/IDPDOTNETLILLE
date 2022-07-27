using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CorrectionPetiteAnnonce.Migrations
{
    public partial class user : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "role",
                table: "utilisateur",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "utilisateur_id",
                table: "annonce",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_annonce_utilisateur_id",
                table: "annonce",
                column: "utilisateur_id");

            migrationBuilder.AddForeignKey(
                name: "FK_annonce_utilisateur_utilisateur_id",
                table: "annonce",
                column: "utilisateur_id",
                principalTable: "utilisateur",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_annonce_utilisateur_utilisateur_id",
                table: "annonce");

            migrationBuilder.DropIndex(
                name: "IX_annonce_utilisateur_id",
                table: "annonce");

            migrationBuilder.DropColumn(
                name: "role",
                table: "utilisateur");

            migrationBuilder.DropColumn(
                name: "utilisateur_id",
                table: "annonce");
        }
    }
}
