using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 16, 47, 41, 731, DateTimeKind.Local).AddTicks(6827), new DateTime(2024, 11, 18, 16, 47, 41, 731, DateTimeKind.Local).AddTicks(6839), "Black", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 16, 47, 41, 731, DateTimeKind.Local).AddTicks(6841), new DateTime(2024, 11, 18, 16, 47, 41, 731, DateTimeKind.Local).AddTicks(6842), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 16, 47, 41, 731, DateTimeKind.Local).AddTicks(7000), new DateTime(2024, 11, 18, 16, 47, 41, 731, DateTimeKind.Local).AddTicks(7000), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 16, 47, 41, 731, DateTimeKind.Local).AddTicks(7002), new DateTime(2024, 11, 18, 16, 47, 41, 731, DateTimeKind.Local).AddTicks(7002), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 16, 47, 41, 731, DateTimeKind.Local).AddTicks(7080), new DateTime(2024, 11, 18, 16, 47, 41, 731, DateTimeKind.Local).AddTicks(7080), "i4", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 16, 47, 41, 731, DateTimeKind.Local).AddTicks(7082), new DateTime(2024, 11, 18, 16, 47, 41, 731, DateTimeKind.Local).AddTicks(7082), "X5", "System" },
                    { 3, "System", new DateTime(2024, 11, 18, 16, 47, 41, 731, DateTimeKind.Local).AddTicks(7083), new DateTime(2024, 11, 18, 16, 47, 41, 731, DateTimeKind.Local).AddTicks(7084), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 11, 18, 16, 47, 41, 731, DateTimeKind.Local).AddTicks(7085), new DateTime(2024, 11, 18, 16, 47, 41, 731, DateTimeKind.Local).AddTicks(7085), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
