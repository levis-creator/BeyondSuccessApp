using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeyondSuccessWeb.Migrations
{
    /// <inheritdoc />
    public partial class ProgressUpdate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Remarks",
                table: "Progresses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Cohorts",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 11, 8, 23, 22, 29, 398, DateTimeKind.Local).AddTicks(7461));

            migrationBuilder.UpdateData(
                table: "Cohorts",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 11, 8, 23, 22, 29, 398, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 11, 8, 23, 22, 29, 398, DateTimeKind.Local).AddTicks(7655));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 11, 8, 23, 22, 29, 398, DateTimeKind.Local).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 11, 8, 23, 22, 29, 398, DateTimeKind.Local).AddTicks(7659));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2024, 11, 8, 23, 22, 29, 398, DateTimeKind.Local).AddTicks(7660));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 11, 8, 23, 22, 29, 398, DateTimeKind.Local).AddTicks(7628));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 11, 8, 23, 22, 29, 398, DateTimeKind.Local).AddTicks(7631));

            migrationBuilder.UpdateData(
                table: "Progresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 11, 8, 23, 22, 29, 398, DateTimeKind.Local).AddTicks(7683));

            migrationBuilder.UpdateData(
                table: "Progresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 11, 8, 23, 22, 29, 398, DateTimeKind.Local).AddTicks(7687));

            migrationBuilder.UpdateData(
                table: "Progresses",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 11, 8, 23, 22, 29, 398, DateTimeKind.Local).AddTicks(7689));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Remarks",
                table: "Progresses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
                column: "UpdatedAt",
                value: new DateTime(2024, 11, 8, 22, 37, 39, 767, DateTimeKind.Local).AddTicks(1135));

            migrationBuilder.UpdateData(
                table: "Progresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 11, 8, 22, 37, 39, 767, DateTimeKind.Local).AddTicks(1139));

            migrationBuilder.UpdateData(
                table: "Progresses",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 11, 8, 22, 37, 39, 767, DateTimeKind.Local).AddTicks(1141));
        }
    }
}
