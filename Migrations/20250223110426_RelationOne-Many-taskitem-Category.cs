using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameWork_LINQ_Project.Migrations
{
    /// <inheritdoc />
    public partial class RelationOneManytaskitemCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "categoryId",
                table: "TaskItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TaskItems_categoryId",
                table: "TaskItems",
                column: "categoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskItems_Categories_categoryId",
                table: "TaskItems",
                column: "categoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskItems_Categories_categoryId",
                table: "TaskItems");

            migrationBuilder.DropIndex(
                name: "IX_TaskItems_categoryId",
                table: "TaskItems");

            migrationBuilder.DropColumn(
                name: "categoryId",
                table: "TaskItems");
        }
    }
}
