using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameWork_LINQ_Project.Migrations
{
    /// <inheritdoc />
    public partial class RelationOneManytaskitemuserv3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskItems_Users_UserId",
                table: "TaskItems");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "TaskItems",
                newName: "userId");

            migrationBuilder.RenameIndex(
                name: "IX_TaskItems_UserId",
                table: "TaskItems",
                newName: "IX_TaskItems_userId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskItems_Users_userId",
                table: "TaskItems",
                column: "userId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskItems_Users_userId",
                table: "TaskItems");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "TaskItems",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_TaskItems_userId",
                table: "TaskItems",
                newName: "IX_TaskItems_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskItems_Users_UserId",
                table: "TaskItems",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
