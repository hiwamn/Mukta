using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.EndPoint.Migrations
{
    public partial class _150101 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PartyDocuments_Parties_PartyId1",
                table: "PartyDocuments");

            migrationBuilder.DropIndex(
                name: "IX_PartyDocuments_PartyId1",
                table: "PartyDocuments");

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

            migrationBuilder.DropColumn(
                name: "PartyId1",
                table: "PartyDocuments");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<Guid>(
                name: "PartyId1",
                table: "PartyDocuments",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_PartyDocuments_PartyId1",
                table: "PartyDocuments",
                column: "PartyId1");

            migrationBuilder.AddForeignKey(
                name: "FK_PartyDocuments_Parties_PartyId1",
                table: "PartyDocuments",
                column: "PartyId1",
                principalTable: "Parties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
