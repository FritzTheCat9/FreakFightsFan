using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FreakFightsFan.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class Event_Hall : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_MyDictionaryItems_CityId",
                table: "Events");

            migrationBuilder.AddColumn<int>(
                name: "HallId",
                table: "Events",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "HallId", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1752), 12, new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1752) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "HallId", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1756), 13, new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1756) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "HallId", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1758), 14, new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1759) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "HallId", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1760), 15, new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1761) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "HallId", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1762), 16, new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1763) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "HallId", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1766), 17, new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1766) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "HallId", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1768), 18, new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1768) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "HallId", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1770), 18, new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1770) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "HallId", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1772), 18, new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1772) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "HallId", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1775), 18, new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1775) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "HallId", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1777), 19, new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1777) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "HallId", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1779), 16, new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1779) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "HallId", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1781), 19, new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1781) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "HallId", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1783), 20, new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1783) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "HallId", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1785), 14, new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1785) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "HallId", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1786), 19, new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1787) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "HallId", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1788), 20, new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1789) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "HallId", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1791), 14, new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1791) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created", "HallId", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1793), 20, new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1793) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created", "HallId", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1794), 21, new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1795) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created", "HallId", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1796), 18, new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1797) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created", "HallId", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1798), 22, new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1798) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created", "HallId", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1800), 23, new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1800) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Created", "HallId", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1802), 14, new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1802) });

            migrationBuilder.UpdateData(
                table: "Federations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1719), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1719) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1117), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1117) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1121), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1122) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1123), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1124) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1125), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1125) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1126), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1127) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1129), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1129) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1131), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1132) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1133), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1133) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1135), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1135) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1137), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1138) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1140), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1140) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1141), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1142) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1143), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1143) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1145), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1145) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1147), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1147) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1149), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1149) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1150), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1151) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1153), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1153) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1154), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1155) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1156), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1156) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1157), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1158) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1159), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1159) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1161), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1161) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1162), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1163) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1164), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1164) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1165), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1166) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1167), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1167) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1168), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1169) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1170), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1170) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1171), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1172) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1218), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1219) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1220), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1221) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1222), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1222) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1224), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1225) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1226), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1226) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1227), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1228) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1229), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1229) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1230), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1231) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1232), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1232) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1234), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1234) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1235), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1235) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1237), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1237) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1238), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1238) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1240), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1240) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1241), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1242) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1243), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1243) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1244), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1245) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1246), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1246) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1247), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1248) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1249), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1249) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1250), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1251) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1252), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1252) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1254), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1254) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1255), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1255) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1257), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1257) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1258), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1259) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1260), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1260) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1261), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1262) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1263), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1263) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1264), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1265) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1266), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1266) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1267), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1268) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1269), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1269) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1271), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1271) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1272), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1272) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1274), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1275) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1276), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1276) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1278), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1278) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1279), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1279) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1281), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1281) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1282), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1282) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1284), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1284) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1285), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1285) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1287), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1287) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1320), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1320) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1321), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1322) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1323), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1324), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1325) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1326), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1326) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1327), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1328) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1329), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1329) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1331), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1331) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1332), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1332) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1334), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1334) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1335), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1335) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1337), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1337) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1338), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1339) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1340), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1340) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1341), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1342) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1343), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1343) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1345), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1346) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1347), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1347) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1348), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1349) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1350), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1350) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1351), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1352) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1353), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1353) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1354), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1355) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1356), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1356) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1358), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1358) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1359), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1361), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1361) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1362), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1363) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1364), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1364) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1365), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1366) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1367), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1367) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1368), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1369) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1370), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1370) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1371), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1372) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1373), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1373) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1374), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1375) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1376), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1377) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1378), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1378) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1379), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1380) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1381), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1381) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1382), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1383) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1384), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1384) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1386), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1386) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1387), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1387) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1389), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1389) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1390), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1391) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1392), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1392) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1393), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1394) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1395), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1395) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1396), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1397) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1398), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1398) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1399), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1400) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1401), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1401) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1402), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1403) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1426), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1427) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1429), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1430) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1431), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1431) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1432), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1433) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1434), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1434) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1435), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1436) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1437), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1437) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1438), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1439) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1440), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1441) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1442), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1442) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1443), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1444) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1445), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1445) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1447), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1447) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1448), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1449) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1450), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1450) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1452), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1452) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1453), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1453) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1455), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1455) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1457), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1457) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1458), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1458) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1460), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1460) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1461), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1461) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1463), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1463) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1464), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1465) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1466), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1466) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1467), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1468) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1469), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1469) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1470), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1471) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1472), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1472) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1473), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1474) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1475), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1476), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1477) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1478), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1478) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1479), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1480) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1481), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1482), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1483) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1484), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1484) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1486), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1486) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1487), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1487) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1489), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1489) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1514), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1514) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1515), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1516) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1517), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1517) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1519), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1519) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1520), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1520) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1522), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1522) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1523), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1524) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1525), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1525) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1526), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1527) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1528), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1528) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1529), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1530) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1531), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1531) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1532), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1533) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1534), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1534) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1535), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1536) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1537), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1537) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1538), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1539) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1540), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1540) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1541), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1542) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1543), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1543) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1544), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1545) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1546), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1546) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1547), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1548) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1549), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1549) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1550), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1551) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1552), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1552) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1553), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1554) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1555), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1555) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1557), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1557) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1558), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1559) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1560), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1560) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1561), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1562) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1563), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1563) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1564), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1565) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1566), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1566) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1567), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1568) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1569), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1569) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1839), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1839) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1841), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1842) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1843), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1843) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1844), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1845) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1846), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1846) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1848), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1848) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1850), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1850) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1851), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1851) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1877), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1877) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1879), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1879) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1880), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1880) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1882), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1882) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1883), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1883) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1884), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1885) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1886), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1886) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1887), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1888) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1889), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1889) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1891), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1891) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1892), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1893) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1894), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1894) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1895), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1896) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1897), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1897) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1898), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1898) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1899), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1900) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1901), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1901) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1902), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1902) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1903), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1904) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1905), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1905) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1906), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1906) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1907), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1908) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1909), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1909) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1910), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1910) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1911), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1912) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1913), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1914) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1915), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1915) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1916), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1917) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1918), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1919) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1920), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1920) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1921), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1921) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1922), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1923) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1924), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1924) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1925), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1925) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1926), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1927) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1928), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1928) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1930), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1930) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1931), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1931) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1932), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1934), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1934) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1935), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1935) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1936), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1937) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1938), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1938) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1939), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1939) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1940), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1941) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1942), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1942) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1943), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1944) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1945), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1945) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1946), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1946) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1947), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1948) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1949), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1949) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1950), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1950) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1951), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1952) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1953), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1953) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1954), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1954) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1955), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1956) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1957), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1959), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1959) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1960), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1960) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1961), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1962) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1963), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1963) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1964), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1964) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1965), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1966) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1967), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1967) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1968), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1968) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1992), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1993) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1994), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1994) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1995), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1995) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1996), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1997) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1998), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1998) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1999), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2000) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2001), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2001) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2002), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2002) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2003), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2004) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2005), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2005) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2006), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2006) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2007), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2008) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2009), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2009) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2010), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2011) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2012), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2012) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2013), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2013) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2014), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2015) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2016), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2016) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2017), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2017) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2018), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2019) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2020), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2020) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2021), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2021) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2022), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2023) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2024), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2024) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2025), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2025) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2026), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2027) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2028), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2028) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2029), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2029) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2030), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2031) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2032), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2032) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2033), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2033) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2034), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2035) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2036), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2036) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2037), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2038) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2039), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2039) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2040), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2041) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2042), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2042) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2043), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2044) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2045), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2045) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2046), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2046) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2047), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2048) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2049), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2049) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2050), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2050) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2051), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2052) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2053), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2053) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2054), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2054) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2055), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2056) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2057), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2057) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2058), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2058) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2059), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2060) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2061), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2061) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2062), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2063) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2064), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2064) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2065), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2065) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2066), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2067) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2068), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2068) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2070), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2070) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2071), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2072) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2073), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2073) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2074), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2074) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2075), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2076) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2077), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2077) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2078), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2078) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2079), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2080) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2094), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2094) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2095), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2096) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2097), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2097) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2099), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2099) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2100), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2100) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2102), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2102) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2103), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2103) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2104), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2105) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2106), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2106) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2107), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2107) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2108), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2109) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2110), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2110) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2111), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2111) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2112), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2113) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2114), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2114) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2115), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2115) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2116), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2117) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2118), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2118) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2119), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2119) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2120), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2121) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2122), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2122) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2123), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2123) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2124), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2125) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2126), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2126) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2127), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2127) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2128), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2129) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2130), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2130) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2131), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2131) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2132), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2133) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2134), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2134) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2135), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2136) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2137), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2137) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2138), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2138) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2139), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2140) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2141), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2141) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2142), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2142) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2143), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2144) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2145), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2145) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2146), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2146) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2147), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2148) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2149), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2149) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2150), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2151) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2152), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2152) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2153), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2153) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2154), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2155) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2156), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2156) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2157), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2157) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2159), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2159) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2160), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2160) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2161), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2162) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2163), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2163) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2164), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2164) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2165), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2166) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2167), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2167) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2168), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2168) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2169), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2170) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2171), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2171) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2172), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2172) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2173), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2174) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2175), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2175) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2176), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2176) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2177), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2178) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2179), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2179) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2180), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2180) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2181), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2182) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2183), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2183) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2184), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2184) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2186), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2186) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2187), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2187) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2188), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2189) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2189), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2190) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2191), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2191) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2192), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2193) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2193), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2194) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2195), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2195) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2196), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2196) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2197), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2198) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2199), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2199) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2200), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2201) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2202), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2202) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2203), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2203) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2204), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2205) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2241), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2241) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2243), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2243) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2244), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2244) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2245), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2246) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2247), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2247) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2248), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2248) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2249), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2250) });

            migrationBuilder.UpdateData(
                table: "MyDictionaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(932), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(934) });

            migrationBuilder.InsertData(
                table: "MyDictionaries",
                columns: new[] { "Id", "Code", "Created", "Modified", "Name" },
                values: new object[] { 2, "HALL", new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(937), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(938), "Halls" });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1004), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1004) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1007), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1008) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1009), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1010) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1011), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1011) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1013), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1013) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1016), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1016) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1017), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1018) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1019), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1019) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1020), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1021) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1023), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1024) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1025), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1025) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2375), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2375) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2378), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2378) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2379), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2380) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2381), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2381) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2382), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2383) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2385), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2385) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2386), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2386) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2388), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2388) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2389), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2390) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2391), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2392) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2393), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2393) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2395), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2395) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2396), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2396) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2397), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2398) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2399), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2399) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2400), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2401) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2402), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2402) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2404), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2404) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2439), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2439) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2440), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2441) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2442), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2442) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2443), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2444) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2445), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2445) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2446), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2447) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2448), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2448) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2450), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2450) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2451), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2451) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2453), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2453) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2454), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2454) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2456), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2456) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2457), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2457) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2458), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2459) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2460), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2460) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2462), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2462) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2463), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2464) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2465), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2465) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2467), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2467) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2468), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2468) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2469), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2470) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2471), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2471) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2472), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2473) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2474), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2474) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2475), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2476) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2477), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2477) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2478), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2479) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2480), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2480) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2481), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2481) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2482), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2483) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2484), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2484) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2485), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2486) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2487), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2487) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2488), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2489) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2490), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2490) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2491), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2491) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2493), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2493) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2494), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2494) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2495), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2496) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2497), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2497) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2498), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2499) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2500), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2500) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2501), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2502) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2503), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2503) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2504), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2504) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2505), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2506) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2507), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2507) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2509), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2509) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2510), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2511) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2535), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2535) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2536), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2537) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2538), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2538) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2539), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2540) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2541), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2541) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2542), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2542) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2544), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2544) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2545), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2545) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2546), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2547) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2548), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2548) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2549), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2550) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2551), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2551) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2552), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2553) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2554), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2554) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2555), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2555) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2557), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2557) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2558), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2558) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2559), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2560) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2561), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2561) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2562), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2563) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2564), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2564) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2565), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2565) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2567), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2567) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2568), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2568) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2569), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2570) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2571), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2571) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2572), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2573) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2574), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2574) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2575), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2576) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2577), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2577) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2578), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2579) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2580), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2580) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2581), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2581) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2582), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2583) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2584), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2584) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2585), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2586) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2587), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2587) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2588), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2589) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2590), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2590) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2591), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2591) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2593), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2593) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2594), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2594) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2595), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2596) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2597), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2597) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2598), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2599) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2600), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2600) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2601), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2602) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2603), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2603) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2604), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2604) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2605), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2606) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2607), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2607) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2608), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2609) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2610), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2610) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2611), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2612) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2613), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2613) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2614), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2615) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2616), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2616) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2617), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2617) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2618), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2619) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2620), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2620) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2645), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2645) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2646), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2647) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2649), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2649) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2651), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2651) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2652), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2652) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2654), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2654) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2655), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2655) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2656), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2657) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2658), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2658) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2659), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2660) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2661), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2661) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2662), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2663) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2664), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2664) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2665), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2665) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2667), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2667) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2668), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2669) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2670), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2670) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2671), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2671) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2673), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2673) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2674), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2674) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2675), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2676) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2677), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2677) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2678), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2679) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2680), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2680) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2681), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2682) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2683), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2683) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2684), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2684) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2686), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2686) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2687), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2687) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2688), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2689) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2690), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2690) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2691), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2692) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2693), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2693) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2694), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2694) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2695), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2696) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2697), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2697) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2698), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2699) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2700), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2700) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2701), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2702) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2703), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2704), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2704) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2706), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2706) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2707), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2707) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2708), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2709) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2710), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2710) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2733), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2734) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2735), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2735) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2736), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2737) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2738), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2738) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2739), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2740) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2741), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2741) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2742), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2742) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2744), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2744) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2745), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2745) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2746), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2747) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2748), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2748) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2749), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2750) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2751), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2751) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2752), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2753) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2754), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2754) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2755), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2756) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2757), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2757) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2758), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2758) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2759), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2760) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2761), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2761) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2762), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2763) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2764), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2764) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2765), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2766) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2767), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2767) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2768), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2769) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2770), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2770) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2771), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2772) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2773), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2773) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2774), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2774) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2776), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2776) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2777), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2777) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2778), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2779) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2780), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2780) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2781), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2782) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2783), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2783) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2784), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2785) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2786), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2786) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2787), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2787) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2788), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2789) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2790), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2790) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2791), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2792) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2793), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2793) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2794), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2795) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2796), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2796) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2797), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2797) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2798), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2799) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2800), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2800) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2801), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2802) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2803), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2803) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2804), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2804) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2806), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2806) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2807), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2807) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2808), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2809) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2810), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2810) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2811), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2812) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2813), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2813) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2814), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2814) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2815), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2816) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2817), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2817) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2818), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2819) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2843), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2843) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2844), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2845) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2846), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2846) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2847), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2847) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2849), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2849) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2850), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2850) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2851), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2852) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2853), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2853) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2854), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2855) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2856), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2856) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2857), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2858) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2859), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2859) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2860), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2860) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2861), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2862) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2863), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2863) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2864), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2865) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2866), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2866) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2867), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2867) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2869), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2869) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2870), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2870) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2871), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2872) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2873), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2873) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2874), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2875) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2876), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2876) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2877), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2877) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2880), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2880) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2881), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2882) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2883), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2883) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2884), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2884) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2886), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2886) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2909), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2910) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2911), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2911) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2912), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2913) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2914), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2914) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2915), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2916) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2917), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2917) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2918), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2918) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2920), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2920) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2921), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2921) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2922), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2923) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2924), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2924) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2925), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2926) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2927), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2927) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2928), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2929) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2930), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2930) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2931), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2932) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2933), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2933) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2934), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2934) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2936), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2936) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2937), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2937) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2938), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2939) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2940), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2940) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2941), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2942) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2943), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2943) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2944), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2945) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2946), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2946) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2947), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2948) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2949), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2949) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2950), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2950) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2952), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2952) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2953), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2953) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2954), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2955) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2956), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2956) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2957), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2958) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2959), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2959) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2960), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2961) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2962), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2962) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2963), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2964) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2965), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2965) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2966), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2966) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2967), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2968) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2969), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2969) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2970), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2971) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2972), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2972) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2973), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2974) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2975), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2975) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2976), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2977) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2978), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2978) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2979), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2979) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2980), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2981) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2982), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2982) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2983), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2984) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2985), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2985) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2986), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2987) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2988), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2988) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2989), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2989) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2991), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2991) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2992), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2992) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2994), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2994) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2996), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2996) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2997), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(2997) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3012), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3013) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3014), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3014) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3015), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3016) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3017), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3017) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3018), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3019) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3020), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3020) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3021), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3022) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3023), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3023) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3024), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3024) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3026), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3026) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3027), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3027) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3028), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3029) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3030), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3030) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3031), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3032) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3033), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3033) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3034), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3034) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3035), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3036) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3037), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3037) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3038), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3039) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3040), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3040) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3041), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3042) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3043), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3043) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3044), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3044) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3046), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3046) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3047), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3047) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3048), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3049) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3050), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3050) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3051), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3052) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3053), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3053) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3054), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3054) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3056), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3056) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3057), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3057) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3058), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3059) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3060), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3060) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3061), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3062) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3063), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3063) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3064), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3064) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3066), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3066) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3067), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3067) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3068), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3069) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3070), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3070) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3071), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3072) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3073), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3073) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3074), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3074) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3076), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3076) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3077), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3077) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3078), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3079) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3080), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3080) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3081), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3082) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3083), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3083) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3084), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3085) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3086), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3086) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3087), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3087) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3088), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3089) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3090), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3090) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3091), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3092) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3093), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3093) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3094), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3095) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3129), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3129) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3131), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3131) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3132), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3132) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3133), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3134) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3135), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3135) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3136), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3137) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3138), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3138) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3139), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3140) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3141), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3141) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3142), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3142) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3144), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3144) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3145), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3145) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3146), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3147) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3148), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3148) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3149), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3150) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3151), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3151) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3152), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3153) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3154), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3154) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3155), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3156) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3157), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3157) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3158), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3159) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3160), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3160) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3161), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3161) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3163), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3163) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3164), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3164) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3165), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3166) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3167), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3167) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3168), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3169) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3170), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3170) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3171), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3171) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3173), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3173) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3174), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3174) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3175), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3176) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3177), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3177) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3178), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3179) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3180), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3180) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3181), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3181) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3183), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3183) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3184), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3184) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3185), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3186) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3187), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3187) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3188), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3190), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3190) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3191), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3191) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3193), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3193) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3194), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3194) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3195), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3196) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3197), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3197) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3198), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3199) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3200), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3200) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3201), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3202) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3203), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3203) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3204), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3204) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3206), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3206) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3207), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3207) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3208), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3209) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3210), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3210) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3211), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3212) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3213), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3213) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3214), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3215) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3247), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3247) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3249), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3249) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3250), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3251) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3252), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3252) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3253), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3253) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3254), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3255) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3256), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3256) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3257), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3258) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3259), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3259) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3260), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3261) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3262), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(3262) });

            migrationBuilder.InsertData(
                table: "MyDictionaryItems",
                columns: new[] { "Id", "Code", "Created", "DictionaryId", "Modified", "Name" },
                values: new object[,]
                {
                    { 12, "HWS_KOSZALIN", new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1027), 2, new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1027), "Hala Widowiskowo-Sportowa" },
                    { 13, "HWSA_POZNAN", new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1057), 2, new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1057), "Hala widowiskowo-sportowa Arena" },
                    { 14, "AA_LODZ", new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1058), 2, new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1059), "Atlas Arena" },
                    { 15, "HS_CZESTOCHOWA", new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1060), 2, new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1060), "Hala Sportowa" },
                    { 16, "EA_GDANSK_SOPOT", new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1062), 2, new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1062), "Ergo Arena" },
                    { 17, "AS_NIEPORAZ", new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1063), 2, new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1064), "Alvernia Studios" },
                    { 18, "DTBHHL_LODZ", new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1066), 2, new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1066), "DoubleTree by Hilton Hotel Łódź" },
                    { 19, "AG_GLIWICE", new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1067), 2, new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1068), "Arena Gliwice" },
                    { 20, "TA_KRAKOW", new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1069), 2, new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1069), "Tauron Arena" },
                    { 21, "UA_NEWCASTLE", new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1070), 2, new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1071), "Utilita Arena" },
                    { 22, "HS_WROCLAW", new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1073), 2, new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1073), "Hala Stulecia" },
                    { 23, "NA_SZCZECIN", new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1074), 2, new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1075), "Netto Arena" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Events_HallId",
                table: "Events",
                column: "HallId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_MyDictionaryItems_CityId",
                table: "Events",
                column: "CityId",
                principalTable: "MyDictionaryItems",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_MyDictionaryItems_HallId",
                table: "Events",
                column: "HallId",
                principalTable: "MyDictionaryItems",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_MyDictionaryItems_CityId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_MyDictionaryItems_HallId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_HallId",
                table: "Events");

            migrationBuilder.DeleteData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "MyDictionaries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "HallId",
                table: "Events");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5030), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5030) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5033), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5034) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5036), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5036) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5037), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5038) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5039), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5040) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5045), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5045) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5047), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5047) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5049), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5049) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5050), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5051) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5053), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5053) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5055), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5055) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5056), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5057) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5058), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5059) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5060), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5060) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5062), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5063) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5065), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5065) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5066), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5067) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5069), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5069) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5070), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5071) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5072), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5073) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5074), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5074) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5076), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5076) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5077), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5078) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5079), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5080) });

            migrationBuilder.UpdateData(
                table: "Federations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4972), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4972) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4344), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4346) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4352), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4353) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4355), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4355) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4357), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4357) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4359), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4359) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4362), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4362) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4364), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4364) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4365), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4366) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4367), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4368) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4370), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4370) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4371), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4372) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4373), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4374), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4376) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4377), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4377) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4379), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4379) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4380), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4381) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4382), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4382) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4384), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4384) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4386), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4386) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4387), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4388) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4389), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4390) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4391), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4392) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4393), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4393) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4395), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4395) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4396), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4397) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4398), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4398) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4400), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4400) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4401), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4402) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4403), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4403) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4404), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4405) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4406), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4406) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4408), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4408) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4409), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4410) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4412), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4412) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4413), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4414) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4415), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4415) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4416), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4417) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4418), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4418) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4420), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4420) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4421), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4422) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4423), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4423) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4424), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4425) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4470), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4470) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4471), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4472) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4473), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4473) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4475), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4475) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4476), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4477) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4478), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4478) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4480), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4480) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4481), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4482) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4483), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4483) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4484), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4485) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4486), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4487) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4488), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4489) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4490), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4490) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4491), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4492) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4493), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4493) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4495), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4495) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4496), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4497) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4498), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4498) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4499), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4500) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4501), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4501) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4503), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4503) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4504), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4505) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4506), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4506) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4508), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4509) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4510), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4510) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4511), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4512) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4513), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4513) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4515), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4515) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4517), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4517) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4518), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4519) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4520), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4520) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4522), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4522) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4523), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4523) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4525), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4525) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4526), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4527) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4528), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4528) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4529), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4530) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4531), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4531) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4533), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4533) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4534), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4535) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4536), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4536) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4537), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4538) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4539), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4539) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4540), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4541) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4542), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4542) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4544), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4544) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4545), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4545) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4573), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4574) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4575), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4576) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4577), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4577) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4579), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4579) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4580), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4581) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4582), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4582) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4583), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4584) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4585), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4585) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4586), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4587) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4588), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4588) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4590), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4590) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4591), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4592) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4593), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4593) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4594), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4595) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4596), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4596) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4598), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4598) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4599), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4599) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4601), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4601) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4602), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4603) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4604), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4604) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4605), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4606) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4607), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4607) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4609), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4609) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4610), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4611) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4612), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4612) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4613), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4614) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4615), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4615) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4617), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4617) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4618), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4619) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4620), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4620) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4622), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4622) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4623), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4624) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4625), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4625) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4626), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4627) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4628), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4628) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4629), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4630) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4631), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4632) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4633), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4633) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4634), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4635) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4636), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4636) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4661), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4662) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4663), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4663) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4665), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4665) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4666), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4667) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4668), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4668) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4670), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4670) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4671), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4671) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4673), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4673) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4674), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4675) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4676), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4677) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4678), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4678) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4680), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4680) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4681), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4682) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4683), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4683) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4685), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4685) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4686), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4686) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4688), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4688) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4689), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4690) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4691), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4691) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4692), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4693) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4694), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4694) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4696), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4696) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4697), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4698) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4699), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4699) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4700), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4701) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4702), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4702) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4704), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4704) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4705), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4706) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4707), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4707) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4708), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4709) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4710), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4710) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4712), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4712) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4714), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4714) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4715), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4716) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4717), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4717) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4718), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4719) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4720), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4720) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4722), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4722) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4724), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4724) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4725), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4726) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4727), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4727) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4729), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4729) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4730), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4731) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4732), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4732) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4733), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4734) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4735), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4735) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4737), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4737) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4738), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4739) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4740), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4740) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4741), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4742) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4743), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4743) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4744), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4745) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4746), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4747) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4748), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4748) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4773), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4773) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4775), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4775) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4776), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4777) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4778), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4778) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4780), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4780) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4782), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4782) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4783), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4784) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4785), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4785) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4787), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4787) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4788), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4789) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4790), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4792), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4792) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4793), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4794) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4795), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4795) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4797), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4797) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4798), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4799) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4800), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4800) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4801), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4802) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4803), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4803) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4805), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4805) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4806), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4807) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4808), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(4808) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5115), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5115) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5117), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5117) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5119), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5119) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5120), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5121) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5122), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5122) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5124), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5124) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5125), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5126) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5127), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5127) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5128), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5129) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5130), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5131) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5132), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5132) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5133), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5134) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5135), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5135) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5136), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5136) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5137), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5138) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5139), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5139) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5140), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5140) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5142), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5143) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5144), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5144) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5145), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5145) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5146), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5147) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5148), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5148) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5149), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5149) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5150), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5151) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5152), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5152) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5153), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5154) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5155), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5155) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5156), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5156) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5157), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5158) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5159), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5159) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5160), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5160) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5161), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5162) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5199), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5200) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5202), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5202) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5203), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5204) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5205), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5205) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5206), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5206) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5207), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5208) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5209), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5209) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5210), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5211) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5212), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5212) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5213), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5213) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5214), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5215) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5216), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5216) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5217), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5218) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5219), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5219) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5220), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5220) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5221), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5222) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5223), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5223) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5224), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5224) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5225), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5226) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5227), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5227) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5228), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5229) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5230), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5230) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5231), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5231) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5232), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5233) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5234), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5234) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5235), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5236) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5237), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5237) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5238), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5238) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5239), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5240) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5241), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5241) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5242), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5243) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5244), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5244) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5245), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5245) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5247), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5248) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5249), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5249) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5250), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5251) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5252), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5252) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5253), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5253) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5254), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5255) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5256), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5256) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5257), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5257) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5258), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5259) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5260), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5260) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5261), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5262) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5263), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5263) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5264), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5264) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5266), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5266) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5267), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5267) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5268), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5269) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5270), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5270) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5271), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5271) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5272), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5273) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5274), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5274) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5275), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5275) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5277), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5277) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5278), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5278) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5279), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5280) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5281), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5281) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5282), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5282) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5283), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5284) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5285), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5285) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5286), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5287) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5288), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5288) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5289), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5289) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5290), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5291) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5292), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5292) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5335), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5336) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5337), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5338) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5339), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5339) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5340), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5341) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5342), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5342) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5343), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5343) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5345), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5345) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5346), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5346) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5347), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5348) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5349), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5349) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5350), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5351) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5352), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5352) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5353), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5353) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5354), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5355) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5356), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5356) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5357), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5358) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5359), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5359) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5360), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5360) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5361), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5362) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5363), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5363) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5364), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5364) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5365), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5366) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5367), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5367) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5368), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5369) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5370), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5370) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5371), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5371) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5372), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5373) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5374), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5374) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5375), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5376) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5377), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5377) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5378), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5378) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5380), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5381) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5382), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5382) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5383), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5384) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5385), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5385) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5386), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5386) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5388), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5388) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5389), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5389) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5390), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5391) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5392), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5392) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5393), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5393) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5394), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5395) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5396), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5396) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5397), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5398) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5399), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5399) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5400), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5401) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5402), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5402) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5403), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5403) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5404), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5405) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5406), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5406) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5407), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5408) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5409), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5409) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5410), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5410) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5411), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5412) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5413), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5413) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5414), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5414) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5416), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5416) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5417), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5417) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5418), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5419) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5420), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5421), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5422) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5423), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5423) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5424), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5424) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5425), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5426) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5462), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5462) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5463), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5464) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5465), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5465) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5466), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5466) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5467), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5468) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5469), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5469) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5470), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5470) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5472), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5472) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5473), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5473) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5474), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5475) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5476), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5476) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5477), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5477) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5478), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5479) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5480), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5480) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5481), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5482) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5483), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5483) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5484), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5484) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5485), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5486) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5487), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5487) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5488), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5488) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5489), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5490) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5491), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5491) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5492), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5493) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5494), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5494) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5495), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5495) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5497), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5497) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5498), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5498) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5499), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5501), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5501) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5502), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5503) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5504), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5504) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5505), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5505) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5506), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5507) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5508), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5508) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5509), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5509) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5510), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5511) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5512), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5512) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5513), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5514) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5515), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5515) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5516), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5516) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5517), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5518) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5519), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5519) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5520), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5521) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5522), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5522) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5523), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5523) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5524), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5525) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5526), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5526) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5527), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5527) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5528), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5529) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5530), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5531), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5532) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5533), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5533) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5534), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5535) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5536), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5536) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5537), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5537) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5538), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5539) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5540), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5540) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5541), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5541) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5542), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5543) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5544), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5544) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5545), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5546) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5547), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5547) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5548), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5548) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5549), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "MyDictionaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(7537), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(7538) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(7569), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(7570) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(7573), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(7573) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(7575), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(7575) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(7576), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(7577) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(7578), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(7578) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(7580), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(7581) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(7583), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(7583) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(7584), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(7584) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(7586), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(7586) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(7588), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(7588) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(7589), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(7590) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5701), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5701) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5705), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5705) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5706), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5707) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5708), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5708) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5710), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5710) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5712), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5712) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5713), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5714) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5715), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5715) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5716), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5717) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5718), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5719) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5720), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5720) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5721), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5722) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5723), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5723) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5724), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5726), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5726) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5727), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5728) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5729), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5729) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5731), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5731) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5732), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5733) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5734), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5734) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5735), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5736) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5737), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5737) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5738), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5739) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5740), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5740) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5741), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5742) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5743), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5743) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5744), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5745) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5746), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5746) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5747), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5748) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5749), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5749) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5750), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5750) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5752), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5752) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5753), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5753) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5755), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5756) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5798), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5799) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5800), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5801) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5802), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5802) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5803), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5804) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5805), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5805) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5806), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5807) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5808), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5808) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5810), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5810) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5811), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5812) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5813), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5813) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5814), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5815) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5816), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5816) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5817), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5818) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5819), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5819) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5820), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5820) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5822), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5822) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5823), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5824) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5825), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5825) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5826), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5827) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5828), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5828) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5829), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5829) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5831), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5831) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5832), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5832) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5833), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5834) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5835), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5835) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5836), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5837) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5838), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5838) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5839), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5840) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5841), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5841) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5842), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5843) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5844), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5844) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5846), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5847) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5848), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5848) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5850), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5850) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5851), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5852) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5853), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5853) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5854), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5854) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5856), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5856) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5857), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5858) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5859), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5859) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5860), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5860) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5862), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5862) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5863), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5864) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5865), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5865) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5866), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5867) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5868), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5868) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5869), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5870) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5871), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5871) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5872), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5873) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5874), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5874) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5875), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5876) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5877), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5877) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5878), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5879) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5902), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5902) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5903), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5904) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5905), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5905) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5907), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5907) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5908), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5909) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5910), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5910) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5912), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5912) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5913), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5914) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5915), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5915) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5916), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5917) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5918), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5918) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5919), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5920) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5921), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5921) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5922), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5923) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5924), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5924) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5925), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5926) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5927), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5927) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5928), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5929) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5930), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5930) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5931), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5932) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5933), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5933) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5934), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5935) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5936), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5936) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5937), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5938) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5939), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5939) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5940), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5940) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5942), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5942) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5943), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5943) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5944), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5945) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5946), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5946) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5947), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5948) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5949), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5949) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5950), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5951) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5952), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5952) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5953), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5954) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5955), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5955) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5956), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5957) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5958), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5958) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5959), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5959) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5961), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5961) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5962), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5962) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5964), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5964) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5966), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5966) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5968), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5968) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5969), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5969) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5994), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5994) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5995), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5996) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5997), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5997) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5998), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(5999) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6000), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6000) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6001), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6002) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6003), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6003) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6004), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6005) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6006), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6006) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6007), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6008) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6009), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6009) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6010), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6011) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6012), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6012) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6013), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6014) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6015), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6015) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6016), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6017) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6018), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6018) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6019), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6020) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6021), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6021) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6022), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6023) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6024), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6024) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6025), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6026) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6027), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6027) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6028), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6029) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6030), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6030) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6031), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6032) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6033), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6033) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6034), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6035) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6036), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6036) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6037), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6037) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6039), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6039) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6040), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6041) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6042), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6042) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6043), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6044) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6045), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6045) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6046), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6047) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6048), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6048) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6049), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6050) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6051), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6051) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6052), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6053) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6054), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6054) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6055), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6056) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6057), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6057) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6058), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6058) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6060), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6060) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6061), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6062) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6063), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6063) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6064), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6065) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6066), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6066) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6067), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6067) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6069), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6069) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6070), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6070) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6071), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6072) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6073), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6073) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6074), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6075) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6076), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6076) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6077), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6078) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6079), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6079) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6080), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6081) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6082), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6082) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6107), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6107) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6109), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6109) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6110), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6110) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6112), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6112) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6113), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6114) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6115), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6115) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6116), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6117) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6118), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6118) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6119), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6120) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6121), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6121) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6122), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6123) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6124), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6124) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6125), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6126) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6127), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6127) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6128), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6128) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6130), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6130) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6131), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6131) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6133), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6133) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6134), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6134) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6135), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6136) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6137), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6137) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6138), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6139) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6140), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6140) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6141), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6141) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6142), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6142) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6143), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6144) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6145), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6145) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6146), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6147) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6148), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6148) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6149), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6150) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6151), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6151) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6152), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6152) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6154), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6154) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6155), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6155) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6156), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6157) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6158), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6158) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6159), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6160) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6161), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6161) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6162), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6163) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6164), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6164) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6165), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6166) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6167), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6167) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6168), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6169) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6170), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6170) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6171), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6172) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6173), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6173) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6174), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6174) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6176), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6176) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6177), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6177) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6179), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6179) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6180), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6180) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6181), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6182) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6183), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6183) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6184), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6185) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6186), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6186) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6187), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6188) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6189), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6189) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6190), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6191) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6192), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6192) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6193), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6194) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6210), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6210) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6212), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6212) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6213), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6213) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6215), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6215) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6216), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6217) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6219), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6220) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6221), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6221) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6222), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6223) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6224), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6224) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6225), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6226) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6227), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6227) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6228), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6229) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6230), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6230) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6231), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6232) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6233), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6233) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6234), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6235) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6236), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6236) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6238), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6238) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6239), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6241), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6241) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6242), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6243) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6244), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6244) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6245), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6246) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6247), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6247) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6248), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6250) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6251), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6251) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6252), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6253) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6254), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6254) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6255), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6256) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6315), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6316) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6317), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6317) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6318), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6319) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6320), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6320) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6321), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6322) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6323), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6323) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6325), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6325) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6326), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6326) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6328), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6328) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6329), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6330) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6331), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6331) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6332), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6332) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6334), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6334) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6335), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6335) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6336), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6337) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6338), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6338) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6340), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6340) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6341), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6341) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6343), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6343) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6344), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6345) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6347), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6347) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6348), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6348) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6350), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6350) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6351), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6352) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6353), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6353) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6354), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6355) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6356), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6356) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6357), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6357) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6359), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6359) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6360), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6360) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6361), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6362) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6363), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6363) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6364), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6365) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6366), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6366) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6367), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6368) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6369), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6369) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6370), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6371) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6372), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6372) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6373), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6374) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6375), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6375) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6376), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6377) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6378), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6378) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6380), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6380) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6381), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6382) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6383), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6383) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6384), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6385) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6386), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6386) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6387), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6388) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6389), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6389) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6390), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6391) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6392), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6392) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6393), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6394) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6395), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6395) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6396), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6397) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6398), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6398) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6399), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6400) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6401), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6401) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6402), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6403) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6404), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6404) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6405), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6406) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6439), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6440) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6441), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6441) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6442), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6443) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6444), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6444) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6445), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6446) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6447), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6447) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6448), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6449) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6450), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6450) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6451), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6452) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6453), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6453) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6454), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6455) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6456), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6456) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6457), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6458) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6459), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6459) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6460), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6461) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6462), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6462) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6463), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6464) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6465), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6465) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6466), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6467) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6468), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6468) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6469), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6470) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6471), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6471) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6472), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6472) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6474), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6474) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6475), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6475) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6476), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6477) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6478), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6478) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6479), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6480) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6481), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6481) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6482), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6483) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6484), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6484) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6485), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6486) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6487), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6487) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6488), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6489) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6490), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6490) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6491), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6491) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6493), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6493) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6494), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6494) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6496), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6496) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6497), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6497) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6498), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6499) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6500), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6500) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6501), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6502) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6503), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6503) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6504), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6505) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6506), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6506) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6507), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6508) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6509), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6509) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6510), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6511) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6512), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6512) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6513), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6514) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6515), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6515) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6516), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6516) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6518), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6518) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6519), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6519) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6521), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6521) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6522), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6523) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6524), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6524) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6525), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6526) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6527), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6527) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6551), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6551) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6553), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6553) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6554), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6554) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6556), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6556) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6557), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6558) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6559), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6559) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6560), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6561) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6562), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6562) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6563), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6563) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6565), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6565) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6566), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6566) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6567), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6568) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6569), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6569) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6571), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6571) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6572), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6573) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6574), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6574) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6575), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6576) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6577), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6577) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6578), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6579) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6580), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6580) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6581), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6582) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6583), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6583) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6584), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6585) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6586), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6586) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6587), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6588) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6589), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6589) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6590), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6590) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6592), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6592) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6593), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6593) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6595), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6595) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6596), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6596) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6597), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6598) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6599), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6599) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6600), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6601) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6602), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6602) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6603), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6604) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6605), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6605) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6606), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6607) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6608), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6608) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6609), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6610) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6611), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6611) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6612), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6613) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6614), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6614) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6615), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6616) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6617), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6617) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6618), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6619) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6620), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6620) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6621), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6622) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6623), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6623) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6624), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6624) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6626), new DateTime(2023, 12, 11, 22, 14, 39, 970, DateTimeKind.Utc).AddTicks(6626) });

            migrationBuilder.AddForeignKey(
                name: "FK_Events_MyDictionaryItems_CityId",
                table: "Events",
                column: "CityId",
                principalTable: "MyDictionaryItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
