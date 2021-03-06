using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoListAPI.Migrations
{
    public partial class UpdateTask4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Users_AddedByUserId",
                table: "Tasks");

            migrationBuilder.AlterColumn<int>(
                name: "AddedByUserId",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Users_AddedByUserId",
                table: "Tasks",
                column: "AddedByUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Users_AddedByUserId",
                table: "Tasks");

            migrationBuilder.AlterColumn<int>(
                name: "AddedByUserId",
                table: "Tasks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Users_AddedByUserId",
                table: "Tasks",
                column: "AddedByUserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
