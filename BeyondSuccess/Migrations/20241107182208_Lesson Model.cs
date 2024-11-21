using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeyondSuccessWeb.Migrations
{
    /// <inheritdoc />
    public partial class LessonModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LessonTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LessonDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Cohorts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 7, 21, 22, 7, 223, DateTimeKind.Local).AddTicks(8100), new DateTime(2024, 11, 7, 21, 22, 7, 223, DateTimeKind.Local).AddTicks(8087) });

            migrationBuilder.UpdateData(
                table: "Cohorts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 7, 21, 22, 7, 223, DateTimeKind.Local).AddTicks(8109), new DateTime(2024, 11, 7, 21, 22, 7, 223, DateTimeKind.Local).AddTicks(8109) });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "CreatedAt", "LessonDescription", "LessonTitle", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 7, 21, 22, 7, 223, DateTimeKind.Local).AddTicks(8284), "", "lesson 1", new DateTime(2024, 11, 7, 21, 22, 7, 223, DateTimeKind.Local).AddTicks(8283) },
                    { 2, new DateTime(2024, 11, 7, 21, 22, 7, 223, DateTimeKind.Local).AddTicks(8286), "", "lesson 2", new DateTime(2024, 11, 7, 21, 22, 7, 223, DateTimeKind.Local).AddTicks(8285) },
                    { 3, new DateTime(2024, 11, 7, 21, 22, 7, 223, DateTimeKind.Local).AddTicks(8287), "", "lesson 3", new DateTime(2024, 11, 7, 21, 22, 7, 223, DateTimeKind.Local).AddTicks(8287) },
                    { 4, new DateTime(2024, 11, 7, 21, 22, 7, 223, DateTimeKind.Local).AddTicks(8289), "", "lesson 4", new DateTime(2024, 11, 7, 21, 22, 7, 223, DateTimeKind.Local).AddTicks(8289) }
                });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 7, 21, 22, 7, 223, DateTimeKind.Local).AddTicks(8256), new DateTime(2024, 11, 7, 21, 22, 7, 223, DateTimeKind.Local).AddTicks(8255) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 7, 21, 22, 7, 223, DateTimeKind.Local).AddTicks(8259), new DateTime(2024, 11, 7, 21, 22, 7, 223, DateTimeKind.Local).AddTicks(8259) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lessons");

            migrationBuilder.UpdateData(
                table: "Cohorts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 19, 39, 34, 120, DateTimeKind.Local).AddTicks(7690), new DateTime(2024, 11, 6, 19, 39, 34, 120, DateTimeKind.Local).AddTicks(7680) });

            migrationBuilder.UpdateData(
                table: "Cohorts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 19, 39, 34, 120, DateTimeKind.Local).AddTicks(7698), new DateTime(2024, 11, 6, 19, 39, 34, 120, DateTimeKind.Local).AddTicks(7697) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 19, 39, 34, 120, DateTimeKind.Local).AddTicks(7820), new DateTime(2024, 11, 6, 19, 39, 34, 120, DateTimeKind.Local).AddTicks(7819) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 19, 39, 34, 120, DateTimeKind.Local).AddTicks(7823), new DateTime(2024, 11, 6, 19, 39, 34, 120, DateTimeKind.Local).AddTicks(7823) });
        }
    }
}
