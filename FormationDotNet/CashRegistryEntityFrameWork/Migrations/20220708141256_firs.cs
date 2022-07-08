using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CashRegistryEntityFrameWork.Migrations
{
    public partial class firs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Change",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Payment");

            migrationBuilder.CreateTable(
                name: "card_payment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_card_payment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_card_payment_Payment_Id",
                        column: x => x.Id,
                        principalTable: "Payment",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "cash_payment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Change = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cash_payment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_cash_payment_Payment_Id",
                        column: x => x.Id,
                        principalTable: "Payment",
                        principalColumn: "Id");
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "card_payment");

            migrationBuilder.DropTable(
                name: "cash_payment");

            migrationBuilder.AddColumn<decimal>(
                name: "Change",
                table: "Payment",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
