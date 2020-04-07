using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.EndPoint.Migrations
{
    public partial class _160120 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("063a874f-e6e9-4e8b-963f-8eed9ba40496"));

            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("55e84b84-2a4d-483e-9a43-2b41bcc318cd"));

            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("68030dc6-bb6c-4e4b-9395-7577257c2be5"));

            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("7361be57-ad1c-4d15-aa17-6f3d68a74996"));

            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("9a18cc0f-a230-48a2-89bf-1c4a88bb4f30"));

            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("ae174a06-711f-4cac-94a7-36134813c8bf"));

            migrationBuilder.AddColumn<string>(
                name: "DayCount",
                table: "Orders",
                nullable: true);

            migrationBuilder.InsertData(
                table: "StoreCategories",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("99f71782-fa8c-4026-af03-b51a1d3cd726"), 0L, "Cooktop" },
                    { new Guid("52c448b8-77c9-44f4-a65b-f512c50e5338"), 0L, "Cooking range" },
                    { new Guid("be5ac411-448d-4bb2-8a5d-e08c18cc617e"), 0L, "Chimney" },
                    { new Guid("258cece2-6a88-4bbe-975d-eb59078824bf"), 0L, "Hobs" },
                    { new Guid("1d76c66c-d185-4c75-8c64-df3bd0182087"), 0L, "Cookware" },
                    { new Guid("e43e0fe5-b1cb-484a-8d61-051a1a7dce5e"), 0L, "Cooker" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("1d76c66c-d185-4c75-8c64-df3bd0182087"));

            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("258cece2-6a88-4bbe-975d-eb59078824bf"));

            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("52c448b8-77c9-44f4-a65b-f512c50e5338"));

            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("99f71782-fa8c-4026-af03-b51a1d3cd726"));

            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("be5ac411-448d-4bb2-8a5d-e08c18cc617e"));

            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("e43e0fe5-b1cb-484a-8d61-051a1a7dce5e"));

            migrationBuilder.DropColumn(
                name: "DayCount",
                table: "Orders");

            migrationBuilder.InsertData(
                table: "StoreCategories",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("063a874f-e6e9-4e8b-963f-8eed9ba40496"), 0L, "Cooktop" },
                    { new Guid("68030dc6-bb6c-4e4b-9395-7577257c2be5"), 0L, "Cooking range" },
                    { new Guid("9a18cc0f-a230-48a2-89bf-1c4a88bb4f30"), 0L, "Chimney" },
                    { new Guid("55e84b84-2a4d-483e-9a43-2b41bcc318cd"), 0L, "Hobs" },
                    { new Guid("ae174a06-711f-4cac-94a7-36134813c8bf"), 0L, "Cookware" },
                    { new Guid("7361be57-ad1c-4d15-aa17-6f3d68a74996"), 0L, "Cooker" }
                });
        }
    }
}
