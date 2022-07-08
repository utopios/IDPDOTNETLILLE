using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankEntityFrameWork.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_account_customer_CustomerId",
                table: "account");

            migrationBuilder.DropForeignKey(
                name: "FK_operation_account_AccountId",
                table: "operation");

            migrationBuilder.RenameColumn(
                name: "OperationDateTime",
                table: "operation",
                newName: "operation_date_time");

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "operation",
                newName: "account_id");

            migrationBuilder.RenameIndex(
                name: "IX_operation_AccountId",
                table: "operation",
                newName: "IX_operation_account_id");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "account",
                newName: "customer_id");

            migrationBuilder.RenameColumn(
                name: "AccountNumber",
                table: "account",
                newName: "account_number");

            migrationBuilder.RenameIndex(
                name: "IX_account_CustomerId",
                table: "account",
                newName: "IX_account_customer_id");

            migrationBuilder.AddForeignKey(
                name: "FK_account_customer_customer_id",
                table: "account",
                column: "customer_id",
                principalTable: "customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_operation_account_account_id",
                table: "operation",
                column: "account_id",
                principalTable: "account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_account_customer_customer_id",
                table: "account");

            migrationBuilder.DropForeignKey(
                name: "FK_operation_account_account_id",
                table: "operation");

            migrationBuilder.RenameColumn(
                name: "operation_date_time",
                table: "operation",
                newName: "OperationDateTime");

            migrationBuilder.RenameColumn(
                name: "account_id",
                table: "operation",
                newName: "AccountId");

            migrationBuilder.RenameIndex(
                name: "IX_operation_account_id",
                table: "operation",
                newName: "IX_operation_AccountId");

            migrationBuilder.RenameColumn(
                name: "customer_id",
                table: "account",
                newName: "CustomerId");

            migrationBuilder.RenameColumn(
                name: "account_number",
                table: "account",
                newName: "AccountNumber");

            migrationBuilder.RenameIndex(
                name: "IX_account_customer_id",
                table: "account",
                newName: "IX_account_CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_account_customer_CustomerId",
                table: "account",
                column: "CustomerId",
                principalTable: "customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_operation_account_AccountId",
                table: "operation",
                column: "AccountId",
                principalTable: "account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
