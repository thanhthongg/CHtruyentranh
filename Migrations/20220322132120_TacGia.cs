using Microsoft.EntityFrameworkCore.Migrations;

namespace CHtruyentranh.Migrations
{
    public partial class TacGia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Gia",
                table: "Book",
                type: "decimal(18, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<string>(
                name: "TacGia",
                table: "Book",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TacGia",
                table: "Book");

            migrationBuilder.AlterColumn<decimal>(
                name: "Gia",
                table: "Book",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)");
        }
    }
}
