using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopTime.Migrations
{
    public partial class UserUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b93b662-228f-49b3-abb5-b813c687867a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b59603a1-960b-4fc8-b851-7b66a87eaf5c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e04fae84-b12f-4c64-9dca-b33cf9a6ad66", "c01f9927-d142-4e33-a5e5-9389ee40aa5d", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5b76ae72-98e7-4ed6-a199-d27696128946", "9d9f4de0-4c0b-4800-b013-c62a6c3c11ae", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b76ae72-98e7-4ed6-a199-d27696128946");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e04fae84-b12f-4c64-9dca-b33cf9a6ad66");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4b93b662-228f-49b3-abb5-b813c687867a", "bc5f7417-f825-4543-8ff1-9cd26a4998b5", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b59603a1-960b-4fc8-b851-7b66a87eaf5c", "9d9b1505-6a8f-4dd3-b6af-cd615eef9a27", "Administrator", "ADMINISTRATOR" });
        }
    }
}
