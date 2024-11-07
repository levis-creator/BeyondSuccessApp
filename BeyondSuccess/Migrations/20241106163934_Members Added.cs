using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeyondSuccessWeb.Migrations
{
    /// <inheritdoc />
    public partial class MembersAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CohortId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Members_Cohorts_CohortId",
                        column: x => x.CohortId,
                        principalTable: "Cohorts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "CohortId", "CreatedAt", "EmailAddress", "FirstName", "LastName", "PhoneNumber", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2024, 11, 6, 19, 39, 34, 120, DateTimeKind.Local).AddTicks(7820), "eluid@email.com", "Eluid", "Kipchoge", "+2548708988", new DateTime(2024, 11, 6, 19, 39, 34, 120, DateTimeKind.Local).AddTicks(7819) },
                    { 2, 2, new DateTime(2024, 11, 6, 19, 39, 34, 120, DateTimeKind.Local).AddTicks(7823), "kinyanjuiSimon@email.com", "Simon", "Kinyanjui", "+2548708988", new DateTime(2024, 11, 6, 19, 39, 34, 120, DateTimeKind.Local).AddTicks(7823) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Members_CohortId",
                table: "Members",
                column: "CohortId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.UpdateData(
                table: "Cohorts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 14, 25, 15, 901, DateTimeKind.Local).AddTicks(6053), new DateTime(2024, 11, 6, 14, 25, 15, 901, DateTimeKind.Local).AddTicks(6040) });

            migrationBuilder.UpdateData(
                table: "Cohorts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 14, 25, 15, 901, DateTimeKind.Local).AddTicks(6064), new DateTime(2024, 11, 6, 14, 25, 15, 901, DateTimeKind.Local).AddTicks(6063) });
        }
    }
}
