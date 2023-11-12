using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Iacob_Isabela_Lab2.Migrations
{
    /// <inheritdoc />
    public partial class Borrowing2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Borrowing_Book_BookID",
                table: "Borrowing");

            migrationBuilder.DropIndex(
                name: "IX_Borrowing_BookID",
                table: "Borrowing");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "Borrowing",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "BorrowingID",
                table: "Book",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Borrowing_Book_ID",
                table: "Borrowing",
                column: "ID",
                principalTable: "Book",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Borrowing_Book_ID",
                table: "Borrowing");

            migrationBuilder.DropColumn(
                name: "BorrowingID",
                table: "Book");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "Borrowing",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateIndex(
                name: "IX_Borrowing_BookID",
                table: "Borrowing",
                column: "BookID");

            migrationBuilder.AddForeignKey(
                name: "FK_Borrowing_Book_BookID",
                table: "Borrowing",
                column: "BookID",
                principalTable: "Book",
                principalColumn: "ID");
        }
    }
}
