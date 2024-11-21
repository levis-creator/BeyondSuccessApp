using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeyondSuccessWeb.Migrations
{
    /// <inheritdoc />
    public partial class ProgressAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Progresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LessonId = table.Column<int>(type: "int", nullable: false),
                    CohortId = table.Column<int>(type: "int", nullable: false),
                    CompletedOnDate = table.Column<DateOnly>(type: "date", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Progresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Progresses_Cohorts_CohortId",
                        column: x => x.CohortId,
                        principalTable: "Cohorts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Progresses_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Cohorts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 15, 26, 58, 305, DateTimeKind.Local).AddTicks(9139), new DateTime(2024, 11, 8, 15, 26, 58, 305, DateTimeKind.Local).AddTicks(9126) });

            migrationBuilder.UpdateData(
                table: "Cohorts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 15, 26, 58, 305, DateTimeKind.Local).AddTicks(9149), new DateTime(2024, 11, 8, 15, 26, 58, 305, DateTimeKind.Local).AddTicks(9148) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 15, 26, 58, 305, DateTimeKind.Local).AddTicks(9360), new DateTime(2024, 11, 8, 15, 26, 58, 305, DateTimeKind.Local).AddTicks(9359) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 15, 26, 58, 305, DateTimeKind.Local).AddTicks(9363), new DateTime(2024, 11, 8, 15, 26, 58, 305, DateTimeKind.Local).AddTicks(9363) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 15, 26, 58, 305, DateTimeKind.Local).AddTicks(9366), new DateTime(2024, 11, 8, 15, 26, 58, 305, DateTimeKind.Local).AddTicks(9365) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 15, 26, 58, 305, DateTimeKind.Local).AddTicks(9367), new DateTime(2024, 11, 8, 15, 26, 58, 305, DateTimeKind.Local).AddTicks(9367) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 15, 26, 58, 305, DateTimeKind.Local).AddTicks(9312), new DateTime(2024, 11, 8, 15, 26, 58, 305, DateTimeKind.Local).AddTicks(9311) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 15, 26, 58, 305, DateTimeKind.Local).AddTicks(9316), new DateTime(2024, 11, 8, 15, 26, 58, 305, DateTimeKind.Local).AddTicks(9316) });

            migrationBuilder.InsertData(
                table: "Progresses",
                columns: new[] { "Id", "CohortId", "CompletedOnDate", "CreatedAt", "LessonId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 2, new DateOnly(2001, 7, 27), new DateTime(2024, 11, 8, 15, 26, 58, 305, DateTimeKind.Local).AddTicks(9613), 1, new DateTime(2024, 11, 8, 15, 26, 58, 305, DateTimeKind.Local).AddTicks(9612) },
                    { 2, 2, new DateOnly(2019, 7, 27), new DateTime(2024, 11, 8, 15, 26, 58, 305, DateTimeKind.Local).AddTicks(9617), 2, new DateTime(2024, 11, 8, 15, 26, 58, 305, DateTimeKind.Local).AddTicks(9616) },
                    { 3, 2, new DateOnly(2029, 7, 27), new DateTime(2024, 11, 8, 15, 26, 58, 305, DateTimeKind.Local).AddTicks(9619), 3, new DateTime(2024, 11, 8, 15, 26, 58, 305, DateTimeKind.Local).AddTicks(9619) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Progresses_CohortId",
                table: "Progresses",
                column: "CohortId");

            migrationBuilder.CreateIndex(
                name: "IX_Progresses_LessonId",
                table: "Progresses",
                column: "LessonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Progresses");

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

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 7, 21, 22, 7, 223, DateTimeKind.Local).AddTicks(8284), new DateTime(2024, 11, 7, 21, 22, 7, 223, DateTimeKind.Local).AddTicks(8283) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 7, 21, 22, 7, 223, DateTimeKind.Local).AddTicks(8286), new DateTime(2024, 11, 7, 21, 22, 7, 223, DateTimeKind.Local).AddTicks(8285) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 7, 21, 22, 7, 223, DateTimeKind.Local).AddTicks(8287), new DateTime(2024, 11, 7, 21, 22, 7, 223, DateTimeKind.Local).AddTicks(8287) });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 7, 21, 22, 7, 223, DateTimeKind.Local).AddTicks(8289), new DateTime(2024, 11, 7, 21, 22, 7, 223, DateTimeKind.Local).AddTicks(8289) });

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
    }
}
