using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FreakFightsFan.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class Fight_VideoUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VideoUrl",
                table: "Fights",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(210), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(210) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(213), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(214) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(216), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(216) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(218), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(218) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(220), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(221) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(224), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(225) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(226), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(227) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(228), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(229) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(230), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(231) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(233), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(233) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(235), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(235) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(237), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(237) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(239), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(239) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(241), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(241) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(243), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(243) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(245), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(245) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(247), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(247) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(250), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(250) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(252), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(252) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(254), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(254) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(255), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(256) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(257), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(258) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(259), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(260) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(261), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(262) });

            migrationBuilder.UpdateData(
                table: "Federations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(175), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(176) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9501), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9502) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9507), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9508) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9510), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9510) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9512), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9512) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9513), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9514) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9516), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9516) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9517), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9518) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9519), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9520) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9521), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9521) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9523), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9524) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9525), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9525) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9527), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9527) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9529), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9529) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9531), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9531) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9532), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9533) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9534), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9534) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9536), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9536) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9538), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9538) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9540), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9540) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9541), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9542) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9544), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9544) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9545), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9546) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9547), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9547) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9549), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9549) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9550), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9551) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9552), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9552) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9554), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9554) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9555), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9556) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9557), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9557) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9559), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9559) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9560), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9561) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9562), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9562) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9564), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9564) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9566), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9567) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9568), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9568) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9570), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9570) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9571), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9572) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9573), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9573) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9574), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9575) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9625), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9626) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9628), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9628) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9629), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9630) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9631), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9632) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9633), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9633) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9634), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9635) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9636), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9637) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9638), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9638) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9639), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9641), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9641) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9643), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9643) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9644), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9645) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9646), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9646) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9648), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9648) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9649), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9650) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9652), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9652) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9653), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9654) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9655), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9656) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9657), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9657) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9658), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9659) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9660), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9660) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9662), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9662) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9663), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9664) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9665), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9665) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9667), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9667) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9668), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9669) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9671), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9671) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9673), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9673) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9674), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9675) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9676), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9676) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9678), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9678) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9679), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9680) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9681), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9681) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9683), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9683) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9684), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9685) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9686), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9686) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9687), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9688) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9689), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9689) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9691), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9691) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9692), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9693) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9694), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9694) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9696), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9696) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9697), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9698) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9699), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9700) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9701), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9701) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9703), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9703) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9704), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9705) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9753), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9753) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9755), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9755) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9757), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9757) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9758), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9759) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9760), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9762), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9762) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9764), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9764) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9765), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9767), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9767) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9769), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9769) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9770), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9771) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9772), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9772) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9774), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9774) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9775), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9776) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9777), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9777) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9778), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9779) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9780), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9781) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9782), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9782) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9784), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9784) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9785), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9786) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9787), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9787) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9789), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9789) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9790), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9791) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9792), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9792) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9793), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9794) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9795), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9795) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9797), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9797) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9798), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9799) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9800), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9800) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9802), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9802) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9803), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9804) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9805), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9806) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9807), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9807) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9809), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9809) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9810), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9811) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9812), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9812) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9813), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9814) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9815), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9815) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9817), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9817) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9819), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9819) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9820), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9821) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9824), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9824) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9826), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9826) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9859), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9859) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9861), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9863), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9863) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9864), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9865) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9866), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9866) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9868), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9868) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9869), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9870) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9871), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9871) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9873), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9873) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9874), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9875) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9876), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9876) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9878), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9878) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9879), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9880) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9881), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9881) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9883), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9883) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9884), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9885) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9886), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9886) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9888), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9888) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9889), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9890) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9891), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9891) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9893), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9893) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9894), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9895) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9896), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9896) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9898), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9898) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9899), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9900) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9901), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9901) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9903), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9903) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9904), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9905) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9906), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9906) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9908), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9908) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9909), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9911), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9911) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9913), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9913) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9914), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9915) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9916), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9916) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9918), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9918) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9919), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9920) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9921), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9921) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9923), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9923) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9924), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9925) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9926), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9926) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9928), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9928) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9929), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9930) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9931), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9931) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9932), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9933) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9934), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9934) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9936), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9936) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9937), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9938) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9939), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9939) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9941), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9941) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9942), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9943) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9973), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9973) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9975), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9975) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9977), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9977) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9978), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9979) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9980), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9980) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9982), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9982) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9983), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9984) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9985), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9985) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9987), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9987) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9988), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9989) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9990), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9990) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9992), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9992) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9993), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9994) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9995), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9995) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9996), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9997) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9998), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9998) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(3), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(3) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(5), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(5) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(6), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(7) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(8), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(8) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(10), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(10) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(11), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(12) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(13), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(13) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(303), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(304), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(306), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(306), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(308), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(308), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(309), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(310), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(311), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(311), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(313), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(313), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(314), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(315), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(316), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(316), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(317), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(318), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(319), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(320), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(321), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(321), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(322), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(322), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(324), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(324), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(325), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(325), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(326), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(327), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(328), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(328), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(329), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(330), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(331), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(332), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(333), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(333), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(334), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(335), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(336), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(336), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(551), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(552), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(553), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(554), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(555), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(555), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(556), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(557), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(558), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(558), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(559), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(559), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(560), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(561), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(562), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(562), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(563), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(564), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(565), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(565), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(566), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(567), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(568), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(568), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(570), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(571), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(572), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(572), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(573), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(574), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(575), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(575), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(576), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(577), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(578), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(578), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(579), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(579), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(580), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(581), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(582), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(582), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(583), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(584), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(585), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(585), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(587), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(588), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(589), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(589), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(590), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(591), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(592), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(592), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(593), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(593), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(594), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(595), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(596), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(596), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(598), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(598), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(599), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(599), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(601), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(601), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(602), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(602), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(604), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(604), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(605), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(606), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(607), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(607), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(608), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(609), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(610), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(610), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(611), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(611), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(613), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(613), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(614), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(615), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(616), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(616), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(617), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(618), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(620), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(620), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(621), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(622), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(623), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(623), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(624), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(624), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(625), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(626), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(627), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(627), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(628), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(629), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(630), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(630), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(631), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(632), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(633), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(633), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(634), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(635), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(636), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(636), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(637), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(638), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(639), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(639), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(640), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(641), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(642), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(642), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(644), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(644), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(645), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(645), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(646), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(647), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(648), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(648), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(684), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(684), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(685), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(686), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(687), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(687), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(688), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(689), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(690), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(690), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(691), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(691), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(693), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(693), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(694), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(694), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(696), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(696), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(697), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(697), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(698), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(699), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(700), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(700), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(702), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(702), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(703), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(703), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(704), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(705), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(706), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(706), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(707), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(708), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(709), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(709), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(710), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(711), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(712), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(712), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(713), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(713), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(715), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(715), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(716), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(716), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(717), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(718), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(719), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(719), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(720), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(721), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(722), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(722), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(723), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(723), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(725), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(725), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(726), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(726), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(727), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(728), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(729), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(729), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(730), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(731), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(732), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(732), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(733), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(734), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(735), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(735), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(736), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(736), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(738), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(738), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(739), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(739), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(740), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(741), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(742), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(742), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(744), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(744), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(745), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(745), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(747), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(747), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(749), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(749), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(750), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(751), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(752), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(752), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(753), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(754), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(755), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(755), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(756), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(757), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(758), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(758), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(759), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(760), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(761), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(761), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(762), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(762), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(763), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(764), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(765), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(765), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(766), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(767), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(768), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(768), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(769), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(770), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(788), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(789), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(790), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(790), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(791), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(791), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(792), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(793), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(794), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(794), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(795), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(796), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(797), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(797), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(798), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(799), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(800), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(800), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(801), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(802), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(803), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(803), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(804), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(805), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(806), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(806), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(807), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(808), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(809), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(809), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(810), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(810), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(812), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(812), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(813), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(814), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(816), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(816), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(817), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(818), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(819), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(819), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(820), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(820), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(821), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(822), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(823), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(823), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(824), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(825), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(826), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(826), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(827), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(828), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(829), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(829), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(830), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(831), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(832), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(832), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(833), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(833), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(835), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(835), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(836), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(836), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(837), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(838), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(839), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(839), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(840), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(841), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(842), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(842), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(843), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(844), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(845), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(845), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(846), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(847), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(848), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(848), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(849), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(849), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(850), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(851), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(852), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(852), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(853), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(854), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(855), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(855), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(856), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(856), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(858), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(858), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(859), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(860), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(861), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(861), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(862), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(862), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(864), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(864), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(865), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(865), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(866), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(867), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(868), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(868), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(869), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(870), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(871), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(871), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(872), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(873), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(874), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(874), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(875), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(875), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(877), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(877), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(878), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(878), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(880), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(880), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(881), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(881), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(883), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(883), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(884), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(884), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(885), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(886), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(887), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(887), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(888), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(889), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(890), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(890), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(891), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(891), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(892), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(893), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(894), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(894), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(895), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(896), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(897), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(897), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(898), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(899), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(968), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(969), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(970), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(971), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(972), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(973), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(974), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(974), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(975), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(975), null });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Created", "Modified", "VideoUrl" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(976), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(977), null });

            migrationBuilder.UpdateData(
                table: "MyDictionaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9321), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9323) });

            migrationBuilder.UpdateData(
                table: "MyDictionaries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9327), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9327) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9395), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9395) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9398), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9399) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9400), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9401) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9402), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9402) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9404), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9404) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9408), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9408) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9410), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9410) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9412), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9412) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9413), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9414) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9416), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9417) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9418), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9418) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9420), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9420) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9421), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9422) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9423), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9423) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9425), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9425) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9426), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9427) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9428), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9428) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9430), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9431) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9432), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9432) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9434), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9434) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9435), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9436) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9437), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9438) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9461), new DateTime(2023, 12, 14, 14, 10, 12, 664, DateTimeKind.Utc).AddTicks(9461) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1118), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1118) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1121), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1121) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1123), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1123) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1124), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1125) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1126), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1127) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1128), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1129) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1130), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1130) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1131), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1132) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1133), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1133) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1135), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1135) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1137), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1137) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1138), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1139) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1140), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1140) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1141), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1142) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1143), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1143) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1144), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1145) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1146), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1146) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1148), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1149) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1150), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1150) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1196), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1196) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1197), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1198) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1199), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1199) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1201), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1201) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1202), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1203) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1204), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1204) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1205), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1206) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1207), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1207) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1208), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1209) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1210), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1210) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1211), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1212) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1213), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1213) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1214), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1215) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1216), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1216) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1218), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1219) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1220), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1220) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1221), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1222) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1223), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1223) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1224), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1225) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1226), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1226) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1228), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1228) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1229), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1230) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1231), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1231) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1232), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1233) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1234), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1234) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1235), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1236) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1237), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1237) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1238), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1239) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1240), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1240) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1242), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1242) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1243), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1244) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1245), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1245) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1247), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1247) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1248), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1248) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1250), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1250) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1251), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1252) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1253), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1253) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1254), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1255) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1256), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1256) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1257), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1258) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1259), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1259) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1260), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1261) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1262), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1262) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1263), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1264) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1265), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1265) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1267), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1267) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1269), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1269) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1270), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1271) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1309), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1309) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1311), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1311) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1312), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1313) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1314), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1314) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1315), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1316) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1317), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1317) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1318), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1319) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1320), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1320) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1321), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1322) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1323), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1324) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1325), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1325) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1326), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1327) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1328), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1328) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1329), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1330) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1331), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1331) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1332), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1333) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1335), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1335) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1336), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1336) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1338), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1338) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1339), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1340) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1341), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1341) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1342), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1343) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1344), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1344) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1346), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1346) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1347), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1347) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1349), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1349) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1350), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1350) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1352), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1352) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1353), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1354) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1355), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1355) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1356), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1357) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1358), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1358) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1359), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1361), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1361) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1363), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1363) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1364), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1364) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1366), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1366) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1367), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1368) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1369), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1369) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1370), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1371) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1372), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1372) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1373), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1374) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1375), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1375) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1376), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1377) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1378), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1378) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1380), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1380) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1381), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1381) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1383), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1383) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1384), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1385) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1386), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1386) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1387), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1388) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1389), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1389) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1390), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1391) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1392), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1392) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1393), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1394) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1395), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1395) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1397), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1397) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1398), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1398) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1400), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1400) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1401), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1401) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1432), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1433) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1434), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1435) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1437), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1437) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1438), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1439) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1440), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1440) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1442), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1442) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1443), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1444) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1445), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1445) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1446), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1447) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1448), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1448) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1450), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1450) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1451), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1451) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1453), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1453) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1454), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1454) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1456), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1456) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1457), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1458) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1459), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1459) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1460), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1461) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1462), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1462) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1463), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1464) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1465), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1465) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1466), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1467) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1468), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1468) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1470), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1470) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1471), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1471) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1473), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1473) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1474), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1476), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1476) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1477), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1478) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1479), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1479) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1480), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1482), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1482) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1483), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1484) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1485), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1485) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1486), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1487) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1488), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1488) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1490), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1490) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1491), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1492) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1493), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1493) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1495), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1495) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1496), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1497) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1498), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1498) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1499), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1500) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1501), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1501) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1502), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1503) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1504), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1504) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1539), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1540) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1541), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1541) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1542), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1543) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1544), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1545) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1546), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1546) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1547), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1548) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1549), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1549) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1550), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1551) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1552), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1552) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1554), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1554) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1555), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1556) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1557), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1557) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1558), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1559) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1560), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1560) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1561), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1562) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1563), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1563) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1565), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1565) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1566), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1567) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1568), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1568) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1569), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1570) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1571), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1571) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1572), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1573) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1574), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1574) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1576), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1576) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1577), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1578) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1579), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1579) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1580), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1581) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1582), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1582) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1583), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1584) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1585), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1585) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1586), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1587) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1588), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1588) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1589), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1590) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1591), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1591) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1593), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1593) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1594), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1595) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1596), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1596) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1597), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1598) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1599), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1599) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1600), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1601) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1602), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1602) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1604), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1604) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1605), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1606) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1607), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1607) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1608), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1609) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1610), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1610) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1611), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1612) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1613), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1613) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1615), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1615) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1616), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1616) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1618), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1618) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1619), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1620) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1621), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1621) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1622), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1623) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1624), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1624) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1625), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1626) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1627), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1628) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1629), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1630) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1631), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1631) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1632), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1633) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1665), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1666) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1667), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1667) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1668), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1669) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1670), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1670) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1672), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1672) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1673), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1674) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1675), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1675) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1676), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1677) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1678), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1678) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1680), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1680) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1681), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1682) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1683), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1683) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1684), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1685) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1686), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1686) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1687), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1688) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1689), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1689) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1691), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1691) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1692), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1693) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1694), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1694) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1695), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1696) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1697), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1697) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1698), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1699) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1700), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1700) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1701), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1702) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1704), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1705) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1706), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1706) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1708), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1708) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1709), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1710) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1711), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1711) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1712), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1713) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1749), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1749) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1751), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1751) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1754), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1754) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1755), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1756) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1757), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1757) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1758), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1759) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1760), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1760) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1762), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1762) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1763), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1763) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1765), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1765) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1766), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1767) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1768), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1768) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1769), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1770) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1771), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1771) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1772), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1773) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1774), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1774) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1776), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1776) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1777), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1777) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1779), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1779) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1780), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1781) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1782), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1782) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1783), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1784) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1785), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1785) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1786), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1787) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1788), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1788) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1790), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1790) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1791), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1791) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1793), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1793) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1794), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1795) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1796), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1796) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1797), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1798) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1799), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1799) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1800), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1801) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1802), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1802) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1804), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1804) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1805), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1805) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1807), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1807) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1808), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1809) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1810), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1810) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1811), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1812) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1813), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1813) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1814), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1815) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1816), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1816) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1817), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1818) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1819), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1819) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1821), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1821) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1822), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1822) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1824), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1824) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1825), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1826) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1827), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1827) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1829), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1829) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1831), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1831) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1832), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1832) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1834), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1834) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1835), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1835) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1837), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1837) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1838), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1839) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1840), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1840) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1841), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1842) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1843), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1843) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1872), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1872) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1874), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1874) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1875), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1875) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1877), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1877) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1878), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1879) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1880), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1880) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1881), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1882) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1883), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1883) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1884), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1885) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1886), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1886) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1887), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1888) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1889), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1889) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1891), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1891) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1892), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1893) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1894), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1894) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1895), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1896) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1897), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1897) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1898), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1899) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1900), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1900) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1901), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1902) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1903), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1903) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1905), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1905) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1906), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1906) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1908), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1908) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1909), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1910) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1911), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1911) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1912), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1913) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1914), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1914) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1915), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1916) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1917), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1917) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1919), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1919) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1920), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1921) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1922), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1922) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1924), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1924) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1925), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1925) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1927), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1927) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1928), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1929) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1930), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1930) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1931), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1932) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1933), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1934), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1935) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1936), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1936) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1938), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1938) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1939), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1940) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1941), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1941) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1942), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1943) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1944), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1944) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1945), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1946) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1947), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1947) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1949), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1949) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1950), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1950) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1952), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1952) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1953), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1954) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1955), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1955) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1956), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1958), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1959) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1960), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1960) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1962), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1962) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1963), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(1963) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2127), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2127) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2129), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2129) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2130), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2131) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2132), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2132) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2133), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2134) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2135), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2135) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2137), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2137) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2138), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2138) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2140), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2140) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2141), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2142) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2143), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2143) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2144), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2145) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2146), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2146) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2148), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2148) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2149), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2149) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2151), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2151) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2152), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2153) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2154), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2154) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2155), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2156) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2157), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2157) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2158), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2159) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2160), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2160) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2162), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2162) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2163), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2163) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2165), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2165) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2166), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2167) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2168), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2168) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2169), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2170) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2171), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2171) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2172), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2173) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2174), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2174) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2175), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2176) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2177), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2178) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2179), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2179) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2181), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2181) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2182), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2182) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2184), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2184) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2185), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2186) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2187), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2187) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2188), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2189) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2190), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2190) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2191), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2192) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2193), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2193) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2194), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2195) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2196), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2196) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2198), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2198) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2199), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2200) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2201), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2201) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2202), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2203) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2204), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2204) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2205), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2206) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2207), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2207) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2208), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2209) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2210), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2210) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2211), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2212) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2213), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2213) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2215), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2215) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2216), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2216) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2218), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2218) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2219), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2219) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2275), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2275) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2277), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2277) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2278), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2279) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2280), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2280) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2282), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2282) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2283), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2283) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2285), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2285) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2286), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2287) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2288), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2288) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2289), new DateTime(2023, 12, 14, 14, 10, 12, 665, DateTimeKind.Utc).AddTicks(2290) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VideoUrl",
                table: "Fights");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2829), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2829) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2832), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2833) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2835), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2835) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2837), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2838) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2839), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2840) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2844), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2844) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2846), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2846) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2848), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2849) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2850), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2851) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2853), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2853) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2855), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2855) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2857), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2858) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2859), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2860) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2861), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2862) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2863), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2864) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2865), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2866) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2867), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2868) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2870), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2871) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2872), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2873) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2874), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2875) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2876), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2877) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2878), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2879) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2880), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2881) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2882), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2883) });

            migrationBuilder.UpdateData(
                table: "Federations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2793), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2793) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1855), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1856) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1862), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1863) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1864), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1865) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1866), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1867) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1868), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1869) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1871), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1871) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1872), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1873) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1874), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1874) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1876), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1876) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1878), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1878) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1880), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1880) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1882), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1882) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1883), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1884) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1885), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1885) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1887), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1887) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1889), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1889) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1890), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1891) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1893), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1893) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1895), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1895) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1896), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1897) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1898), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1898) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1900), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1900) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1901), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1902) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1903), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1904) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1905), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1905) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1906), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1907) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1908), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1909) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1910), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1910) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1946), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1946) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1948), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1948) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1950), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1950) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1951), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1952) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1953), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1953) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1956), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1956) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1957), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1958) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1959), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1959) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1961), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1961) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1963), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1963) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1964), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1965) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1966), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1967) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1969), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1969) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1971), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1971) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1972), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1973) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1974), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1974) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1976), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1976) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1978), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1978) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1979), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1981), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1981) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1983), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1983) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1984), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1985) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1986), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1987) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1988), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1988) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1990), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1990) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1991), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1992) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1993), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1994) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1995), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1995) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1997), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1997) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1998), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1999) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2000), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2000) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2002), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2002) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2003), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2004) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2005), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2005) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2007), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2007) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2008), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2009) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2010), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2011) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2013), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2013) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2014), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2015) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2016), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2016) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2018), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2018) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2019), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2020) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2021), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2022) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2023), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2023) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2055), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2056) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2057), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2058) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2059), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2059) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2061), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2061) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2062), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2063) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2064), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2065) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2066), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2068), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2068) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2069), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2070) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2071), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2071) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2073), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2073) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2074), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2075) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2076), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2077) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2078), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2078) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2080), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2080) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2081), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2082) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2083), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2083) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2085), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2085) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2086), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2087) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2088), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2088) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2090), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2090) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2091), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2092) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2093), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2093) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2095), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2095) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2096), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2097) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2098), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2099) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2100), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2100) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2102), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2102) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2103), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2104) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2105), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2105) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2107), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2107) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2108), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2109) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2110), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2111) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2112), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2112) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2114), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2114) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2115), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2116) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2117), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2117) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2119), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2119) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2120), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2121) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2122), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2123) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2124), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2124) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2126), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2126) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2127), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2128) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2129), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2129) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2131), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2131) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2132), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2133) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2134), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2134) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2136), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2136) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2137), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2138) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2139), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2139) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2141), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2141) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2142), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2143) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2144), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2145) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2146), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2146) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2185), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2185) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2187), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2187) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2189), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2189) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2192), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2192) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2193), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2194) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2195), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2195) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2197), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2197) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2198), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2199) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2200), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2201) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2202), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2202) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2204), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2204) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2205), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2206) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2207), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2207) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2209), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2209) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2210), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2211) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2212), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2212) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2214), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2214) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2215), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2216) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2217), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2217) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2219), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2219) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2220), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2221) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2222), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2223) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2224), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2224) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2226), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2226) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2227), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2229) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2499), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2499) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2501), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2502) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2503), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2503) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2505), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2505) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2507), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2507) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2508), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2509) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2510), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2510) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2512), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2512) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2513), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2514) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2515), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2515) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2517), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2517) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2518), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2519) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2520), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2521) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2522), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2522) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2523), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2524) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2561), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2561) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2563), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2563) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2564), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2565) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2566), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2567) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2568), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2568) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2570), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2570) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2572), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2572) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2573), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2574) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2575), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2576) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2577), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2577) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2579), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2579) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2580), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2581) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2582), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2582) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2584), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2584) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2586), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2586) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2587), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2588) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2589), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2589) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2591), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2591) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2592), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2593) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2594), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2594) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2596), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2596) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2597), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2598) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2599), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2600) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2601), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2601) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2603), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2603) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2604), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2605) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2606), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2606) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2608), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2608) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2609), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2610) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2611), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2611) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2613), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2613) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2614), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2615) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2616), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2616) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2618), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2618) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2619), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2620) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2621), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2622) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2623), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2623) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2625), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2625) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2626), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2627) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2923), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2923) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2928), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2929) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2930), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(2931) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3174), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3174) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3176), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3177) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3178), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3179) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3180), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3181) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3182), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3182) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3184), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3185) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3186), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3187) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3188), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3188) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3189), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3190) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3191), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3191) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3192), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3193) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3194), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3194) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3195), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3195) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3197), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3198) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3200), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3200) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3201), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3201) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3203), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3203) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3204), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3205) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3206), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3206) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3207), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3208) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3209), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3209) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3210), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3210) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3212), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3212) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3213), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3213) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3215), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3215) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3216), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3216) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3218), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3218) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3219), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3221), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3221) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3222), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3223) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3224), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3225) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3226), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3226) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3227), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3228) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3229), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3229) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3230), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3231) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3232), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3232) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3233), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3234) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3235), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3235) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3236), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3237) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3238), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3238) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3239), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3240) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3241), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3241) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3242), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3243) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3244), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3244) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3246), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3246) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3247), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3247) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3249), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3249) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3250), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3250) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3252), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3252) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3253), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3253) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3254), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3255) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3256), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3256) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3258), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3258) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3259), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3259) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3261), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3261) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3262), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3262) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3264), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3264) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3265), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3265) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3267), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3267) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3268), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3268) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3270), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3270) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3271), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3272) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3274), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3274) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3275), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3275) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3320), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3320) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3321), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3322) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3323), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3323) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3324), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3325) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3326), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3326) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3327), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3328) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3329), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3329) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3331), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3331) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3332), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3332) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3334), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3334) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3335), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3335) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3337), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3337) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3338), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3338) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3340), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3340) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3341), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3341) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3343), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3343) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3344), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3344) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3346), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3346) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3347), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3347) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3348), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3349) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3350), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3350) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3351), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3352) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3353), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3353) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3354), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3355) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3356), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3356) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3357), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3358) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3359), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3359) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3360), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3361) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3362), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3362) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3364), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3364) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3365), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3366) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3367), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3367) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3368), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3369) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3370), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3370) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3371), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3372) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3373), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3373) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3374), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3375) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3376), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3376) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3377), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3378) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3379), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3379) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3380), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3381) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3382), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3382) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3383), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3384) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3385), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3385) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3386), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3387) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3388), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3388) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3389), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3390) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3391), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3391) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3392), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3393) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3394), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3394) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3395), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3396) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3397), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3397) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3398), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3399) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3400), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3400) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3401), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3402) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3403), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3403) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3404), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3405) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3406), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3406) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3407), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3408) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3409), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3409) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3410), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3411) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3412), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3412) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3415), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3415) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3416), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3417) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3451), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3452) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3453), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3454) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3455), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3455) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3456), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3457) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3458), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3458) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3459), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3459) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3461), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3461) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3462), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3463) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3464), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3464) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3465), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3466) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3467), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3467) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3468), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3469) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3470), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3470) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3471), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3472) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3473), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3473) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3474), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3475) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3476), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3476) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3477), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3478) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3479), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3479) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3480), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3481) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3482), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3482) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3483), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3484) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3485), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3485) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3486), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3487) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3488), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3488) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3489), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3490) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3491), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3491) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3492), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3493) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3494), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3494) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3495), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3496) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3497), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3497) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3498), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3499) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3500), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3500) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3501), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3502) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3503), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3503) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3504), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3505) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3506), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3506) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3507), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3508) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3509), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3509) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3510), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3511) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3512), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3512) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3513), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3514) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3515), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3515) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3516), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3517) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3518), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3518) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3519), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3520) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3521), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3521) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3522), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3523) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3524), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3524) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3525), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3526) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3527), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3527) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3528), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3529) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3530), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3530) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3531), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3532) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3533), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3533) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3534), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3535) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3536), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3536) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3537), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3538) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3539), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3539) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3540), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3541) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3542), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3542) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3543), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3545), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3545) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3546), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3547) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3548), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3548) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3549), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3550) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3551), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3551) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3552), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3553) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3554), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3554) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3555), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3556) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3557), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3557) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3558), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3559) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3560), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3560) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3561), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3562) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3563), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3563) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3564), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3565) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3566), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3566) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3567), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3568) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3569), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3569) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3570), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3571) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3572), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3572) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3574), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3574) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3575), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3575) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3577), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3577) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3578), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3578) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3612), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3613) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3614), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3615) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3616), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3616) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3617), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3618) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3619), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3619) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3620), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3621) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3622), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3622) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3623), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3624) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3625), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3625) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3626), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3627) });

            migrationBuilder.UpdateData(
                table: "MyDictionaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1644), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1646) });

            migrationBuilder.UpdateData(
                table: "MyDictionaries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1651), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1651) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1727), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1728) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1732), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1733) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1734), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1735) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1736), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1736) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1738), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1738) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1742), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1742) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1743), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1744) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1745), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1746) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1747), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1747) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1790), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1790) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1792), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1792) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1794), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1794) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1795), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1796) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1797), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1797) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1799), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1799) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1800), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1801) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1802), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1802) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1806), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1806) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1807), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1808) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1809), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1809) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1811), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1812), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1813) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1814), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(1814) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3771), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3772) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3774), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3775) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3776), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3777) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3778), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3779) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3780), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3780) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3782), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3783) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3784), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3784) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3785), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3786) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3787), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3788) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3789), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3790) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3791), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3791) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3792), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3793) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3794), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3794) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3796), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3796) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3797), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3798) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3799), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3799) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3801), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3801) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3842), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3842) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3843), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3844) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3845), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3845) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3847), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3847) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3848), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3849) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3850), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3850) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3852), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3852) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3853), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3854) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3855), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3855) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3857), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3857) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3858), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3859) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3860), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3860) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3861), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3862) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3863), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3864) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3865), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3865) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3866), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3867) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3869), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3869) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3870), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3871) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3872), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3872) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3873), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3874) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3875), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3875) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3877), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3877) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3878), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3879) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3880), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3880) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3882), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3882) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3883), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3884) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3885), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3885) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3887), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3887) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3888), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3889) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3890), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3890) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3891), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3892) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3893), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3893) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3895), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3895) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3896), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3897) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3898), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3898) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3899), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3900) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3901), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3901) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3903), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3903) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3904), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3905) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3906), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3906) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3907), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3908) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3909), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3909) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3911), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3911) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3912), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3913) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3914), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3914) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3915), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3916) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3917), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3917) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3919), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3919) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3953), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3953) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3955), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3955) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3956), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3957) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3958), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3958) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3959), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3960) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3961), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3961) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3963), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3963) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3964), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3965) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3966), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3966) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3967), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3968) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3969), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3969) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3971), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3971) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3972), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3973) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3974), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3974) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3976), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3976) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3977), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3978) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3979), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3979) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3981), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3981) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3982), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3983) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3984), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3984) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3985), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3986) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3987), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3987) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3989), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3989) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3990), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3991) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3992), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3992) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3993), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3994) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3995), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3996) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3997), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3997) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3998), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(3999) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4000), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4000) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4002), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4002) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4003), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4004) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4005), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4005) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4006), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4007) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4008), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4008) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4010), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4010) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4011), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4012) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4013), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4013) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4015), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4015) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4016), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4017) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4018), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4018) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4019), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4020) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4021), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4021) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4023), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4023) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4024), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4025) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4026), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4026) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4028), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4028) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4029), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4030) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4031), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4031) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4033), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4033) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4034), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4035) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4036), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4036) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4037), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4038) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4039), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4039) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4041), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4041) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4042), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4043) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4044), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4044) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4045), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4046) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4047), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4047) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4049), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4049) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4083), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4084) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4085), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4086) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4087), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4087) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4088), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4089) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4091), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4091) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4093), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4093) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4094), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4095) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4096), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4096) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4098), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4098) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4099), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4100) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4101), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4101) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4103), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4103) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4104), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4105) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4106), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4106) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4107), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4108) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4109), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4109) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4111), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4111) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4112), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4113) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4114), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4114) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4115), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4116) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4117), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4117) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4119), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4119) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4120), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4121) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4122), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4122) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4123), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4124) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4125), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4126) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4127), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4127) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4128), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4129) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4130), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4130) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4131), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4132) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4133), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4134) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4135), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4135) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4136), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4137) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4138), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4138) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4139), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4140) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4141), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4142) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4143), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4143) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4144), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4145) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4146), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4146) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4147), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4148) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4149), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4149) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4151), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4151) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4152), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4153) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4154), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4154) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4156), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4156) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4175), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4176) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4177), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4177) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4178), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4179) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4180), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4181) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4182), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4182) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4183), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4184) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4185), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4187), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4187) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4188), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4189) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4190), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4190) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4192), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4192) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4193), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4194) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4195), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4195) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4197), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4197) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4198), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4199) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4200), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4200) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4201), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4202) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4203), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4203) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4205), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4205) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4206), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4207) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4209), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4209) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4210), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4211) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4212), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4212) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4214), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4214) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4215), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4216) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4217), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4217) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4218), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4219) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4220), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4221) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4222), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4222) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4223), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4224) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4225), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4225) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4226), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4227) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4228), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4228) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4230), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4230) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4231), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4232) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4233), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4233) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4234), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4235) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4236), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4236) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4238), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4238) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4239), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4240) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4241), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4241) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4243), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4243) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4244), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4245) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4246), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4246) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4248), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4248) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4249), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4250) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4251), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4251) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4252), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4253) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4254), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4254) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4256), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4256) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4257), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4258) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4259), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4259) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4260), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4261) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4262), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4262) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4264), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4264) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4265), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4266) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4267), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4267) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4268), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4269) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4334), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4334) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4336), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4337) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4338), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4338) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4340), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4340) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4341), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4342) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4343), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4343) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4344), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4345) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4346), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4346) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4348), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4348) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4349), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4350) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4351), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4351) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4353), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4353) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4354), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4355) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4356), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4356) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4357), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4358) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4359), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4359) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4361), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4361) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4362), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4363) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4364), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4364) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4366), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4366) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4367), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4368) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4369), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4369) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4370), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4371) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4372), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4374), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4374) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4376), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4376) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4377), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4378) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4379), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4379) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4380), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4381) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4384), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4384) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4444), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4445) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4446), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4447) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4448), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4448) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4450), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4450) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4451), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4452) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4453), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4453) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4455), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4455) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4456), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4457) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4458), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4458) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4460), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4461), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4462) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4463), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4463) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4465), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4465) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4466), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4467) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4468), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4469) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4470), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4470) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4472), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4472) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4473), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4474) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4475), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4475) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4476), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4477) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4478), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4478) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4480), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4480) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4481), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4482) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4483), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4483) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4484), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4485) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4486), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4487) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4488), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4488) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4489), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4490) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4491), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4491) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4493), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4493) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4494), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4495) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4496), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4496) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4497), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4498) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4499), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4499) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4501), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4501) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4502), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4503) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4504), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4504) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4505), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4506) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4507), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4507) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4509), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4509) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4510), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4511) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4512), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4512) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4514), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4514) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4515), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4516) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4517), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4517) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4519), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4519) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4520), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4521) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4522), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4522) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4524), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4524) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4526), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4526) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4527), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4528) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4529), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4529) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4531), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4531) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4532), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4533) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4534), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4534) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4536), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4536) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4537), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4538) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4539), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4539) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4540), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4541) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4542), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4542) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4544), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4544) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4581), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4581) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4583), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4583) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4584), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4585) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4586), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4586) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4588), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4588) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4589), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4590) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4591), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4591) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4592), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4593) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4594), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4594) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4596), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4596) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4597), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4598) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4599), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4599) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4601), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4601) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4603), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4603) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4604), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4605) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4606), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4606) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4608), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4608) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4609), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4610) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4611), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4611) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4613), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4613) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4615), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4615) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4617), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4617) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4618), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4619) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4620), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4620) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4622), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4622) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4623), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4624) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4625), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4625) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4626), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4627) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4628), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4628) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4630), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4630) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4631), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4632) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4633), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4633) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4635), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4635) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4636), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4637) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4638), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4638) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4640), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4640) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4641), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4642) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4643), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4643) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4644), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4645) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4646), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4646) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4648), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4648) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4649), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4650) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4651), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4651) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4652), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4653) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4654), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4655) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4656), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4656) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4657), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4658) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4659), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4659) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4661), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4661) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4662), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4663) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4664), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4666), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4666) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4667), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4668) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4669), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4669) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4670), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4671) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4672), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4672) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4674), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4674) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4675), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4676) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4677), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4677) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4679), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4679) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4712), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4712) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4714), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4714) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4715), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4716) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4717), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4717) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4719), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4719) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4720), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4721) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4722), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4722) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4723), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4724) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4725), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4725) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4727), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4727) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4729), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4729) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4730), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4731) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4732), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4732) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4734), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4734) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4735), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4736) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4737), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4737) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4739), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4739) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4741), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4741) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4742), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4743) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4744), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4744) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4746), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4746) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4747), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4747) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4749), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4749) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4750), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4751) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4752), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4752) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4753), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4754) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4755), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4756) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4757), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4757) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4758), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4759) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4760), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4760) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4762), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4762) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4763), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4764) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4765), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4765) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4766), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4767) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4768), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4768) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4770), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4770) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4771), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4772) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4773), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4773) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4774), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4775) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4776), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4776) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4778), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4778) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4779), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4780) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4781), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4781) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4782), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4783) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4784), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4785) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4786), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4786) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4787), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4788) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4789), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4789) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4791), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4791) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4792), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4793) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4794), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4794) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4796), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4796) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4797), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4798) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4799), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4799) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4801), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4801) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4802), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4803) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4804), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4804) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4806), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4806) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4807), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4808) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4809), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4809) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4998), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(4999) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(5001), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(5001) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(5002), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(5003) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(5004), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(5004) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(5006), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(5006) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(5007), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(5008) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(5009), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(5009) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(5010), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(5011) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(5012), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(5012) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(5014), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(5014) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(5015), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(5016) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(5017), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(5018) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(5019), new DateTime(2023, 12, 13, 19, 12, 12, 787, DateTimeKind.Utc).AddTicks(5019) });
        }
    }
}
