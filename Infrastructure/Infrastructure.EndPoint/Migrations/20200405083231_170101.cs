using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.EndPoint.Migrations
{
    public partial class _170101 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "UserImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<long>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    DocumentId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserImages_Documents_DocumentId",
                        column: x => x.DocumentId,
                        principalTable: "Documents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserImages_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "EntityStatuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 4, "WaitingToSendImage" },
                    { 5, "ImageHasBeenSent" },
                    { 6, "ImageHasBeenRejected" }
                });

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
                name: "IX_UserImages_DocumentId",
                table: "UserImages",
                column: "DocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_UserImages_UserId",
                table: "UserImages",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserImages");

            migrationBuilder.DeleteData(
                table: "EntityStatuses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EntityStatuses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EntityStatuses",
                keyColumn: "Id",
                keyValue: 6);

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
    }
}
