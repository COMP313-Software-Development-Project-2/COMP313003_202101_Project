using Microsoft.EntityFrameworkCore.Migrations;

namespace COMP313003_202101_Project.Migrations
{
    public partial class AddCustomerId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "PurchaseOrder",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "PurchaseOrder");
        }
    }
}
