using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.EndPoint.Migrations
{
    public partial class _140120 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeadStoreCategories_Leads_LeadId",
                table: "LeadStoreCategories");

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
                    { new Guid("37fa7d22-990d-4615-9072-c9452d9be084"), 0L, "Cooktop" },
                    { new Guid("ffa4536f-9143-41a8-84d5-d76e65be4586"), 0L, "Cooking range" },
                    { new Guid("e0d053ca-1a06-4ed6-b7f1-55ea26300a38"), 0L, "Chimney" },
                    { new Guid("5c3fb65f-f15e-4879-9e85-bf78c2eb6ff2"), 0L, "Hobs" },
                    { new Guid("b218de08-ad4d-4219-9dce-f58cfab22da6"), 0L, "Cookware" },
                    { new Guid("6674f3a9-d062-4409-8286-0c862719677d"), 0L, "Cooker" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_LeadStoreCategories_Leads_LeadId",
                table: "LeadStoreCategories",
                column: "LeadId",
                principalTable: "Leads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeadStoreCategories_Leads_LeadId",
                table: "LeadStoreCategories");

            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("37fa7d22-990d-4615-9072-c9452d9be084"));

            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("5c3fb65f-f15e-4879-9e85-bf78c2eb6ff2"));

            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("6674f3a9-d062-4409-8286-0c862719677d"));

            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("b218de08-ad4d-4219-9dce-f58cfab22da6"));

            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("e0d053ca-1a06-4ed6-b7f1-55ea26300a38"));

            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("ffa4536f-9143-41a8-84d5-d76e65be4586"));

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

            migrationBuilder.AddForeignKey(
                name: "FK_LeadStoreCategories_Leads_LeadId",
                table: "LeadStoreCategories",
                column: "LeadId",
                principalTable: "Leads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
