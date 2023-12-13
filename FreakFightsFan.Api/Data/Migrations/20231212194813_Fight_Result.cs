using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FreakFightsFan.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class Fight_Result : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FightResult",
                table: "TeamFighters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6394), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6395) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6398), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6399) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6401), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6401) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6403), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6403) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6405), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6405) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6408), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6409) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6411), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6411) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6413), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6414) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6415), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6416) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6418), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6419) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6420), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6421) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6422), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6423) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6425), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6425) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6427), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6427) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6429), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6429) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6431), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6431) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6433), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6433) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6436), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6436) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6438), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6438) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6440), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6440) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6442), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6442) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6444), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6444) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6446), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6446) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6448), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6448) });

            migrationBuilder.UpdateData(
                table: "Federations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6356), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6357) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5718), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5718) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5725), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5727), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5727) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5728), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5729) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5730), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5731) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5733), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5733) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5734), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5735) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5736), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5736) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5738), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5738) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5740), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5740) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5741), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5742) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5743), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5744) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5745), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5746) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5747), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5747) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5749), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5749) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5750), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5751) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5752), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5753) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5755), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5755) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5756), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5757) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5758), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5758) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5760), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5760) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5761), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5762) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5763), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5763) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5765), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5765) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5766), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5767) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5768), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5768) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5770), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5770) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5771), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5772) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5773), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5773) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5775), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5775) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5776), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5777) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5778), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5778) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5780), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5780) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5782), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5783) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5784), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5784) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5786), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5786) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5787), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5788) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5789), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5789) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5825), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5825) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5826), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5827) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5828), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5828) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5830), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5830) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5831), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5832) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5833), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5834) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5835), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5835) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5836), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5837) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5838), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5838) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5840), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5840) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5841), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5842) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5843), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5843) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5845), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5845) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5846), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5847) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5848), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5848) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5850), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5850) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5852), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5852) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5853), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5854) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5855), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5855) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5857), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5857) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5858), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5859) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5860), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5860) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5862), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5862) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5863), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5864) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5865), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5865) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5866), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5867) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5868), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5869) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5871), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5871) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5873), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5873) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5875), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5875) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5876), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5877) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5878), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5878) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5880), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5880) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5881), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5882) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5883), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5883) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5884), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5885) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5887), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5887) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5889), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5889) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5890), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5891) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5892), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5892) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5894), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5894) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5895), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5896) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5897), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5897) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5899), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5899) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5900), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5901) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5902), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5902) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5904), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5904) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5934), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5934) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5936), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5936) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5937), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5938) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5939), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5940) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5941), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5941) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5943), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5943) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5944), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5945) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5946), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5946) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5948), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5948) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5950), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5950) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5951), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5952) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5953), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5953) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5955), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5955) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5956), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5957) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5958), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5958) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5960), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5960) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5961), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5962) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5963), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5963) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5965), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5965) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5966), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5967) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5968), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5968) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5970), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5970) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5971), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5972) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5973), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5974) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5975), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5975) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5976), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5977) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5978), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5979) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5980), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5980) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5981), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5982) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5983), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5983) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5985), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5985) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5987), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5987) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5988), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5989) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5990), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5990) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5991), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5992) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5993), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5993) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5995), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5995) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5996), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5997) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5998), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5998) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6000), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6000) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6001), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6002) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6003), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6003) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6005), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6005) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6006), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6007) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6038), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6039) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6040), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6041) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6042), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6042) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6043), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6044) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6045), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6046) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6047), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6047) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6049), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6049) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6050), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6051) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6052), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6052) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6054), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6054) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6055), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6056) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6057), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6057) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6058), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6059) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6060), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6060) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6062), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6062) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6063), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6064) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6065), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6065) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6067), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6067) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6068), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6069) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6070), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6070) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6072), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6072) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6073), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6075), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6075) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6077), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6077) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6078), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6079) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6080), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6080) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6082), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6082) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6083), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6084) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6085), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6085) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6087), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6087) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6088), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6089) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6090), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6090) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6092), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6092) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6093), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6094) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6095), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6095) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6096), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6097) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6098), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6098) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6100), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6100) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6101), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6102) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6103), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6103) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6105), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6105) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6106), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6107) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6108), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6108) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6110), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6110) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6112), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6112) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6113), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6114) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6115), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6115) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6116), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6117) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6118), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6118) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6120), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6120) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6148), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6148) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6150), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6151) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6152), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6152) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6154), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6154) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6155), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6156) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6157), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6157) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6158), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6159) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6160), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6160) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6162), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6162) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6163), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6164) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6165), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6165) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6167), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6167) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6168), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6169) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6170), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6170) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6172), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6172) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6173), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6174) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6175), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6175) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6177), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6177) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6178), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6179) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6180), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6180) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6182), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6182) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6183), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6184) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6185), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6185) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6187), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6187) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6188), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6189) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6190), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6191) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6488), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6488) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6493), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6493) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6495), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6495) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6496), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6497) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6498), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6498) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6500), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6500) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6501), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6502) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6503), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6503) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6504), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6505) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6506), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6507) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6508), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6508) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6509), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6510) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6511), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6511) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6512), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6513) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6514), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6514) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6515), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6516) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6517), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6517) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6519), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6519) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6520), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6521) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6522), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6522) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6523), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6524) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6525), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6525) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6545), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6545) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6546), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6546) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6548), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6548) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6549), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6550) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6551), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6551) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6552), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6552) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6554), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6554) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6555), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6555) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6557), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6557) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6558), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6558) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6559), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6560) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6562), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6562) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6563), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6564) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6565), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6565) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6566), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6567) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6568), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6568) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6569), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6570) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6571), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6571) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6572), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6572) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6574), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6574) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6575), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6575) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6577), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6577) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6578), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6578) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6579), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6580) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6581), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6581) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6582), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6583) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6584), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6584) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6585), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6586) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6587), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6587) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6588), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6589) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6590), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6590) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6591), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6591) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6593), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6593) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6594), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6595) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6596), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6596) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6597), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6597) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6599), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6599) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6600), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6600) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6601), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6602) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6603), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6603) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6604), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6605) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6606), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6606) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6607), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6608) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6610), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6610) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6611), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6611) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6613), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6613) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6614), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6614) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6615), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6616) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6617), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6617) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6618), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6619) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6620), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6620) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6621), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6622) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6623), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6623) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6624), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6625) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6626), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6626) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6627), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6629), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6629) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6630), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6630) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6632), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6632) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6633), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6633) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6634), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6635) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6636), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6636) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6637), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6638) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6639), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6639) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6640), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6641) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6642), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6642) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6700), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6700) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6701), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6702) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6703), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6703) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6704), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6705) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6706), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6706) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6707), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6708) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6709), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6709) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6710), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6710) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6711), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6712) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6713), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6713) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6715), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6715) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6716), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6716) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6717), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6718) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6719), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6719) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6720), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6721) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6722), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6722) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6723), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6724) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6725), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6725) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6726), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6727) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6728), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6728) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6729), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6729) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6731), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6731) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6732), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6732) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6733), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6734) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6735), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6735) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6736), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6737) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6738), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6738) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6739), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6740) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6741), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6741) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6742), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6743) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6744), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6744) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6745), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6745) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6747), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6747) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6748), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6748) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6749), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6750) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6751), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6751) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6752), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6753) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6754), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6754) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6755), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6756) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6757), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6757) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6758), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6759) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6761), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6761) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6762), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6763) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6764), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6764) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6765), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6766) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6767), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6767) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6768), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6769) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6770), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6770) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6771), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6771) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6773), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6773) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6774), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6774) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6775), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6776) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6777), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6777) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6778), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6779) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6780), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6780) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6781), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6782) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6783), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6783) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6784), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6785) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6786), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6786) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6787), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6787) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6789), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6789) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6790), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6790) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6791), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6792) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6793), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6793) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6837), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6838) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6839), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6839) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6841), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6841) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6842), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6842) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6844), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6844) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6845), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6845) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6846), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6847) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6848), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6848) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6849), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6850) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6851), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6851) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6852), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6852) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6854), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6854) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6855), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6855) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6856), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6858), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6858) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6859), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6860) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6861), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6861) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6862), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6863) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6864), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6864) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6865), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6866) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6867), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6867) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6868), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6868) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6869), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6870) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6871), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6871) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6872), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6873) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6874), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6874) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6875), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6876) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6877), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6877) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6878), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6879) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6880), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6880) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6881), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6881) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6883), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6883) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6884), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6884) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6885), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6886) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6887), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6887) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6888), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6889) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6890), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6890) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6891), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6892) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6893), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6893) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6894), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6895) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6896), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6896) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6897), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6897) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6899), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6899) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6900), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6900) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6901), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6902) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6903), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6903) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6904), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6905) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6906), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6906) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6907), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6908) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6909), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6909) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6910), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6911) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6912), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6912) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6913), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6913) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6915), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6915) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6916), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6916) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6917), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6918) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6919), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6919) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6920), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6921) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6922), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6922) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6923), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6924) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6925), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6925) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6926), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6927) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6928), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6928) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6929), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6929) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6930), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6932), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6932) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6933), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6934) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6935), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6935) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6936), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6937) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6938), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6938) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6939), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6940) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6941), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6941) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6942), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6942) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6944), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(6944) });

            migrationBuilder.UpdateData(
                table: "MyDictionaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5492), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5495) });

            migrationBuilder.UpdateData(
                table: "MyDictionaries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5499), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5571), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5572) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5577), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5577) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5579), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5581), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5582) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5583), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5586), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5587) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5588), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5589) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5590), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5592), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5592) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5595), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5595) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5596), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5597) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5598), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5598) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5599), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5601), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5601) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5602), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5603) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5604), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5604) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5606), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5606) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5608), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5608) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5609), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5611), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5611) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5660), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5661) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5662), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5662) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5664), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(5664) });

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 1,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 2,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 3,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 4,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 5,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 6,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 7,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 8,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 9,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 10,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 11,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 12,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 13,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 14,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 15,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 16,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 17,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 18,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 19,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 20,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 21,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 22,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 23,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 24,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 25,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 26,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 27,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 28,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 29,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 30,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 31,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 32,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 33,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 34,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 35,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 36,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 37,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 38,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 39,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 40,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 41,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 42,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 43,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 44,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 45,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 46,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 47,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 48,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 49,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 50,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 51,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 52,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 53,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 54,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 55,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 56,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 57,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 58,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 59,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 60,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 61,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 62,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 63,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 64,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 65,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 66,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 67,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 68,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 69,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 70,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 71,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 72,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 73,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 74,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 75,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 76,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 77,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 78,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 79,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 80,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 81,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 82,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 83,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 84,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 85,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 86,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 87,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 88,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 89,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 90,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 91,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 92,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 93,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 94,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 95,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 96,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 97,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 98,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 99,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 100,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 101,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 102,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 103,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 104,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 105,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 106,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 107,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 108,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 109,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 110,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 111,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 112,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 113,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 114,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 115,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 116,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 117,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 118,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 119,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 120,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 121,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 122,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 123,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 124,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 125,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 126,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 127,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 128,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 129,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 130,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 131,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 132,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 133,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 134,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 135,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 136,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 137,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 138,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 139,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 140,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 141,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 142,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 143,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 144,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 145,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 146,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 147,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 148,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 149,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 150,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 151,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 152,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 153,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 154,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 155,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 156,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 157,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 158,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 159,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 160,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 161,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 162,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 163,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 164,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 165,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 166,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 167,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 168,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 169,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 170,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 171,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 172,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 173,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 174,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 175,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 176,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 177,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 178,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 179,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 180,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 181,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 182,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 183,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 184,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 185,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 186,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 187,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 188,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 189,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 190,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 191,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 192,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 193,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 194,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 195,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 196,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 197,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 198,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 199,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 200,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 201,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 202,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 203,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 204,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 205,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 206,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 207,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 208,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 209,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 210,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 211,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 212,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 213,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 214,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 215,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 216,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 217,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 218,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 219,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 220,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 221,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 222,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 223,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 224,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 225,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 226,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 227,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 228,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 229,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 230,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 231,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 232,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 233,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 234,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 235,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 236,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 237,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 238,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 239,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 240,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 241,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 242,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 243,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 244,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 245,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 246,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 247,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 248,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 249,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 250,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 251,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 252,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 253,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 254,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 255,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 256,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 257,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 258,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 259,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 260,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 261,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 262,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 263,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 264,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 265,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 266,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 267,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 268,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 269,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 270,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 271,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 272,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 273,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 274,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 275,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 276,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 277,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 278,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 279,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 280,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 281,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 282,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 283,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 284,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 285,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 286,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 287,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 288,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 289,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 290,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 291,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 292,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 293,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 294,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 295,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 296,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 297,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 298,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 299,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 300,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 301,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 302,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 303,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 304,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 305,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 306,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 307,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 308,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 309,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 310,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 311,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 312,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 313,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 314,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 315,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 316,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 317,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 318,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 319,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 320,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 321,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 322,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 323,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 324,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 325,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 326,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 327,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 328,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 329,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 330,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 331,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 332,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 333,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 334,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 335,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 336,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 337,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 338,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 339,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 340,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 341,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 342,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 343,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 344,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 345,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 346,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 347,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 348,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 349,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 350,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 351,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 352,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 353,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 354,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 355,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 356,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 357,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 358,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 359,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 360,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 361,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 362,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 363,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 364,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 365,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 366,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 367,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 368,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 369,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 370,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 371,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 372,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 373,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 374,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 375,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 376,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 377,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 378,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 379,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 380,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 381,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 382,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 383,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 384,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 385,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 386,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 387,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 388,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 389,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 390,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 391,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 392,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 393,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 394,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 395,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 396,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 397,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 398,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 399,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 400,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 401,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 402,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 403,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 404,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 405,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 406,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 407,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 408,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 409,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 410,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 411,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 412,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 413,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 414,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 415,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 416,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 417,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 418,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 419,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 420,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 421,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 422,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 423,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 424,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 425,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 426,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 427,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 428,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 429,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 430,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 431,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 432,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 433,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 434,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 435,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 436,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 437,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 438,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 439,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 440,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 441,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 442,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 443,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 444,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 445,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 446,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 447,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 448,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 449,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 450,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 451,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 452,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 453,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 454,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 455,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 456,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 457,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TeamFighters",
                keyColumn: "Id",
                keyValue: 458,
                column: "FightResult",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7111), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7112) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7114), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7114) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7116), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7116) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7117), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7118) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7119), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7119) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7121), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7122) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7123), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7124) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7125), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7125) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7126), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7127) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7129), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7129) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7130), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7131) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7132), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7132) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7134), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7134) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7135), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7136) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7137), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7137) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7139), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7139) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7140), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7141) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7142), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7143) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7144), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7144) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7146), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7146) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7147), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7148) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7149), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7149) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7150), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7151) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7152), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7152) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7153), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7154) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7155), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7155) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7156), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7157) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7158), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7158) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7160), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7160) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7161), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7161) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7163), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7163) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7197), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7198) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7199), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7199) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7201), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7202) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7203), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7203) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7205), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7205) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7206), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7207) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7208), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7208) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7209), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7210) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7211), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7211) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7213), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7213) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7214), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7214) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7216), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7216) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7217), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7218) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7219), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7219) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7220), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7221) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7222), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7222) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7223), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7224) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7225), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7225) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7226), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7227) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7228), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7228) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7229), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7230) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7231), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7231) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7232), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7233) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7234), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7234) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7236), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7236) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7237), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7238) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7239), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7239) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7240), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7241) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7242), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7242) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7243), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7244) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7245), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7245) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7247), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7247) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7248), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7249) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7250), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7250) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7252), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7252) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7254), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7254) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7255), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7256) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7257), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7257) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7258), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7259) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7260), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7260) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7261), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7262) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7263), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7263) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7264), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7265) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7266), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7266) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7268), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7268) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7269), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7270) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7271), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7271) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7272), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7273) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7274), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7274) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7302), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7302) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7303), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7304) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7305), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7305) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7306), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7307) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7308), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7308) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7310), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7310) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7311), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7312) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7313), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7313) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7314), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7315) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7316), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7316) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7317), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7318) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7319), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7319) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7320), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7321) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7322), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7322) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7324), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7324) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7325), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7326) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7327), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7327) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7328), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7329) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7330), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7330) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7331), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7332) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7333), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7333) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7334), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7335) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7336), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7336) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7338), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7338) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7339), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7339) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7341), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7341) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7342), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7342) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7344), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7344) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7345), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7346) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7347), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7347) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7463), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7466), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7466) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7468), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7468) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7469), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7470) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7471), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7471) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7472), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7473) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7474), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7474) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7475), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7476) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7477), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7477) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7479), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7479) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7480), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7481) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7482), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7482) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7483), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7484) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7485), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7485) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7486), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7487) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7488), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7488) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7489), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7490) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7491), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7491) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7493), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7493) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7527), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7528) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7529), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7529) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7530), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7531) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7532), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7532) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7534), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7534) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7535), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7536) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7537), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7537) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7538), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7539) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7540), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7540) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7541), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7542) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7543), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7543) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7544), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7545) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7546), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7546) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7548), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7548) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7549), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7549) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7551), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7551) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7552), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7553) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7554), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7554) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7555), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7556) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7557), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7557) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7558), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7559) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7560), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7560) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7562), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7562) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7563), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7563) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7565), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7565) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7566), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7567) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7568), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7568) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7569), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7570) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7571), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7571) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7572), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7573) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7574), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7574) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7575), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7576) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7577), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7577) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7579), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7580), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7580) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7582), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7582) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7583), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7583) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7585), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7585) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7586), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7587) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7588), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7588) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7589), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7590) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7591), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7591) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7592), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7593) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7594), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7594) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7595), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7596) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7597), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7597) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7599), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7599) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7600), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7600) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7602), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7602) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7603), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7604) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7605), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7605) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7606), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7607) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7608), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7608) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7610), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7610) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7611), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7612) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7613), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7613) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7643), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7644) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7645), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7645) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7647), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7647) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7648), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7649) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7650), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7650) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7651), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7652) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7653), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7654) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7655), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7655) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7656), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7657) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7658), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7658) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7659), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7660) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7661), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7661) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7663), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7663) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7664), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7664) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7666), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7666) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7667), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7668) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7669), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7669) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7670), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7671) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7672), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7672) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7673), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7674) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7675), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7675) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7676), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7677) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7678), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7678) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7680), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7680) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7681), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7681) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7683), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7683) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7684), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7684) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7686), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7686) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7687), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7688) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7689), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7689) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7690), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7691) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7692), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7692) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7694), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7694) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7695), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7695) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7697), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7697) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7698), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7698) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7700), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7700) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7701), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7702) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7703), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7703) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7704), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7705) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7706), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7706) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7708), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7708) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7709), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7709) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7711), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7711) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7712), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7713) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7714), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7714) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7715), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7716) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7717), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7717) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7718), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7719) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7720), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7720) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7722), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7722) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7723), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7723) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7725), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7725) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7726), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7727) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7728), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7728) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7729), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7731), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7731) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7732), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7733) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7734), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7734) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7735), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7736) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7758), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7759) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7760), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7761) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7762), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7762) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7763), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7764) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7765), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7765) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7766), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7767) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7768), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7768) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7770), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7770) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7771), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7771) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7773), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7773) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7774), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7775) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7776), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7776) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7779), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7779) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7780), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7781) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7782), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7782) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7784), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7784) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7785), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7785) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7787), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7787) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7788), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7789) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7790), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7790) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7791), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7792) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7793), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7793) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7794), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7795) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7796), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7796) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7798), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7798) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7799), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7799) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7801), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7801) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7802), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7803) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7804), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7804) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7874), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7875) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7876), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7877) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7878), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7878) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7879), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7880) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7881), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7881) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7883), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7883) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7884), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7884) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7886), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7886) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7887), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7888) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7889), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7889) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7890), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7891) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7892), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7892) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7893), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7894) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7895), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7895) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7897), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7897) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7898), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7898) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7900), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7900) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7901), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7902) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7903), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7903) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7904), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7905) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7906), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7906) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7907), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7909), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7909) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7911), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7911) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7912), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7913) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7914), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7914) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7915), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7916) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7917), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7917) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7918), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7919) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7920), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7920) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7922), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7922) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7924), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7924) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7925), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7926) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7927), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7927) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7928), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7929) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7930), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7930) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7931), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7932) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7933), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7933) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7935), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7935) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7936), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7937) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7938), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7938) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7939), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7940) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7941), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7941) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7942), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7943) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7944), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7944) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7946), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7946) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7947), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7947) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7949), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7950) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7951), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7951) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7952), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7953) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7954), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7954) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7956), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7956) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7957), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7957) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7959), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7959) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7960), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7961) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7962), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7962) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7963), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7964) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7965), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7965) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7966), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7967) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7968), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(7968) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8020), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8020) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8021), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8022) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8023), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8023) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8025), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8025) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8026), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8027) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8028), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8028) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8029), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8030) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8031), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8031) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8033), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8034), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8034) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8036), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8036) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8037), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8038) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8039), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8039) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8040), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8041) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8042), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8042) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8043), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8044) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8045), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8045) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8046), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8047) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8048), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8048) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8050), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8050) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8051), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8052) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8053), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8053) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8054), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8055) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8056), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8056) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8057), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8058) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8059), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8059) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8061), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8061) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8062), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8062) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8064), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8064) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8065), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8066) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8067), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8067) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8068), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8069) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8070), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8070) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8071), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8072) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8073), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8073) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8074), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8075) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8076), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8076) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8078), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8078) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8079), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8081), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8081) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8082), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8083) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8084), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8084) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8085), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8086) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8087), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8087) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8088), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8089) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8090), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8090) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8091), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8092) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8093), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8093) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8095), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8095) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8096), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8096) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8098), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8098) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8099), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8099) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8101), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8101) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8102), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8103) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8104), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8104) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8105), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8106) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8107), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8107) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8108), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8109) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8110), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8110) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8111), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8112) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8140), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8140) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8141), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8142) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8143), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8143) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8144), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8145) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8146), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8146) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8148), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8148) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8149), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8150) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8151), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8151) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8152), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8153) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8154), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8154) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8155), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8156) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8157), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8157) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8159), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8159) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8160), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8160) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8162), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8162) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8163), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8164) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8165), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8165) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8166), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8167) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8168), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8168) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8169), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8170) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8171), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8171) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8172), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8173) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8174), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8174) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8176), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8176) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8177), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8178) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8179), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8179) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8180), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8181) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8182), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8182) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8183), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8184) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8185), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8185) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8186), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8187) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8188), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8188) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8190), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8190) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8191), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8192) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8193), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8193) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8194), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8195) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8196), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8196) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8197), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8198) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8199), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8199) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8201), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8201) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8202), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8202) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8204), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8204) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8205), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8206) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8207), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8207) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8208), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8209) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8210), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8210) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8211), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8212) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8213), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8213) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8214), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8215) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8216), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8216) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8218), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8218) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8219), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8219) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8221), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8221) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8222), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8223) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8224), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8224) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8225), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8226) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8227), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8227) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8228), new DateTime(2023, 12, 12, 19, 48, 12, 303, DateTimeKind.Utc).AddTicks(8229) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FightResult",
                table: "TeamFighters");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1752), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1752) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1756), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1756) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1758), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1759) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1760), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1761) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1762), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1763) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1766), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1766) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1768), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1768) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1770), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1770) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1772), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1772) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1775), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1775) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1777), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1777) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1779), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1779) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1781), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1781) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1783), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1783) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1785), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1785) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1786), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1787) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1788), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1789) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1791), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1791) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1793), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1793) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1794), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1795) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1796), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1797) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1798), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1798) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1800), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1800) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1802), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1802) });

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

            migrationBuilder.UpdateData(
                table: "MyDictionaries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(937), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(938) });

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
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1027), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1027) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1057), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1057) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1058), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1059) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1060), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1060) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1062), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1062) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1063), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1064) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1066), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1066) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1067), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1068) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1069), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1069) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1070), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1071) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1073), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1073) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1074), new DateTime(2023, 12, 12, 16, 37, 24, 696, DateTimeKind.Utc).AddTicks(1075) });

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
        }
    }
}
