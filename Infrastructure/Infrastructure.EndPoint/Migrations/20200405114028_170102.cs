using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.EndPoint.Migrations
{
    public partial class _170102 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeadDocuments_Leads_LeadId1",
                table: "LeadDocuments");

            migrationBuilder.DropIndex(
                name: "IX_LeadDocuments_LeadId1",
                table: "LeadDocuments");

            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("165e26e4-0946-4305-9ac5-20e5ca6aeb27"));

            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("31e06410-34f2-4dbf-a4e5-bcc3986516e3"));

            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("6c3caeda-6b6c-4d88-8111-bc6fe24cb006"));

            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("841b4765-c98e-4657-88be-cd586b9afecc"));

            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("cc952945-374f-418d-b66c-b8a55cc0e753"));

            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("eeee852b-6e23-4491-a967-2136e2575673"));

            migrationBuilder.DropColumn(
                name: "LeadId1",
                table: "LeadDocuments");

            migrationBuilder.InsertData(
                table: "StoreCategories",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("a175c499-2a83-4140-80b8-d29789a5ea71"), 0L, "Cooktop" },
                    { new Guid("c02aaa50-ecc8-4c39-8c89-65502b135e67"), 0L, "Cooking range" },
                    { new Guid("7f1d3829-c9e7-4dea-beb0-03614a705e51"), 0L, "Chimney" },
                    { new Guid("d6d91602-78c5-4860-a240-e1fe8dc53eee"), 0L, "Hobs" },
                    { new Guid("cf6395f1-c917-418e-8c9d-eaee21ef1935"), 0L, "Cookware" },
                    { new Guid("6d0a9e60-f029-4cb0-bc4e-907ce0198c42"), 0L, "Cooker" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("6d0a9e60-f029-4cb0-bc4e-907ce0198c42"));

            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("7f1d3829-c9e7-4dea-beb0-03614a705e51"));

            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("a175c499-2a83-4140-80b8-d29789a5ea71"));

            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("c02aaa50-ecc8-4c39-8c89-65502b135e67"));

            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("cf6395f1-c917-418e-8c9d-eaee21ef1935"));

            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("d6d91602-78c5-4860-a240-e1fe8dc53eee"));

            migrationBuilder.AddColumn<Guid>(
                name: "LeadId1",
                table: "LeadDocuments",
                nullable: true);

            migrationBuilder.InsertData(
                table: "StoreCategories",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("841b4765-c98e-4657-88be-cd586b9afecc"), 0L, "Cooktop" },
                    { new Guid("eeee852b-6e23-4491-a967-2136e2575673"), 0L, "Cooking range" },
                    { new Guid("6c3caeda-6b6c-4d88-8111-bc6fe24cb006"), 0L, "Chimney" },
                    { new Guid("cc952945-374f-418d-b66c-b8a55cc0e753"), 0L, "Hobs" },
                    { new Guid("31e06410-34f2-4dbf-a4e5-bcc3986516e3"), 0L, "Cookware" },
                    { new Guid("165e26e4-0946-4305-9ac5-20e5ca6aeb27"), 0L, "Cooker" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_LeadDocuments_LeadId1",
                table: "LeadDocuments",
                column: "LeadId1");

            migrationBuilder.AddForeignKey(
                name: "FK_LeadDocuments_Leads_LeadId1",
                table: "LeadDocuments",
                column: "LeadId1",
                principalTable: "Leads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
