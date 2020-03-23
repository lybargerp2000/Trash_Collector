using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class NewTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "Dates");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0ab2553-f522-490c-a276-e57a4016b2fe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d527bc41-3a2c-4d86-b312-e10bb216d8c6");

            migrationBuilder.CreateTable(
                name: "CustomerInfoCharts",
                columns: table => new
                {
                    CustomerInfoChartId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerDayOfWeek = table.Column<string>(nullable: true),
                    PickUpConfirm = table.Column<bool>(nullable: false),
                    CustomerPickUpCharge = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerInfoCharts", x => x.CustomerInfoChartId);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e0364851-f09a-4367-893a-802a13e93a6f", "6cb03412-cc90-45b6-9b6c-46fa6c65fe2f", "Employee", "EMPLOYEEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "734916c6-05a7-4a87-b07a-954d70116142", "f9a92d73-28d8-49fe-b6a5-2c849cbbd9bf", "Customer", "CUSTOMERR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerInfoCharts");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "734916c6-05a7-4a87-b07a-954d70116142");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0364851-f09a-4367-893a-802a13e93a6f");

            //migrationBuilder.CreateTable(
            //    name: "Dates",
            //    columns: table => new
            //    {
            //        DateId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        CalenderDate = table.Column<int>(type: "int", nullable: false),
            //        DayOfWeek = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        ExtraPickUpDate = table.Column<int>(type: "int", nullable: false),
            //        IdentityUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
            //        WeekOfMonth = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Dates", x => x.DateId);
            //        table.ForeignKey(
            //            name: "FK_Dates_AspNetUsers_IdentityUserId",
            //            column: x => x.IdentityUserId,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d527bc41-3a2c-4d86-b312-e10bb216d8c6", "fcfc3f3f-d782-4164-a947-d547a5da32fc", "Employee", "EMPLOYEEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a0ab2553-f522-490c-a276-e57a4016b2fe", "4249e999-e0df-4fec-be68-7522fabbebef", "Customer", "CUSTOMERR" });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Dates_IdentityUserId",
            //    table: "Dates",
            //    column: "IdentityUserId");
        }
    }
}
