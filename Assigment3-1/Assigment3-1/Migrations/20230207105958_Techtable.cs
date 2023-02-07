using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assigment31.Migrations
{
    /// <inheritdoc />
    public partial class Techtable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearlyPrice = table.Column<decimal>(type: "decimal(11,2)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                });

            migrationBuilder.CreateTable(
                name: "technicians",
                columns: table => new
                {
                    TechnicianID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_technicians", x => x.TechnicianID);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "ProductCode", "ProductName", "ReleaseDate", "YearlyPrice" },
                values: new object[,]
                {
                    { 1, "DRAFT10", "Draft Manager 1.0", new DateTime(2017, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.99m },
                    { 2, "DRAFT20", "Draft Manager 2.0", new DateTime(2019, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.99m },
                    { 3, "LEAG10", "League Scheduler 1.0", new DateTime(2016, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.99m },
                    { 4, "LEAGD10", "League Scheduler Deluxe 1.0", new DateTime(2016, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.99m },
                    { 5, "TEAM10", "Team Manager 1.0", new DateTime(2017, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.99m },
                    { 6, "TRNY10", "Tournament Master 1.0", new DateTime(2015, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.99m },
                    { 7, "TRNY20", "Tournament Master 2.0", new DateTime(2018, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.99m }
                });

            migrationBuilder.InsertData(
                table: "technicians",
                columns: new[] { "TechnicianID", "Email", "Name", "Phone", "ReleaseDate" },
                values: new object[,]
                {
                    { 11, "alison@sportsprosoftware.com", "Alison Diaz", "800-555-0443", new DateTime(2023, 2, 7, 4, 59, 58, 475, DateTimeKind.Local).AddTicks(6040) },
                    { 12, "jason@sportsprosoftware.com", "Jason Lee", "800-555-0444", new DateTime(2023, 2, 7, 4, 59, 58, 475, DateTimeKind.Local).AddTicks(6044) },
                    { 13, "awilson@sportsprosoftware.com", "Andrew Wilson", "800-555-0449", new DateTime(2023, 2, 7, 4, 59, 58, 475, DateTimeKind.Local).AddTicks(6045) },
                    { 14, "gunter@sportsprosoftware.com", "Gunter Wendt", "800-555-0400", new DateTime(2023, 2, 7, 4, 59, 58, 475, DateTimeKind.Local).AddTicks(6046) },
                    { 15, "gfiori@sportsprosoftware.com", "Gina Fiori", "800-555-0459", new DateTime(2023, 2, 7, 4, 59, 58, 475, DateTimeKind.Local).AddTicks(6048) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "technicians");
        }
    }
}
