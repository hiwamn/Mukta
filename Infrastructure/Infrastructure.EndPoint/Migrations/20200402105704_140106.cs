using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.EndPoint.Migrations
{
    public partial class _140106 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("55d6c750-c94e-423d-9934-2334dc3ac760"));

            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("702a08d9-dd4c-4f27-8343-af80baaced38"));

            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("bd748b62-ca37-4ac5-a5fa-462974d41785"));

            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("c4484bc1-f199-41b5-bfae-b7e61ab256d7"));

            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("c6d67992-f906-4200-8a5a-4fe19a5a1c2b"));

            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("f08b553e-39ef-4445-9812-a26475dfe33a"));

            migrationBuilder.InsertData(
                table: "StoreCategories",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("ee6a035f-377e-41b7-a3b0-1b56272e639a"), 0L, "Cooktop" },
                    { new Guid("dbe5e2e1-6525-4a2a-9975-691ab667c15e"), 0L, "Cooking range" },
                    { new Guid("10788aa8-0f84-4739-9397-186e271fbdfb"), 0L, "Chimney" },
                    { new Guid("fba21373-c13a-486f-a28e-b4ba2c052df1"), 0L, "Hobs" },
                    { new Guid("58ffafc2-08b5-4d5c-99e8-cde0249811ec"), 0L, "Cookware" },
                    { new Guid("3276f73a-c6c5-4ecd-9fb7-54d26140c06b"), 0L, "Cooker" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("10788aa8-0f84-4739-9397-186e271fbdfb"));

            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("3276f73a-c6c5-4ecd-9fb7-54d26140c06b"));

            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("58ffafc2-08b5-4d5c-99e8-cde0249811ec"));

            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("dbe5e2e1-6525-4a2a-9975-691ab667c15e"));

            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("ee6a035f-377e-41b7-a3b0-1b56272e639a"));

            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("fba21373-c13a-486f-a28e-b4ba2c052df1"));

            migrationBuilder.InsertData(
                table: "StoreCategories",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("702a08d9-dd4c-4f27-8343-af80baaced38"), 0L, "Cooktop" },
                    { new Guid("c6d67992-f906-4200-8a5a-4fe19a5a1c2b"), 0L, "Cooking range" },
                    { new Guid("f08b553e-39ef-4445-9812-a26475dfe33a"), 0L, "Chimney" },
                    { new Guid("bd748b62-ca37-4ac5-a5fa-462974d41785"), 0L, "Hobs" },
                    { new Guid("c4484bc1-f199-41b5-bfae-b7e61ab256d7"), 0L, "Cookware" },
                    { new Guid("55d6c750-c94e-423d-9934-2334dc3ac760"), 0L, "Cooker" }
                });
        }
    }
}
