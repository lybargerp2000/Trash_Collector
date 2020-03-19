using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class Date : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f5a2c3b0-34f1-4866-af92-770642a14bb4");

            migrationBuilder.CreateTable(
                name: "Date",
                columns: table => new
                {
                    DateId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CalenderDate = table.Column<int>(nullable: false),
                    DayOfWeek = table.Column<string>(nullable: true),
                    WeekOfMonth = table.Column<string>(nullable: true),
                    IdentityUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Date", x => x.DateId);
                    table.ForeignKey(
                        name: "FK_Date_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ecfdff38-2a87-472b-aae2-d16ce763784d", "d4f6d1f7-2e7e-42b7-99a0-ede15f240bbd", "Admin", "ADMIN" });

            migrationBuilder.CreateIndex(
                name: "IX_Date_IdentityUserId",
                table: "Date",
                column: "IdentityUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Date");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ecfdff38-2a87-472b-aae2-d16ce763784d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f5a2c3b0-34f1-4866-af92-770642a14bb4", "69fccc30-5218-48f3-abd7-dd3cb4c2fa7b", "Admin", "Admin" });
        }
    }
}
