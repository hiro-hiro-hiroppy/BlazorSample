using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorSv.Migrations
{
    public partial class InitMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "price",
                table: "Book",
                newName: "Price");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Book",
                newName: "price");
        }
    }
}
