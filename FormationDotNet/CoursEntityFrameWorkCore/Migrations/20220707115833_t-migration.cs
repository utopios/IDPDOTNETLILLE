using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoursEntityFrameWorkCore.Migrations
{
    public partial class tmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adresses_Personnes_PersonneId",
                table: "Adresses");

            migrationBuilder.AlterColumn<int>(
                name: "PersonneId",
                table: "Adresses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Adresses_Personnes_PersonneId",
                table: "Adresses",
                column: "PersonneId",
                principalTable: "Personnes",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adresses_Personnes_PersonneId",
                table: "Adresses");

            migrationBuilder.AlterColumn<int>(
                name: "PersonneId",
                table: "Adresses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Adresses_Personnes_PersonneId",
                table: "Adresses",
                column: "PersonneId",
                principalTable: "Personnes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
