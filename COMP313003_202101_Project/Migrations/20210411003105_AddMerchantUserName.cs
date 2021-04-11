using Microsoft.EntityFrameworkCore.Migrations;

namespace COMP313003_202101_Project.Migrations
{
    public partial class AddMerchantUserName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "PurchaseOrder");

            migrationBuilder.AddColumn<string>(
                name: "MerchantUserName",
                table: "PurchaseOrder",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MerchantUserName",
                table: "PurchaseOrder");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "PurchaseOrder",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
