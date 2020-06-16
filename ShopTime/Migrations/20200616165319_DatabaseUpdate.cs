using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopTime.Migrations
{
    public partial class DatabaseUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e7dd5d4-8d15-422e-995f-a44e2da3d8e0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8a2a3e0-5fe7-498c-9db2-349cc61d9b1d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ef88a34c-951d-43f8-8037-24ab2084ffea", "afb4c453-2093-4acf-95e6-8a7bf2b05df8", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ebaab733-d752-4a61-995e-5e47071e9cab", "7fc7cdf0-95fd-4380-851e-03e42ba6fef3", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ebaab733-d752-4a61-995e-5e47071e9cab");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef88a34c-951d-43f8-8037-24ab2084ffea");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c8a2a3e0-5fe7-498c-9db2-349cc61d9b1d", "bf1bbacd-4154-40e7-8139-6096f1be845e", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6e7dd5d4-8d15-422e-995f-a44e2da3d8e0", "7d45a093-d83c-4bb1-9e18-548774ed73f3", "Administrator", "ADMINISTRATOR" });
        }
    }
}
