using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameWork_LINQ_Project.Migrations
{
    /// <inheritdoc />
    public partial class DefaultValueToPriorityV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Priority",
                table: "TaskItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Low",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddCheckConstraint(
                name: "CHK_TaskItem_Priority",
                table: "TaskItems",
                sql: "Priority IN ('Low', 'Medium', 'High')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CHK_TaskItem_Priority",
                table: "TaskItems");

            migrationBuilder.AlterColumn<string>(
                name: "Priority",
                table: "TaskItems",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Low");
        }
    }
}
