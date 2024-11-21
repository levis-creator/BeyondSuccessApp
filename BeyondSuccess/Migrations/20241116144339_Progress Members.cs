using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeyondSuccessWeb.Migrations
{
    /// <inheritdoc />
    public partial class ProgressMembers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MemberProgress");

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
    }
}
