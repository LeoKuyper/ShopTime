using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopTime.Migrations
{
    public partial class foreignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f5b5a3d-54ae-4071-b153-13223626e731");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a24a6d09-46df-4d24-a86e-261f93f6d0e4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e0629f48-e443-47f8-8b09-5146b28049ed", "393607b2-1dae-4a29-aec5-c495874860b4", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ad18149b-8eb4-4fac-9b23-a625d2850a02", "4f6de5a8-3b38-4624-8979-2cf70c42a03a", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad18149b-8eb4-4fac-9b23-a625d2850a02");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0629f48-e443-47f8-8b09-5146b28049ed");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2f5b5a3d-54ae-4071-b153-13223626e731", "7fac18d0-bb8d-40af-b5a0-1fb9d3a6cced", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a24a6d09-46df-4d24-a86e-261f93f6d0e4", "49b3a086-b8a4-4442-8caf-9b190d96ce86", "Administrator", "ADMINISTRATOR" });
        }
    }
}
