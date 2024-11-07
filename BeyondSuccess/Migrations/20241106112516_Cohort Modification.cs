using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeyondSuccessWeb.Migrations
{
    /// <inheritdoc />
    public partial class CohortModification : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Cohorts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateOnly>(
                name: "StartDate",
                table: "Cohorts",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Cohorts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Cohorts",
                columns: new[] { "Id", "CohortDescription", "CohortName", "CreatedAt", "StartDate", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, null, "Cohort1", new DateTime(2024, 11, 6, 14, 25, 15, 901, DateTimeKind.Local).AddTicks(6053), new DateOnly(2002, 7, 27), new DateTime(2024, 11, 6, 14, 25, 15, 901, DateTimeKind.Local).AddTicks(6040) },
                    { 2, null, "Cohort2", new DateTime(2024, 11, 6, 14, 25, 15, 901, DateTimeKind.Local).AddTicks(6064), new DateOnly(2010, 7, 27), new DateTime(2024, 11, 6, 14, 25, 15, 901, DateTimeKind.Local).AddTicks(6063) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cohorts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cohorts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Cohorts");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Cohorts");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Cohorts");
        }
    }
}
