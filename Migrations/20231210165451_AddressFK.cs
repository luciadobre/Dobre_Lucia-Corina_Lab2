using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dobre_Lucia_Corina_Lab2.Migrations
{
    public partial class AddressFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Borrowing_BorrowingID",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Borrowing_BookID",
                table: "Borrowing");

            migrationBuilder.DropIndex(
                name: "IX_Book_BorrowingID",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "Adress",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "BorrowingID",
                table: "Book");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Member",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Member",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Member",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Book",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Borrowing_BookID",
                table: "Borrowing",
                column: "BookID",
                unique: true,
                filter: "[BookID] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Borrowing_BookID",
                table: "Borrowing");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Member");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Member",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Member",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Adress",
                table: "Member",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Book",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AddColumn<int>(
                name: "BorrowingID",
                table: "Book",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Borrowing_BookID",
                table: "Borrowing",
                column: "BookID");

            migrationBuilder.CreateIndex(
                name: "IX_Book_BorrowingID",
                table: "Book",
                column: "BorrowingID");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Borrowing_BorrowingID",
                table: "Book",
                column: "BorrowingID",
                principalTable: "Borrowing",
                principalColumn: "ID");
        }
    }
}
