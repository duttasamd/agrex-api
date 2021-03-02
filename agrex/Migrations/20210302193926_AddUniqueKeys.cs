using Microsoft.EntityFrameworkCore.Migrations;

namespace agrex.Migrations
{
    public partial class AddUniqueKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Item",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemType_Name",
                table: "ItemType",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemSubType_Name",
                table: "ItemSubType",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemCategory_Name",
                table: "ItemCategory",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Item_Name",
                table: "Item",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ItemType_Name",
                table: "ItemType");

            migrationBuilder.DropIndex(
                name: "IX_ItemSubType_Name",
                table: "ItemSubType");

            migrationBuilder.DropIndex(
                name: "IX_ItemCategory_Name",
                table: "ItemCategory");

            migrationBuilder.DropIndex(
                name: "IX_Item_Name",
                table: "Item");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Item",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
