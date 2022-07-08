using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CashRegistryEntityFrameWork.Migrations
{
    public partial class fir : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PaymentId",
                table: "cash_payment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PaymentId",
                table: "card_payment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_cash_payment_PaymentId",
                table: "cash_payment",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_card_payment_PaymentId",
                table: "card_payment",
                column: "PaymentId");

            migrationBuilder.AddForeignKey(
                name: "FK_card_payment_Payment_PaymentId",
                table: "card_payment",
                column: "PaymentId",
                principalTable: "Payment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_cash_payment_Payment_PaymentId",
                table: "cash_payment",
                column: "PaymentId",
                principalTable: "Payment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_card_payment_Payment_PaymentId",
                table: "card_payment");

            migrationBuilder.DropForeignKey(
                name: "FK_cash_payment_Payment_PaymentId",
                table: "cash_payment");

            migrationBuilder.DropIndex(
                name: "IX_cash_payment_PaymentId",
                table: "cash_payment");

            migrationBuilder.DropIndex(
                name: "IX_card_payment_PaymentId",
                table: "card_payment");

            migrationBuilder.DropColumn(
                name: "PaymentId",
                table: "cash_payment");

            migrationBuilder.DropColumn(
                name: "PaymentId",
                table: "card_payment");
        }
    }
}
