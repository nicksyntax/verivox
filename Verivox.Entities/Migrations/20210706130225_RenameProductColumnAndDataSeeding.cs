using Microsoft.EntityFrameworkCore.Migrations;

namespace Verivox.Entities.Migrations
{
    public partial class RenameProductColumnAndDataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CostPerKwh",
                table: "Products",
                newName: "Cost");

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "ProductTypeId", "ProductTypeName" },
                values: new object[] { 1, "Base Cost Based" });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "ProductTypeId", "ProductTypeName" },
                values: new object[] { 2, "Threshold Based" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "AdditionalCostPerKwh", "Cost", "MonthlyBaseValue", "ProductName", "ProductTypeId" },
                values: new object[] { 1, 0, 22, 5, "basic electricity tariff", 1 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "AdditionalCostPerKwh", "Cost", "MonthlyBaseValue", "ProductName", "ProductTypeId" },
                values: new object[] { 2, 30, 800, 0, "Packaged tariff", 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "ProductTypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "ProductTypeId",
                keyValue: 2);

            migrationBuilder.RenameColumn(
                name: "Cost",
                table: "Products",
                newName: "CostPerKwh");
        }
    }
}
