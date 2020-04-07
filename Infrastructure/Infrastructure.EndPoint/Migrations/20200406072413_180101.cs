using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.EndPoint.Migrations
{
    public partial class _180101 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Feedbacks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Expenses",
                nullable: true);

            migrationBuilder.InsertData(
                table: "StoreCategories",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { new Guid("d595f9ff-2e79-4df2-b212-e28f8d2f294d"), 0L, "Cooktop" },
                    { new Guid("6d5ac34b-941f-4354-a5f4-dbc9603523d0"), 0L, "Cooking range" },
                    { new Guid("c46c21e4-33b1-4e17-86e2-5c36e31f4a4f"), 0L, "Chimney" },
                    { new Guid("639d5843-85ee-42a6-8c97-348a30797a0c"), 0L, "Hobs" },
                    { new Guid("7384fbcf-9cc3-4779-b871-f520ad17e946"), 0L, "Cookware" },
                    { new Guid("ca6b22be-73d2-4ea9-8f6b-9358439455b5"), 0L, "Cooker" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("639d5843-85ee-42a6-8c97-348a30797a0c"));

            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("6d5ac34b-941f-4354-a5f4-dbc9603523d0"));

            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("7384fbcf-9cc3-4779-b871-f520ad17e946"));

            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("c46c21e4-33b1-4e17-86e2-5c36e31f4a4f"));

            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("ca6b22be-73d2-4ea9-8f6b-9358439455b5"));

            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("d595f9ff-2e79-4df2-b212-e28f8d2f294d"));

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Feedbacks");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Expenses");

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
    }
}
