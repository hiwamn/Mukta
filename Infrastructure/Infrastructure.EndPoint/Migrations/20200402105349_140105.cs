using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.EndPoint.Migrations
{
    public partial class _140105 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Leads_Users_UserId",
                table: "Leads");

            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("0c04440e-1b6a-4e56-b456-205c571cdbaf"));

            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("227b968c-8391-4562-938d-2146ea86d8a7"));

            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("2d8618e8-fc0f-463e-9ef6-b856507356ea"));

            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("6e8be651-23c4-4c2e-a0e6-90bf5028e0fe"));

            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("77cfa73d-6153-46f8-9732-8eb790ee222f"));

            migrationBuilder.DeleteData(
                table: "StoreCategories",
                keyColumn: "Id",
                keyValue: new Guid("7b9ab5f3-1d3f-4c49-81fb-0e5105c3eaa9"));

            migrationBuilder.CreateTable(
                name: "LeadStoreCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<long>(nullable: false),
                    LeadId = table.Column<Guid>(nullable: false),
                    StoreCategoryId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadStoreCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeadStoreCategories_Leads_LeadId",
                        column: x => x.LeadId,
                        principalTable: "Leads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LeadStoreCategories_StoreCategories_StoreCategoryId",
                        column: x => x.StoreCategoryId,
                        principalTable: "StoreCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LeadStoreCategories_LeadId",
                table: "LeadStoreCategories",
                column: "LeadId");

            migrationBuilder.CreateIndex(
                name: "IX_LeadStoreCategories_StoreCategoryId",
                table: "LeadStoreCategories",
                column: "StoreCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Leads_Users_UserId",
                table: "Leads",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Leads_Users_UserId",
                table: "Leads");

            migrationBuilder.DropTable(
                name: "LeadStoreCategories");

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
                    { new Guid("227b968c-8391-4562-938d-2146ea86d8a7"), 0L, "Cooktop" },
                    { new Guid("2d8618e8-fc0f-463e-9ef6-b856507356ea"), 0L, "Cooking range" },
                    { new Guid("6e8be651-23c4-4c2e-a0e6-90bf5028e0fe"), 0L, "Chimney" },
                    { new Guid("77cfa73d-6153-46f8-9732-8eb790ee222f"), 0L, "Hobs" },
                    { new Guid("7b9ab5f3-1d3f-4c49-81fb-0e5105c3eaa9"), 0L, "Cookware" },
                    { new Guid("0c04440e-1b6a-4e56-b456-205c571cdbaf"), 0L, "Cooker" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Leads_Users_UserId",
                table: "Leads",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
