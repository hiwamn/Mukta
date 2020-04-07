using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.EndPoint.Migrations
{
    public partial class _160110 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Parties_Users_UserId",
                table: "Parties");

            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("17fc9e20-f4f9-4136-8e62-41fc46adb941"));

            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("4f62867b-b157-4135-bf47-8dd8ccfa9e50"));

            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("61eeb02b-6e25-49e9-a4e9-7a138d8f9381"));

            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("a62b7773-b704-4522-905b-e670351e235f"));

            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("b05162a6-e1fe-4116-a9d9-9d78a9871f3a"));

            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("f8eb5864-df81-42f9-b1e5-59848b48c4de"));

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Orders",
                newName: "PartyId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                newName: "IX_Orders_PartyId");

            migrationBuilder.AlterColumn<bool>(
                name: "PaymentTerms",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Insurance",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Days",
                table: "Orders",
                nullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Parties_PartyId",
                table: "Orders",
                column: "PartyId",
                principalTable: "Parties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Parties_Users_UserId",
                table: "Parties",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Parties_PartyId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Parties_Users_UserId",
                table: "Parties");

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

            migrationBuilder.DropColumn(
                name: "Days",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "PartyId",
                table: "Orders",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_PartyId",
                table: "Orders",
                newName: "IX_Orders_UserId");

            migrationBuilder.AlterColumn<string>(
                name: "PaymentTerms",
                table: "Orders",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "Insurance",
                table: "Orders",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.InsertData(
                table: "StoreCategories",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("a62b7773-b704-4522-905b-e670351e235f"), 0L, "Cooktop" },
                    { new Guid("17fc9e20-f4f9-4136-8e62-41fc46adb941"), 0L, "Cooking range" },
                    { new Guid("61eeb02b-6e25-49e9-a4e9-7a138d8f9381"), 0L, "Chimney" },
                    { new Guid("4f62867b-b157-4135-bf47-8dd8ccfa9e50"), 0L, "Hobs" },
                    { new Guid("f8eb5864-df81-42f9-b1e5-59848b48c4de"), 0L, "Cookware" },
                    { new Guid("b05162a6-e1fe-4116-a9d9-9d78a9871f3a"), 0L, "Cooker" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Parties_Users_UserId",
                table: "Parties",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
