using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class TaxCategoryfix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6f1350b0-9c3c-420f-9acf-720f55cc6d94");

            migrationBuilder.DropColumn(
                name: "RelationshipStatus",
                table: "UserProfiles");

            migrationBuilder.AddColumn<int>(
                name: "TaxCategory",
                table: "UserProfiles",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b816597e-fc8f-459f-8d6e-ed812769df43", null, "Admin", "ADMIN" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b816597e-fc8f-459f-8d6e-ed812769df43");

            migrationBuilder.DropColumn(
                name: "TaxCategory",
                table: "UserProfiles");

            migrationBuilder.AddColumn<string>(
                name: "RelationshipStatus",
                table: "UserProfiles",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6f1350b0-9c3c-420f-9acf-720f55cc6d94", null, "Admin", "ADMIN" });
        }
    }
}
