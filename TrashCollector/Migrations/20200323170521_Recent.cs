using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class Recent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_AspNetUsers_IdentityUserId",
                table: "Customer");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Date_AspNetUsers_IdentityUserId",
            //    table: "Date");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_Date",
            //    table: "Date");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                table: "Customer");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c0dd3c43-9c72-48b1-9825-d59bcf9e9e00");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ecf4e825-16fe-40e8-ac17-1a2bf5f33622");

            //migrationBuilder.RenameTable(
            //    name: "Date",
            //    newName: "Dates");

            migrationBuilder.RenameTable(
                name: "Customer",
                newName: "Customers");

            //migrationBuilder.RenameIndex(
            //    name: "IX_Date_IdentityUserId",
            //    table: "Dates",
            //    newName: "IX_Dates_IdentityUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Customer_IdentityUserId",
                table: "Customers",
                newName: "IX_Customers_IdentityUserId");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_Dates",
            //    table: "Dates",
            //    column: "DateId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "CustomerId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d527bc41-3a2c-4d86-b312-e10bb216d8c6", "fcfc3f3f-d782-4164-a947-d547a5da32fc", "Employee", "EMPLOYEEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a0ab2553-f522-490c-a276-e57a4016b2fe", "4249e999-e0df-4fec-be68-7522fabbebef", "Customer", "CUSTOMERR" });

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_AspNetUsers_IdentityUserId",
                table: "Customers",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Dates_AspNetUsers_IdentityUserId",
            //    table: "Dates",
            //    column: "IdentityUserId",
            //    principalTable: "AspNetUsers",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_AspNetUsers_IdentityUserId",
                table: "Customers");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Dates_AspNetUsers_IdentityUserId",
            //    table: "Dates");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_Dates",
            //    table: "Dates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0ab2553-f522-490c-a276-e57a4016b2fe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d527bc41-3a2c-4d86-b312-e10bb216d8c6");

            //migrationBuilder.RenameTable(
            //    name: "Dates",
            //    newName: "Date");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "Customer");

            //migrationBuilder.RenameIndex(
            //    name: "IX_Dates_IdentityUserId",
            //    table: "Date",
            //    newName: "IX_Date_IdentityUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_IdentityUserId",
                table: "Customer",
                newName: "IX_Customer_IdentityUserId");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_Date",
            //    table: "Date",
            //    column: "DateId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "CustomerId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c0dd3c43-9c72-48b1-9825-d59bcf9e9e00", "0625a653-c8ba-4b3b-9516-d913553f1a5a", "Employee", "EMPLOYEEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ecf4e825-16fe-40e8-ac17-1a2bf5f33622", "be6b7e19-1ffd-44c0-b06f-0a111fb61181", "Customer", "CUSTOMERR" });

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_AspNetUsers_IdentityUserId",
                table: "Customer",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Date_AspNetUsers_IdentityUserId",
            //    table: "Date",
            //    column: "IdentityUserId",
            //    principalTable: "AspNetUsers",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);
        }
    }
}
