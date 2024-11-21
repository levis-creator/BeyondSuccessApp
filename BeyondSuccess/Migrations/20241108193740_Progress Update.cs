using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeyondSuccessWeb.Migrations
{
    /// <inheritdoc />
    public partial class ProgressUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Progresses");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Lessons");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Cohorts");

            migrationBuilder.AddColumn<string>(
                name: "Remarks",
                table: "Progresses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Cohorts",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 11, 8, 22, 37, 39, 767, DateTimeKind.Local).AddTicks(687));

            migrationBuilder.UpdateData(
                table: "Cohorts",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 11, 8, 22, 37, 39, 767, DateTimeKind.Local).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 11, 8, 22, 37, 39, 767, DateTimeKind.Local).AddTicks(1095));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 11, 8, 22, 37, 39, 767, DateTimeKind.Local).AddTicks(1099));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 11, 8, 22, 37, 39, 767, DateTimeKind.Local).AddTicks(1101));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2024, 11, 8, 22, 37, 39, 767, DateTimeKind.Local).AddTicks(1103));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 11, 8, 22, 37, 39, 767, DateTimeKind.Local).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 11, 8, 22, 37, 39, 767, DateTimeKind.Local).AddTicks(1003));

            migrationBuilder.UpdateData(
                table: "Progresses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Remarks", "UpdatedAt" },
                values: new object[] { "", new DateTime(2024, 11, 8, 22, 37, 39, 767, DateTimeKind.Local).AddTicks(1135) });

            migrationBuilder.UpdateData(
                table: "Progresses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Remarks", "UpdatedAt" },
                values: new object[] { "", new DateTime(2024, 11, 8, 22, 37, 39, 767, DateTimeKind.Local).AddTicks(1139) });

            migrationBuilder.UpdateData(
                table: "Progresses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Remarks", "UpdatedAt" },
                values: new object[] { "", new DateTime(2024, 11, 8, 22, 37, 39, 767, DateTimeKind.Local).AddTicks(1141) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Remarks",
                table: "Progresses");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Progresses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Members",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Lessons",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Cohorts",
                type: "datetime2",
                nullable: true);

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

            migrationBuilder.UpdateData(
                table: "Progresses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 15, 26, 58, 305, DateTimeKind.Local).AddTicks(9613), new DateTime(2024, 11, 8, 15, 26, 58, 305, DateTimeKind.Local).AddTicks(9612) });

            migrationBuilder.UpdateData(
                table: "Progresses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 15, 26, 58, 305, DateTimeKind.Local).AddTicks(9617), new DateTime(2024, 11, 8, 15, 26, 58, 305, DateTimeKind.Local).AddTicks(9616) });

            migrationBuilder.UpdateData(
                table: "Progresses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 15, 26, 58, 305, DateTimeKind.Local).AddTicks(9619), new DateTime(2024, 11, 8, 15, 26, 58, 305, DateTimeKind.Local).AddTicks(9619) });
        }
    }
}
