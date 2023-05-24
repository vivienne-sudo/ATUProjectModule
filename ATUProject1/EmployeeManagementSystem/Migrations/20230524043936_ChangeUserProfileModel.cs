using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class ChangeUserProfileModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
                migrationBuilder.AddColumn<int>(
                name: "AnnualLeaveDays",
                table: "UserProfiles",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SickLeaveDays",
                table: "UserProfiles",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d203da60-e5f8-4324-9e39-69ae8f3265af", null, "Admin", "ADMIN" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnnualLeaveDays",
                table: "UserProfiles");

            migrationBuilder.DropColumn(
                name: "SickLeaveDays",
                table: "UserProfiles");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dcb2abe2-d16f-4655-9746-35f65f9fc0d0", null, "Admin", "ADMIN" });
        }
    }
}
