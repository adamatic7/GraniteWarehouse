using Microsoft.EntityFrameworkCore.Migrations;

namespace GraniteWarehouse.Data.Migrations
{
    public partial class AddedProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_SpecialTags_SpecialTagId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_SpecialTagId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SpecialTagId",
                table: "Products");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SpecialTagsId",
                table: "Products",
                column: "SpecialTagsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_SpecialTags_SpecialTagsId",
                table: "Products",
                column: "SpecialTagsId",
                principalTable: "SpecialTags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_SpecialTags_SpecialTagsId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_SpecialTagsId",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "SpecialTagId",
                table: "Products",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_SpecialTagId",
                table: "Products",
                column: "SpecialTagId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_SpecialTags_SpecialTagId",
                table: "Products",
                column: "SpecialTagId",
                principalTable: "SpecialTags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
