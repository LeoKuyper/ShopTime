using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopTime.Migrations
{
    public partial class fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "a98a9dd9-2bcc-44d8-8f2c-2ec40e654d2d", "b231d10d-450e-4534-8b30-dc2b5e67c160", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cc3a8601-0156-4f34-98e9-80dc70d8b1d7", "c4d10f94-ab2c-4b15-81d7-c29f0d11538f", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a98a9dd9-2bcc-44d8-8f2c-2ec40e654d2d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc3a8601-0156-4f34-98e9-80dc70d8b1d7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e0629f48-e443-47f8-8b09-5146b28049ed", "393607b2-1dae-4a29-aec5-c495874860b4", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ad18149b-8eb4-4fac-9b23-a625d2850a02", "4f6de5a8-3b38-4624-8979-2cf70c42a03a", "Administrator", "ADMINISTRATOR" });
        }
    }
}
