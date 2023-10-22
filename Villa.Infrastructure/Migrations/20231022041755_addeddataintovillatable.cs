using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Villa.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addeddataintovillatable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Created_Date", "Description", "ImageUrl", "Name", "Occupancy", "Updated_Date", "price", "sqft" },
                values: new object[,]
                {
                    { 1, null, "Villa 1", "", "Royal Villa", 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 200.0, 500 },
                    { 2, null, "Villa 2", "", "Pool Villa", 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 400.0, 900 },
                    { 3, null, "Villa 3", "", " Sun Villa", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 300.0, 400 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
