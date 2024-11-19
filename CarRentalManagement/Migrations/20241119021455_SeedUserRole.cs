using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "2b83b334-ae06-4ed0-a187-ebd41e79538e", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEEZ7eWr+c550RulnOUvBye+XQAuKIK7raC/SAK0Ma+6RtWNlcyTHOF72ZT/NmqlwgA==", null, false, "4214a6da-d632-464e-b9aa-debc880c5a11", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 10, 14, 54, 495, DateTimeKind.Local).AddTicks(5068), new DateTime(2024, 11, 19, 10, 14, 54, 495, DateTimeKind.Local).AddTicks(5079) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 10, 14, 54, 495, DateTimeKind.Local).AddTicks(5081), new DateTime(2024, 11, 19, 10, 14, 54, 495, DateTimeKind.Local).AddTicks(5081) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 10, 14, 54, 495, DateTimeKind.Local).AddTicks(5242), new DateTime(2024, 11, 19, 10, 14, 54, 495, DateTimeKind.Local).AddTicks(5242) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 10, 14, 54, 495, DateTimeKind.Local).AddTicks(5244), new DateTime(2024, 11, 19, 10, 14, 54, 495, DateTimeKind.Local).AddTicks(5244) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 10, 14, 54, 495, DateTimeKind.Local).AddTicks(5353), new DateTime(2024, 11, 19, 10, 14, 54, 495, DateTimeKind.Local).AddTicks(5353) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 10, 14, 54, 495, DateTimeKind.Local).AddTicks(5355), new DateTime(2024, 11, 19, 10, 14, 54, 495, DateTimeKind.Local).AddTicks(5355) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 10, 14, 54, 495, DateTimeKind.Local).AddTicks(5356), new DateTime(2024, 11, 19, 10, 14, 54, 495, DateTimeKind.Local).AddTicks(5357) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 19, 10, 14, 54, 495, DateTimeKind.Local).AddTicks(5358), new DateTime(2024, 11, 19, 10, 14, 54, 495, DateTimeKind.Local).AddTicks(5358) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 46, 26, 519, DateTimeKind.Local).AddTicks(7536), new DateTime(2024, 11, 18, 17, 46, 26, 519, DateTimeKind.Local).AddTicks(7550) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 46, 26, 519, DateTimeKind.Local).AddTicks(7552), new DateTime(2024, 11, 18, 17, 46, 26, 519, DateTimeKind.Local).AddTicks(7553) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 46, 26, 519, DateTimeKind.Local).AddTicks(7832), new DateTime(2024, 11, 18, 17, 46, 26, 519, DateTimeKind.Local).AddTicks(7833) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 46, 26, 519, DateTimeKind.Local).AddTicks(7834), new DateTime(2024, 11, 18, 17, 46, 26, 519, DateTimeKind.Local).AddTicks(7835) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 46, 26, 519, DateTimeKind.Local).AddTicks(7976), new DateTime(2024, 11, 18, 17, 46, 26, 519, DateTimeKind.Local).AddTicks(7976) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 46, 26, 519, DateTimeKind.Local).AddTicks(7978), new DateTime(2024, 11, 18, 17, 46, 26, 519, DateTimeKind.Local).AddTicks(7978) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 46, 26, 519, DateTimeKind.Local).AddTicks(7979), new DateTime(2024, 11, 18, 17, 46, 26, 519, DateTimeKind.Local).AddTicks(7980) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 46, 26, 519, DateTimeKind.Local).AddTicks(7981), new DateTime(2024, 11, 18, 17, 46, 26, 519, DateTimeKind.Local).AddTicks(7981) });
        }
    }
}
