using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class CustomerInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "734916c6-05a7-4a87-b07a-954d70116142");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0364851-f09a-4367-893a-802a13e93a6f");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "CustomerInfoCharts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8982d511-3e19-494d-bfd9-b24e148edf73", "548aef92-501d-45d0-91f8-b24d857438be", "Employee", "EMPLOYEEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e47e2f9f-f4d5-4b28-b680-35a2e7296ac6", "b2dd2ebd-b093-499d-a652-1ebad82c6e56", "Customer", "CUSTOMERR" });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerInfoCharts_CustomerId",
                table: "CustomerInfoCharts",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerInfoCharts_Customers_CustomerId",
                table: "CustomerInfoCharts",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerInfoCharts_Customers_CustomerId",
                table: "CustomerInfoCharts");

            migrationBuilder.DropIndex(
                name: "IX_CustomerInfoCharts_CustomerId",
                table: "CustomerInfoCharts");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8982d511-3e19-494d-bfd9-b24e148edf73");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e47e2f9f-f4d5-4b28-b680-35a2e7296ac6");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "CustomerInfoCharts");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e0364851-f09a-4367-893a-802a13e93a6f", "6cb03412-cc90-45b6-9b6c-46fa6c65fe2f", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "734916c6-05a7-4a87-b07a-954d70116142", "f9a92d73-28d8-49fe-b6a5-2c849cbbd9bf", "Customer", "CUSTOMER" });
        }
    }
}
