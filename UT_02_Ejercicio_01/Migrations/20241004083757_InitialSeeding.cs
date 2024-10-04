using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UT_02_Ejercicio_01.Migrations
{
    /// <inheritdoc />
    public partial class InitialSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Car",
                columns: new[] { "Id", "Brand", "Model", "Price", "ReleaseDate" },
                values: new object[,]
                {
                    { 1, "Seat", "Ibiza", 20000m, new DateTime(2002, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Leon", "Ibiza", 22000m, new DateTime(2002, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Megane", "Renault", 25000m, new DateTime(2012, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Car",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Car",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Car",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
