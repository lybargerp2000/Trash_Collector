using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class Today : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "874823c6-1592-48b3-9ca3-960d4d89c5f7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5b0fa1d-049f-47b1-ad52-d38eda448819");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "02634d4a-63fe-4253-b5f2-7bcc8fc492f3", "0c7dd65d-b9e1-4cfc-a04e-fa1310c3948b", "Employee", "EMPLOYEEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f4959f3d-1332-4ad3-9acc-64016d56e6a0", "793cee05-5982-4874-bd4a-50b2918ce2ee", "Customer", "CUSTOMERR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02634d4a-63fe-4253-b5f2-7bcc8fc492f3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f4959f3d-1332-4ad3-9acc-64016d56e6a0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "874823c6-1592-48b3-9ca3-960d4d89c5f7", "0999c0ba-8c40-4e54-92d3-6d59f460d589", "Employee", "EMPLOYEEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e5b0fa1d-049f-47b1-ad52-d38eda448819", "30c0f145-809f-4947-b8b2-ba52498102f1", "Customer", "CUSTOMERR" });
        }
    }
}
