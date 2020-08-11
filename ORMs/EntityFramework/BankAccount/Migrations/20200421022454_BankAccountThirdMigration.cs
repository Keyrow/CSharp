using Microsoft.EntityFrameworkCore.Migrations;

namespace BankAccount.Migrations
{
    public partial class BankAccountThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deposit",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Withdrawal",
                table: "Users");

            migrationBuilder.AddColumn<double>(
                name: "balance",
                table: "Users",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "balance",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "Deposit",
                table: "Users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Withdrawal",
                table: "Users",
                nullable: false,
                defaultValue: 0);
        }
    }
}
