using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopTime.Migrations
{
    public partial class InsertedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4b93b662-228f-49b3-abb5-b813c687867a", "bc5f7417-f825-4543-8ff1-9cd26a4998b5", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b59603a1-960b-4fc8-b851-7b66a87eaf5c", "9d9b1505-6a8f-4dd3-b6af-cd615eef9a27", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b93b662-228f-49b3-abb5-b813c687867a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b59603a1-960b-4fc8-b851-7b66a87eaf5c");
        }
    }
}
