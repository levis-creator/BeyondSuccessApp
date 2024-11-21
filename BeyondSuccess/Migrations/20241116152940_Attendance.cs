using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeyondSuccessWeb.Migrations
{
    /// <inheritdoc />
    public partial class Attendance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MemberProgress");

            migrationBuilder.AddColumn<int>(
                name: "ProgressId",
                table: "Members",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Cohorts",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 11, 16, 18, 29, 40, 283, DateTimeKind.Local).AddTicks(8367));

            migrationBuilder.UpdateData(
                table: "Cohorts",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 11, 16, 18, 29, 40, 283, DateTimeKind.Local).AddTicks(8388));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 11, 16, 18, 29, 40, 283, DateTimeKind.Local).AddTicks(8620));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 11, 16, 18, 29, 40, 283, DateTimeKind.Local).AddTicks(8623));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 11, 16, 18, 29, 40, 283, DateTimeKind.Local).AddTicks(8625));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2024, 11, 16, 18, 29, 40, 283, DateTimeKind.Local).AddTicks(8629));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ProgressId", "UpdatedAt" },
                values: new object[] { null, new DateTime(2024, 11, 16, 18, 29, 40, 283, DateTimeKind.Local).AddTicks(8589) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ProgressId", "UpdatedAt" },
                values: new object[] { null, new DateTime(2024, 11, 16, 18, 29, 40, 283, DateTimeKind.Local).AddTicks(8593) });

            migrationBuilder.UpdateData(
                table: "Progresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 11, 16, 18, 29, 40, 283, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "Progresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 11, 16, 18, 29, 40, 283, DateTimeKind.Local).AddTicks(8684));

            migrationBuilder.UpdateData(
                table: "Progresses",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 11, 16, 18, 29, 40, 283, DateTimeKind.Local).AddTicks(8687));

            migrationBuilder.CreateIndex(
                name: "IX_Members_ProgressId",
                table: "Members",
                column: "ProgressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Members_Progresses_ProgressId",
                table: "Members",
                column: "ProgressId",
                principalTable: "Progresses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Members_Progresses_ProgressId",
                table: "Members");

            migrationBuilder.DropIndex(
                name: "IX_Members_ProgressId",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "ProgressId",
                table: "Members");

            migrationBuilder.CreateTable(
                name: "MemberProgress",
                columns: table => new
                {
                    MembersPresentId = table.Column<int>(type: "int", nullable: false),
                    ProgressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberProgress", x => new { x.MembersPresentId, x.ProgressId });
                    table.ForeignKey(
                        name: "FK_MemberProgress_Members_MembersPresentId",
                        column: x => x.MembersPresentId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MemberProgress_Progresses_ProgressId",
                        column: x => x.ProgressId,
                        principalTable: "Progresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Cohorts",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 11, 16, 17, 43, 38, 624, DateTimeKind.Local).AddTicks(2183));

            migrationBuilder.UpdateData(
                table: "Cohorts",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 11, 16, 17, 43, 38, 624, DateTimeKind.Local).AddTicks(2202));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 11, 16, 17, 43, 38, 624, DateTimeKind.Local).AddTicks(2466));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 11, 16, 17, 43, 38, 624, DateTimeKind.Local).AddTicks(2468));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 11, 16, 17, 43, 38, 624, DateTimeKind.Local).AddTicks(2470));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedAt",
                value: new DateTime(2024, 11, 16, 17, 43, 38, 624, DateTimeKind.Local).AddTicks(2473));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 11, 16, 17, 43, 38, 624, DateTimeKind.Local).AddTicks(2437));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 11, 16, 17, 43, 38, 624, DateTimeKind.Local).AddTicks(2442));

            migrationBuilder.UpdateData(
                table: "Progresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2024, 11, 16, 17, 43, 38, 624, DateTimeKind.Local).AddTicks(2498));

            migrationBuilder.UpdateData(
                table: "Progresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2024, 11, 16, 17, 43, 38, 624, DateTimeKind.Local).AddTicks(2503));

            migrationBuilder.UpdateData(
                table: "Progresses",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2024, 11, 16, 17, 43, 38, 624, DateTimeKind.Local).AddTicks(2505));

            migrationBuilder.CreateIndex(
                name: "IX_MemberProgress_ProgressId",
                table: "MemberProgress",
                column: "ProgressId");
        }
    }
}
