using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VBV3Project.Migrations
{
    /// <inheritdoc />
    public partial class AddModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_BusinessOwner_BusinessOwnerId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_BusinessOwnerId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_BusinessOwnerId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BusinessOwner",
                table: "BusinessOwner");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "HasLoggedIn",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Employees");

            migrationBuilder.RenameTable(
                name: "BusinessOwner",
                newName: "BusinessOwners");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Users",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "EmailVerified",
                table: "Users",
                newName: "TwoFactorEnabled");

            migrationBuilder.RenameColumn(
                name: "EmailVerificationToken",
                table: "Users",
                newName: "BusinessOwnerId1");

            migrationBuilder.RenameColumn(
                name: "Role",
                table: "Employees",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "PasswordResetRequired",
                table: "Employees",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ConfirmPassword",
                table: "Employees",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "BusinessOwners",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "PasswordResetRequired",
                table: "BusinessOwners",
                newName: "TwoFactorEnabled");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "BusinessOwners",
                newName: "VerificationToken");

            migrationBuilder.RenameColumn(
                name: "HasLoggedIn",
                table: "BusinessOwners",
                newName: "PhoneNumberConfirmed");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Users",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Users",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BusinessAddress",
                table: "Users",
                type: "TEXT",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BusinessDescription",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BusinessName",
                table: "Users",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Users",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Eircode",
                table: "Users",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Users",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsEmailVerified",
                table: "Users",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Users",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Users",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Users",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Users",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Users",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Users",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Users",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Employees",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Employees",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<DateTime>(
                name: "HireDate",
                table: "Employees",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "BusinessOwners",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "BusinessOwners",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BusinessAddress",
                table: "BusinessOwners",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BusinessName",
                table: "BusinessOwners",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "BusinessOwners",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactPerson",
                table: "BusinessOwners",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Eircode",
                table: "BusinessOwners",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "BusinessOwners",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsVerified",
                table: "BusinessOwners",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "BusinessOwners",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "BusinessOwners",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "BusinessOwners",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "BusinessOwners",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "BusinessOwners",
                type: "TEXT",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "BusinessOwners",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProfileSummary",
                table: "BusinessOwners",
                type: "TEXT",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProfileTitle",
                table: "BusinessOwners",
                type: "TEXT",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "BusinessOwners",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BusinessOwners",
                table: "BusinessOwners",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Users_BusinessOwnerId1",
                table: "Users",
                column: "BusinessOwnerId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_BusinessOwners_BusinessOwnerId",
                table: "Employees",
                column: "BusinessOwnerId",
                principalTable: "BusinessOwners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_BusinessOwnerId1",
                table: "Users",
                column: "BusinessOwnerId1",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_BusinessOwners_BusinessOwnerId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_BusinessOwnerId1",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_BusinessOwnerId1",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BusinessOwners",
                table: "BusinessOwners");

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "BusinessAddress",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "BusinessDescription",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "BusinessName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Eircode",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsEmailVerified",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "HireDate",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "BusinessOwners");

            migrationBuilder.DropColumn(
                name: "BusinessAddress",
                table: "BusinessOwners");

            migrationBuilder.DropColumn(
                name: "BusinessName",
                table: "BusinessOwners");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "BusinessOwners");

            migrationBuilder.DropColumn(
                name: "ContactPerson",
                table: "BusinessOwners");

            migrationBuilder.DropColumn(
                name: "Eircode",
                table: "BusinessOwners");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "BusinessOwners");

            migrationBuilder.DropColumn(
                name: "IsVerified",
                table: "BusinessOwners");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "BusinessOwners");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "BusinessOwners");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "BusinessOwners");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "BusinessOwners");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "BusinessOwners");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "BusinessOwners");

            migrationBuilder.DropColumn(
                name: "ProfileSummary",
                table: "BusinessOwners");

            migrationBuilder.DropColumn(
                name: "ProfileTitle",
                table: "BusinessOwners");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "BusinessOwners");

            migrationBuilder.RenameTable(
                name: "BusinessOwners",
                newName: "BusinessOwner");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Users",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "TwoFactorEnabled",
                table: "Users",
                newName: "EmailVerified");

            migrationBuilder.RenameColumn(
                name: "BusinessOwnerId1",
                table: "Users",
                newName: "EmailVerificationToken");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Employees",
                newName: "ConfirmPassword");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Employees",
                newName: "Role");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Employees",
                newName: "PasswordResetRequired");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "BusinessOwner",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "VerificationToken",
                table: "BusinessOwner",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "TwoFactorEnabled",
                table: "BusinessOwner",
                newName: "PasswordResetRequired");

            migrationBuilder.RenameColumn(
                name: "PhoneNumberConfirmed",
                table: "BusinessOwner",
                newName: "HasLoggedIn");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Users",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Employees",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "PasswordResetRequired",
                table: "Employees",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Employees",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<bool>(
                name: "HasLoggedIn",
                table: "Employees",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Employees",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "BusinessOwner",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BusinessOwner",
                table: "BusinessOwner",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Users_BusinessOwnerId",
                table: "Users",
                column: "BusinessOwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_BusinessOwner_BusinessOwnerId",
                table: "Employees",
                column: "BusinessOwnerId",
                principalTable: "BusinessOwner",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_BusinessOwnerId",
                table: "Users",
                column: "BusinessOwnerId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
