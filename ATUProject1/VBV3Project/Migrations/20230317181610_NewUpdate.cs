using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VBV3Project.Migrations
{
    /// <inheritdoc />
    public partial class NewUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_BusinessOwnerId1",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_BusinessOwnerId1",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "BusinessOwnerId1",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "BusinessOwnerId",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BusinessOwnerIdNumber",
                table: "Users",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_BusinessOwnerId",
                table: "Users",
                column: "BusinessOwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_BusinessOwnerId",
                table: "Users",
                column: "BusinessOwnerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_BusinessOwnerId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_BusinessOwnerId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "BusinessOwnerIdNumber",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "BusinessOwnerId",
                table: "Users",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "BusinessOwnerId1",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Users_BusinessOwnerId1",
                table: "Users",
                column: "BusinessOwnerId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_BusinessOwnerId1",
                table: "Users",
                column: "BusinessOwnerId1",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
