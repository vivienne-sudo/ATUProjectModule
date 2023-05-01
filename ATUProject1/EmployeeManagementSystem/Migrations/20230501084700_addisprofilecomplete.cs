using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class addisprofilecomplete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "757cf75b-f39f-4bc3-8916-ec589dca65a1");

            migrationBuilder.AddColumn<bool>(
                name: "IsProfileComplete",
                table: "UserProfiles",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "24064e60-1caa-48d2-ba07-b2a72a7ef209", null, "Admin", "ADMIN" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24064e60-1caa-48d2-ba07-b2a72a7ef209");

            migrationBuilder.DropColumn(
                name: "IsProfileComplete",
                table: "UserProfiles");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "757cf75b-f39f-4bc3-8916-ec589dca65a1", null, "Admin", "ADMIN" });
        }
    }
}
