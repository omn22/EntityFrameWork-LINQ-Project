using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameWork_LINQ_Project.Migrations
{
    /// <inheritdoc />
    public partial class RelationOneManytaskitemuserv4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskItems_Users_userId",
                table: "TaskItems");

            migrationBuilder.AlterColumn<int>(
                name: "userId",
                table: "TaskItems",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskItems_Users_userId",
                table: "TaskItems",
                column: "userId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskItems_Users_userId",
                table: "TaskItems");

            migrationBuilder.AlterColumn<int>(
                name: "userId",
                table: "TaskItems",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskItems_Users_userId",
                table: "TaskItems",
                column: "userId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
