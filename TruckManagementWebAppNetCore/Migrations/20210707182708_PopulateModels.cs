using Microsoft.EntityFrameworkCore.Migrations;

namespace TruckManagementWebAppNetCore.Migrations
{
    public partial class PopulateModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "FH" });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "FM" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
