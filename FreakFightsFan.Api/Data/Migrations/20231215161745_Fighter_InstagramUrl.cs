using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FreakFightsFan.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class Fighter_InstagramUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "InstagramUrl",
                table: "Fighters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(828), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(829) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(832), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(832) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(834), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(835) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(836), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(837) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(838), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(839) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(843), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(843) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(845), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(845) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(847), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(847) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(849), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(849) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(851), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(851) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(853), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(853) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(855), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(855) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(857), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(857) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(859), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(859) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(861), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(861) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(863), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(863) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(865), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(865) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(867), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(868) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(869), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(870) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(871), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(871) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(873), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(873) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(875), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(875) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(877), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(877) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(909), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(909) });

            migrationBuilder.UpdateData(
                table: "Federations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(796), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(797) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(203), "https://www.instagram.com/bogas_official", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(204) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(210), "https://www.instagram.com/ztrolowanyt/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(210) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(212), "https://www.instagram.com/wilczaktrenuje/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(212) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(214), "https://www.instagram.com/lupa_k.o/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(214) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(216), "https://www.instagram.com/travelwithmops/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(216) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(218), "https://www.instagram.com/krystian.wilczak/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(218) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(220), "https://www.instagram.com/handke_michal_/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(220) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(221), "https://www.instagram.com/wiewior_official/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(222) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(223), "https://www.instagram.com/dawambro/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(223) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(225), "https://www.instagram.com/dawidozdobateam/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(226) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(227), "https://www.instagram.com/piotr_celej/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(227) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(229), null, new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(229) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(231), "https://www.instagram.com/danielmagical/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(231) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(232), "https://www.instagram.com/adrianpolak/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(233) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(234), "https://www.instagram.com/boxdel/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(234) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(236), "https://www.instagram.com/guzikyt/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(236) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(237), "https://www.instagram.com/kamilkasti/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(238) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(240), "https://www.instagram.com/artur_walus_walczak/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(240) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(241), "https://www.instagram.com/czapistrong_mman/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(242) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(243), "https://www.instagram.com/piotr_loveislandpolska/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(244) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(245), "https://www.instagram.com/pablotybori/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(245) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(247), "https://www.instagram.com/pietrokluk/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(247) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(248), "https://www.instagram.com/szef8989/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(249) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(250), "https://www.instagram.com/bonusbgc_official/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(250) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(252), "https://www.instagram.com/amadeusznolove/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(252) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(253), "https://www.instagram.com/bystrzaktv/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(254) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(255), "https://www.instagram.com/adbunio/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(255) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(257), "https://www.instagram.com/dawid.malczynski/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(257) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(258), "https://www.instagram.com/rafonixofficial/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(259) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(288), "https://www.instagram.com/kamilhassi/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(289) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(290), "https://www.instagram.com/bodychrist.official/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(291) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(292), "https://www.instagram.com/projekt_jasnowidz/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(293) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(294), "https://www.instagram.com/ruby_nolove_official/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(294) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(296), "https://www.instagram.com/donkasjo/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(297) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(298), "https://www.instagram.com/filipek1995/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(299) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(300), "https://www.instagram.com/ryba_free/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(300) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(302), "https://www.instagram.com/taxizlotowa/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(302) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(303), "https://www.instagram.com/linkimaster/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(304) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(305), "https://www.instagram.com/esmeraldagodlewska_official/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(306) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(307), "https://www.instagram.com/isamupt/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(307) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(309), "https://www.instagram.com/deejaypallaside/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(309) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(311), "https://www.instagram.com/jongmen_official/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(311) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(312), "https://www.instagram.com/king.tomb/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(313) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(314), "https://www.instagram.com/kizo_wnik_058/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(314) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(316), "https://www.instagram.com/mielonidas/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(316) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(317), "https://www.instagram.com/kubanczyk.official/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(318) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(319), "https://www.instagram.com/medusaoficjalnie/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(319) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(321), null, new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(321) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(322), "https://www.instagram.com/lilmasti/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(323) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(324), "https://www.instagram.com/just_oleg.official/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(324) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(326), "https://www.instagram.com/ewel0na/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(326) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(328), "https://www.instagram.com/tomek_olejnik/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(328) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(329), "https://www.instagram.com/_minimajk/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(330) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(331), "https://www.instagram.com/kruszwil/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(331) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(333), "https://www.instagram.com/marcinmalczynski/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(333) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(334), "https://www.instagram.com/marcin.najman/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(335) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(336), "https://www.instagram.com/szewcowaty/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(336) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(338), "https://www.instagram.com/alan.kwiecinski92/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(338) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(339), "https://www.instagram.com/arkadiusz_tancula/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(340) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(341), "https://www.instagram.com/qbik95/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(342) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(343), "https://www.instagram.com/cypis89/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(343) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(345), "https://www.instagram.com/m_rataaj/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(345) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(346), "https://www.instagram.com/lpro.official/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(347) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(348), "https://www.instagram.com/piotr.piechowiak/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(348) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(350), "https://www.instagram.com/wojtekgola/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(350) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(352), "https://www.instagram.com/zusjeofficial/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(353) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(354), "https://www.instagram.com/daroo_lew/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(354) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(356), "https://www.instagram.com/hejter_96/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(356) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(357), "https://www.instagram.com/martirenti/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(358) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(359), "https://www.instagram.com/popek_oficjalnie/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(359) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(384), "https://www.instagram.com/stifler16cm/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(384) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(386), "https://www.instagram.com/iamgamoufall/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(386) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(388), "https://www.instagram.com/podroze_wojownika_youtube/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(388) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(389), "https://www.instagram.com/mortalcioyt/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(390) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(391), "https://www.instagram.com/dagmara_szewczyk/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(391) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(393), "https://www.instagram.com/szeli_aesthetic/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(393) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(394), "https://www.instagram.com/arab_na_ficie/tagged/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(395) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(396), "https://www.instagram.com/sobota_flow/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(396) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(398), "https://www.instagram.com/marcindubiel/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(398) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(399), "https://www.instagram.com/kacperblonsky/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(400) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(401), "https://www.instagram.com/way.of.blonde/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(402) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(403), "https://www.instagram.com/anabodyfitness_/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(403) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(405), "https://www.instagram.com/vandalekk/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(405) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(406), "https://www.instagram.com/kubapost_/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(407) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(408), "https://www.instagram.com/filipzabielski/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(408) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(410), "https://www.instagram.com/patrykos.official/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(410) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(411), "https://www.instagram.com/ponczek_endomorfik/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(412) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(413), "https://www.instagram.com/kamiszkolandia/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(413) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(415), "https://www.instagram.com/sawardega_wataha/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(415) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(416), "https://www.instagram.com/miejski_drwal_insta/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(417) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(418), "https://www.instagram.com/michalgala_official/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(418) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(420), "https://www.instagram.com/smieszekmikollaj/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(420) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(422), "https://www.instagram.com/matek_haribo/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(422) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(423), "https://www.instagram.com/mateusz_muranski/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(425), "https://www.instagram.com/czaronykiel/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(425) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(427), "https://www.instagram.com/storminnorman6116/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(427) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(428), "https://www.instagram.com/dragon_xmma/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(429) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(430), "https://www.instagram.com/rogerirlik/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(430) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(432), "https://www.instagram.com/adrian_wieliczko/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(432) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(433), "https://www.instagram.com/grackoo.m/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(434) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(435), "https://www.instagram.com/wujaszek_fericze_kanapowcy_ttv/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(435) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(437), "https://www.instagram.com/patrycjawiejaa/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(437) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(439), "https://www.instagram.com/aleksandrmuzheiko/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(439) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(440), "https://www.instagram.com/smolasty/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(441) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(442), "https://www.instagram.com/najmilszypan/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(442) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(444), "https://www.instagram.com/maksym_ziolkowski/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(444) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(445), "https://www.instagram.com/therealmixer/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(446) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(447), "https://www.instagram.com/popo_667/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(447) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(449), "https://www.instagram.com/danny.ferreri/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(449) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(450), "https://www.instagram.com/ojwojtek/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(451) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(452), "https://www.instagram.com/mankowski.borys/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(454), "https://www.instagram.com/koroo97/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(454) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(455), "https://www.instagram.com/krzysztofradzikowski/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(456) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(457), "https://www.instagram.com/fit.lovers/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(457) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(459), "https://www.instagram.com/polishzombiemma/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(459) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(460), "https://www.instagram.com/jaca_muran_muranski_official_/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(461) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(462), "https://www.instagram.com/takefun/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(463) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(464), "https://www.instagram.com/japczanek/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(464) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(465), "https://www.instagram.com/pasutabstra/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(466) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(467), "https://www.instagram.com/thenitrozyniak/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(468) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(469), "https://www.instagram.com/theunboxall/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(469) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(492), "https://www.instagram.com/lala_laluna_official/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(493) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(494), "https://www.instagram.com/wiktoriajaroniewskablog/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(495) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(496), "https://www.instagram.com/ajthepolishamerican/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(496) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(498), "https://www.instagram.com/fagataaa/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(498) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(499), "https://www.instagram.com/monika.kociolek/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(500) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(501), "https://www.instagram.com/xayoo777/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(502) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(503), "https://www.instagram.com/gimperowski/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(503) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(505), "https://www.instagram.com/trombabomba/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(505) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(507), "https://www.instagram.com/warjatradek/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(508) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(509), "https://www.instagram.com/xpatlyk/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(509) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(511), "https://www.instagram.com/neffati.jamil/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(511) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(512), "https://www.instagram.com/iamneffatijamel/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(513) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(514), "https://www.instagram.com/franio00/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(515) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(516), "https://www.instagram.com/paramaxil_/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(516) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(518), "https://www.instagram.com/mariuszsarius/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(518) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(519), "https://www.instagram.com/konopskyy_/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(520) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(521), "https://www.instagram.com/natan.marcon/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(521) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(523), "https://www.instagram.com/wiejskikoks/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(523) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(524), "https://www.instagram.com/mrdzinold/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(525) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(526), null, new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(526) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(528), "https://www.instagram.com/bandura_cartel/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(528) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(530), "https://www.instagram.com/xsheeya/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(530) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(531), "https://www.instagram.com/robert_karas_teamkaras/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(532) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(533), "https://www.instagram.com/czarek_/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(533) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(535), "https://www.instagram.com/wactoja/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(535) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(536), "https://www.instagram.com/sebastian.fabijanski.official/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(537) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(538), "https://www.instagram.com/kamil.laszczyk/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(538) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(540), "https://www.instagram.com/pawel.jozwiak_official/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(540) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(541), "https://www.instagram.com/mateusz_spysinski/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(542) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(543), "https://www.instagram.com/llleasy_/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(544) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(545), "https://www.instagram.com/cruelllademon/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(545) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(547), "https://www.instagram.com/michal_wampir_pasternak_/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(547) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(548), "https://www.instagram.com/tomek_zadyma/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(549) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(550), "https://www.instagram.com/ewabrodnicka_/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(550) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(552), "https://www.instagram.com/szyszka.team/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(552) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(553), "https://www.instagram.com/norbert.daszkiewicz/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(554) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(555), "https://www.instagram.com/kubanowaczkiewicz/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(555) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(557), "https://www.instagram.com/albertoloki_93/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(557) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(558), "https://www.instagram.com/caaseybarker/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(559) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(581), "https://www.instagram.com/callummarkie/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(582) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(583), "https://www.instagram.com/mikefox_official/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(584) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(585), "https://www.instagram.com/andrewhenderson/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(585) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(587), "https://www.instagram.com/dappersinstagram/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(587) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(588), null, new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(589) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(590), "https://www.instagram.com/mrallylaw/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(591) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(592), null, new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(592) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(594), "https://www.instagram.com/ashleymarie/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(594) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(595), "https://www.instagram.com/georgialouiseharrison/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(596) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(597), "https://www.instagram.com/jmx/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(599), "https://www.instagram.com/samgowland/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(599) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(600), "https://www.instagram.com/marty_gshore/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(601) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(602), "https://www.instagram.com/onenorbi/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(602) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(604), "https://www.instagram.com/blecki_02/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(604) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(606), "https://www.instagram.com/kubatrenuje_/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(606) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(607), "https://www.instagram.com/krissu.toja/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(608) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(609), "https://www.instagram.com/simply_bary/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(609) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(611), "https://www.instagram.com/kalbartoja/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(611) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(612), "https://www.instagram.com/zakrzew_wk/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(613) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(614), "https://www.instagram.com/bercik2000/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(614) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(616), "https://www.instagram.com/taksinozrt/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(616) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(617), "https://www.instagram.com/wladek_jestem/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(618) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(619), "https://www.instagram.com/_adix6_/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(619) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(621), "https://www.instagram.com/pavlloo/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(621) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(623), "https://www.instagram.com/edzioo/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(623) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(624), "https://www.instagram.com/olga_salacka_/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(625) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(626), "https://www.instagram.com/dominik_loveneverlies/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(626) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(628), "https://www.instagram.com/piotrswierczewski7/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(628) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(629), "https://www.instagram.com/josefbratan/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(630) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(631), "https://www.instagram.com/rogeiro20/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(631) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(633), "https://www.instagram.com/endifit/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(633) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(634), "https://www.instagram.com/xmandzio/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(635) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(636), "https://www.instagram.com/thekaroleq95", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(636) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(638), "https://www.instagram.com/piotr.lisek.pv/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(638) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(639), "https://www.instagram.com/brylantynka/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(640) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(641), "https://www.instagram.com/zadzior_freak_fighter/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(641) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(643), "https://www.instagram.com/megaostry/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(643) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(644), "https://www.instagram.com/igakozinska/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(645) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(646), "https://www.instagram.com/weronika.malinowskaa/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(647) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(648), "https://www.instagram.com/bartfaiadam7/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(648) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(650), "https://www.instagram.com/gr3gor_g3/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(650) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(651), "https://www.instagram.com/kubamaslanka_/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(652) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(653), "https://www.instagram.com/navvvia/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(653) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(655), "https://www.instagram.com/disstream/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(655) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Created", "InstagramUrl", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(656), "https://www.instagram.com/maciej.sulecki/", new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(657) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(956), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(956) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(960), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(960) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(962), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(962) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(963), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(964) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(965), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(965) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(967), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(967) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(968), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(969) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(970), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(970) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(971), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(972) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(973), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(974) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(975), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(975) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(976), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(977) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(978), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(978) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(979), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(979) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(980), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(981) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(982), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(982) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(983), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(983) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(985), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(986) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(987), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(987) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(988), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(988) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(989), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(990) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(991), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(991) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(992), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(993) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(994), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(994) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(995), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(995) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(996), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(997) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(998), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(998) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(999), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1000) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1001), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1001) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1002), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1003) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1004), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1004) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1005), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1006) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1007), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1007) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1009), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1009) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1010), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1011) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1012), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1012) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1013), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1013) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1014), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1015) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1016), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1016) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1017), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1018) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1019), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1019) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1020), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1020) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1021), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1022) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1023), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1023) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1024), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1025) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1026), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1026) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1027), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1028) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1029), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1029) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1030), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1030) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1031), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1032) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1033), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1033) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1034), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1035) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1036), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1036) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1037), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1037) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1039), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1039) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1040), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1040) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1081), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1082) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1083), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1083) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1084), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1085) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1086), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1086) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1087), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1088) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1089), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1089) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1090), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1090) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1092), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1092) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1093), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1093) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1095), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1096) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1097), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1097) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1098), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1099) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1100), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1100) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1101), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1102) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1103), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1103) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1104), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1104) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1105), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1106) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1107), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1107) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1108), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1109) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1110), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1110) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1111), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1112) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1113), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1113) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1114), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1115) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1116), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1116) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1117), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1117) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1118), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1119) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1120), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1120) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1121), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1122) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1123), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1123) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1124), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1125) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1126), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1126) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1127), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1127) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1129), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1129) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1130), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1130) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1131), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1132) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1133), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1133) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1134), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1134) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1135), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1136) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1137), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1137) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1138), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1139) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1140), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1140) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1141), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1141) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1143), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1143) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1144), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1144) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1145), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1146) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1147), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1147) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1148), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1148) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1149), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1150) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1151), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1151) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1152), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1153) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1154), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1154) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1155), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1156) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1157), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1157) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1158), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1158) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1160), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1160) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1161), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1161) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1162), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1163) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1164), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1164) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1165), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1166) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1167), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1167) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1168), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1168) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1170), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1170) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1171), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1171) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1172), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1173) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1174), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1174) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1175), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1176) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1177), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1177) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1178), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1178) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1179), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1180) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1211), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1212) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1213), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1213) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1214), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1215) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1216), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1216) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1219), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1219) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1220), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1221) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1222), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1222) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1223), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1224) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1225), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1225) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1226), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1227) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1228), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1228) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1229), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1229) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1231), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1231) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1232), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1232) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1233), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1234) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1235), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1235) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1236), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1237) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1238), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1238) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1239), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1239) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1241), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1241) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1242), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1242) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1243), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1244) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1245), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1245) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1246), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1247) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1248), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1248) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1249), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1250) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1251), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1251) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1252), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1252) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1253), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1254) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1255), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1255) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1256), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1257) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1258), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1258) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1260), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1260) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1261), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1261) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1263), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1263) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1264), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1264) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1265), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1266) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1267), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1267) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1268), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1269) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1270), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1270) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1271), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1272) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1273), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1273) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1274), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1274) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1276), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1276) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1277), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1277) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1278), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1279) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1280), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1280) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1281), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1281) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1282), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1283) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1284), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1284) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1285), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1286) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1287), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1287) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1288), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1288) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1289), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1290) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1291), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1291) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1292), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1293) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1294), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1294) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1295), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1295) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1318), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1319) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1320), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1320) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1321), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1322) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1323), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1324), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1325) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1326), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1326) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1327), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1327) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1328), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1329) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1330), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1330) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1331), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1332) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1333), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1333) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1334), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1335) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1336), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1336) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1337), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1337) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1338), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1339) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1340), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1340) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1341), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1342) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1343), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1343) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1344), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1345) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1346), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1346) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1347), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1347) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1348), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1349) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1350), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1350) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1351), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1351) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1352), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1353) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1354), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1354) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1355), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1356) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1357), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1357) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1358), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1358) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1359), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1361), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1361) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1362), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1363) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1364), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1364) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1365), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1365) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1366), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1367) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1368), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1368) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1369), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1369) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1371), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1371) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1372), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1372) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1373), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1374) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1375), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1375) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1376), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1376) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1377), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1378) });

            migrationBuilder.UpdateData(
                table: "MyDictionaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(17), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(20) });

            migrationBuilder.UpdateData(
                table: "MyDictionaries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(24), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(24) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(94), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(94) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(97), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(97) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(99), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(100) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(101), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(102) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(103), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(103) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(105), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(106) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(107), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(108) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(109), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(109) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(110), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(111) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(113), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(113) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(139), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(140) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(142), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(142) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(143), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(144) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(145), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(145) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(146), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(147) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(148), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(148) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(150), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(150) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(152), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(153) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(154), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(155) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(157), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(157) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(158), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(159) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(160), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(160) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(161), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(162) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1538), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1538) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1543), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1543) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1544), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1545) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1546), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1546) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1547), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1548) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1550), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1550) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1551), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1552) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1553), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1553) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1554), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1555) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1556), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1557) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1558), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1558) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1559), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1560) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1561), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1561) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1562), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1563) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1564), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1564) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1565), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1566) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1567), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1567) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1569), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1569) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1570), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1571) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1572), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1572) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1574), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1574) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1575), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1575) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1577), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1577) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1578), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1578) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1580), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1580) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1581), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1582) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1583), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1583) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1584), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1585) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1586), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1586) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1587), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1588) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1589), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1589) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1590), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1591) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1592), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1592) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1594), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1594) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1595), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1596) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1597), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1597) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1599), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1599) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1600), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1600) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1602), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1602) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1603), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1603) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1604), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1605) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1606), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1606) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1607), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1608) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1609), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1609) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1610), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1611) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1612), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1612) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1613), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1614) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1638), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1639) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1640), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1640) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1642), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1642) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1643), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1644) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1645), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1645) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1646), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1647) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1648), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1648) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1649), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1650) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1651), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1651) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1652), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1653) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1654), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1654) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1655), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1656) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1657), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1657) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1659), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1659) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1660), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1661) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1662), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1662) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1663), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1664) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1665), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1667), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1667) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1669), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1669) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1670), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1670) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1672), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1672) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1673), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1673) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1675), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1675) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1676), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1676) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1678), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1678) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1679), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1679) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1681), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1681) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1682), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1682) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1684), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1684) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1685), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1685) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1687), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1687) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1688), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1688) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1689), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1690) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1691), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1691) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1693), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1693) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1694), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1695) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1696), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1696) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1697), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1698) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1699), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1699) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1700), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1700) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1702), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1702) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1703), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1704) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1705), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1705) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1706), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1707) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1708), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1708) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1709), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1710) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1711), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1711) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1712), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1713) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1714), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1714) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1715), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1716) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1717), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1717) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1740), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1740) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1742), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1742) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1743), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1744) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1745), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1745) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1746), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1747) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1748), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1748) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1749), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1750) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1751), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1751) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1752), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1753) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1754), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1754) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1755), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1756) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1757), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1757) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1758), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1759) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1760), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1760) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1761), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1762) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1763), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1763) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1764), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1765) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1766), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1766) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1767), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1767) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1769), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1769) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1770), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1770) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1772), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1772) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1773), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1773) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1774), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1775) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1776), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1776) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1777), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1778) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1779), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1779) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1780), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1781) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1782), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1782) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1783), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1784) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1786), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1786) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1787), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1788) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1789), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1789) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1790), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1791) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1792), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1792) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1793), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1794) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1795), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1795) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1796), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1797) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1798), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1798) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1799), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1800) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1801), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1801) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1802), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1803) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1804), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1804) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1805), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1806) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1807), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1807) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1829), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1830) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1831), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1832) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1833), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1833) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1834), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1834) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1836), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1836) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1837), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1837) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1839), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1839) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1840), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1840) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1841), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1842) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1843), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1843) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1845), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1845) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1846), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1846) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1848), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1848) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1849), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1849) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1851), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1851) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1852), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1852) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1853), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1854) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1855), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1855) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1856), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1857) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1858), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1858) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1859), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1860) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1861), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1861) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1862), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1863) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1864), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1864) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1865), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1866) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1867), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1867) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1868), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1869) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1870), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1870) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1871), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1872) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1873), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1873) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1874), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1875) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1876), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1876) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1877), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1878) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1879), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1879) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1880), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1881) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1882), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1882) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1883), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1884) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1885), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1885) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1886), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1887) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1888), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1888) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1889), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1890) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1891), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1891) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1892), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1892) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1894), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1894) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1895), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1896) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1897), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1897) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1898), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1899) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1900), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1900) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1901), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1902) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1903), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1903) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1904), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1905) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1906), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1906) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1907), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1908) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1909), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1909) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1910), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1911) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1912), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1912) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1913), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1913) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1915), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1915) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1916), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1916) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1917), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1918) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1919), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1919) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1934), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1934) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1936), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1936) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1937), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1937) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1939), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1939) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1940), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1940) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1942), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1942) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1943), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1943) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1945), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1945) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1946), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1946) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1947), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1948) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1949), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1949) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1951), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1951) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1952), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1952) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1953), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1954) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1955), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1955) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1957), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1958), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1958) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1960), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1960) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1961), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1961) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1963), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1963) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1964), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1964) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1965), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1966) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1967), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1967) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1968), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1969) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1970), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1970) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1971), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1972) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1973), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1974) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1975), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1975) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1976), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1977) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1978), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1978) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1979), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1981), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1981) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1982), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1983) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1984), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1984) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1985), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1986) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1987), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1987) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1988), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1989) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1990), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1990) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1991), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1992) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1993), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1993) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1994), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1994) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1996), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1996) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1997), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1997) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1999), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(1999) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2000), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2000) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2002), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2002) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2003), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2004) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2005), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2005) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2006), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2007) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2008), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2008) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2009), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2009) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2011), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2011) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2064), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2065) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2066), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2067), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2068) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2069), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2069) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2070), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2070) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2072), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2072) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2073), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2073) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2075), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2075) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2076), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2076) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2078), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2078) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2079), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2079) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2081), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2081) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2082), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2082) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2083), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2084) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2085), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2085) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2086), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2087) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2088), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2088) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2089), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2090) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2091), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2091) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2092), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2093) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2094), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2094) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2095), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2096) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2097), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2097) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2098), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2099) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2100), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2100) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2101), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2102) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2103), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2103) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2104), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2105) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2106), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2106) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2107), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2108) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2109), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2109) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2110), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2111) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2112), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2112) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2113), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2113) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2115), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2115) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2116), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2116) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2152), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2152) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2154), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2154) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2155), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2156) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2157), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2157) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2158), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2159) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2160), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2160) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2161), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2162) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2163), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2163) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2164), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2165) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2166), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2167) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2168), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2168) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2169), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2169) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2171), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2171) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2172), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2172) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2174), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2174) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2175), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2175) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2176), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2177) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2178), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2178) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2179), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2180) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2181), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2181) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2182), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2183) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2184), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2184) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2185), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2186) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2187), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2187) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2188), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2189) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2190), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2190) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2191), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2192) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2193), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2193) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2194), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2195) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2196), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2196) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2197), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2198) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2199), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2199) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2200), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2201) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2202), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2202) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2203), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2203) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2205), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2205) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2206), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2206) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2208), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2208) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2209), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2209) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2211), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2211) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2212), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2212) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2214), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2214) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2215), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2215) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2217), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2217) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2218), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2218) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2220), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2220) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2221), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2221) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2222), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2223) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2224), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2224) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2225), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2226) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2227), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2227) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2228), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2229) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2230), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2230) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2231), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2232) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2233), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2233) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2234), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2235) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2236), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2236) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2237), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2238) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2239), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2239) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2240), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2241) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2264), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2265) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2266), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2267) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2268), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2268) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2269), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2270) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2271), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2271) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2272), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2273) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2274), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2274) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2275), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2276) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2277), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2277) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2278), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2279) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2280), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2280) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2281), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2282) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2283), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2283) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2284), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2285) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2286), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2286) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2287), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2288) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2289), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2289) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2290), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2291) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2292), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2292) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2293), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2293) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2295), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2295) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2296), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2296) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2298), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2298) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2299), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2299) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2301), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2301) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2302), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2302) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2303), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2304) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2305), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2305) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2306), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2307) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2308), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2308) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2309), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2310) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2311), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2311) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2312), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2313) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2314), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2314) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2315), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2316) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2317), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2317) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2318), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2319) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2320), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2320) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2321), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2322) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2323), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2323) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2324), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2325) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2326), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2326) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2327), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2328) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2329), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2329) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2330), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2331) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2332), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2332) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2333), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2334) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2335), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2335) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2336), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2336) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2338), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2338) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2339), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2339) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2341), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2341) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2342), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2342) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2343), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2344) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2345), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2345) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2346), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2347) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2348), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2348) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2349), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2350) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2351), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2351) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2352), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2353) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2354), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2354) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2377), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2378) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2379), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2379) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2381), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2381) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2382), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2382) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2383), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2384) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2385), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2385) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2386), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2387) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2388), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2388) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2389), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2390) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2391), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2391) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2392), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2393) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2394), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2394) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2395), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2396) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2397), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2397) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2398), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2399) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2400), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2401) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2402), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2402) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2403), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2403) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2405), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2405) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2406), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2406) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2408), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2408) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2409), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2410) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2411), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2411) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2412), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2412) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2414), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2414) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2415), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2416) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2417), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2417) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2418), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2418) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2420), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2420) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2421), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2421) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2423), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2423) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2424), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2425) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2426), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2426) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2427), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2428) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2429), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2429) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2430), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2430) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2432), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2432) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2433), new DateTime(2023, 12, 15, 16, 17, 44, 428, DateTimeKind.Utc).AddTicks(2433) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InstagramUrl",
                table: "Fighters");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8539), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8539) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8542), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8543) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8545), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8545) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8547), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8547) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8549), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8550) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8553), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8553) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8555), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8556) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8557), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8558) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8559), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8560) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8562), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8562) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8564), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8564) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8566), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8566) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8568), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8568) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8570), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8570) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8572), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8572) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8574), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8574) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8601), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8602) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8604), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8604) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8606), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8606) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8608), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8608) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8610), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8610) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8612), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8612) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8614), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8614) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8616), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8616) });

            migrationBuilder.UpdateData(
                table: "Federations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8503), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8504) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7896), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7897) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7903), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7904) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7905), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7906) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7907), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7907) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7909), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7909) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7911), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7912) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7913), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7913) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7915), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7915) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7916), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7917) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7919), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7919) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7920), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7955), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7955) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7957), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7957) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7958), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7959) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7960), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7960) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7962), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7962) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7963), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7963) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7965), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7966) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7967), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7967) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7969), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7969) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7971), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7971) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7972), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7973) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7974), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7974) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7976), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7976) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7977), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7978) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7979), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7979) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7980), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7981) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7982), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7982) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7984), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7984) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7985), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7986) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7987), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7987) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7989), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7989) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7990), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7991) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7993), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7993) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7994), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7995) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7996), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7996) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7997), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7998) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7999), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7999) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8001), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8001) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8002), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8003) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8004), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8004) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8006), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8006) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8007), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8007) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8009), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8009) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8010), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8011) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8012), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8012) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8014), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8014) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8015), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8016) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8017), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8017) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8018), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8019) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8020), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8020) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8022), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8022) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8023), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8024) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8025), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8025) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8026), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8027) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8028), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8028) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8030), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8030) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8031), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8032) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8033), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8034) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8035), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8035) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8067), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8067) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8069), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8069) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8071), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8071) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8072), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8073) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8074), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8074) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8076), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8077) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8078), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8078) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8080), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8080) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8081), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8082) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8083), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8083) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8085), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8085) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8086), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8086) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8088), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8088) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8089), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8090) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8091), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8091) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8093), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8093) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8094), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8095) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8096), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8096) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8097), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8098) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8099), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8099) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8101), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8101) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8102), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8103) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8104), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8104) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8106), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8106) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8107), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8108) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8109), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8109) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8111), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8111) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8112), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8113) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8114), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8114) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8115), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8116) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8117), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8117) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8119), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8119) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8120), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8121) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8122), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8122) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8123), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8124) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8125), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8125) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8127), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8127) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8128), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8129) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8130), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8130) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8131), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8132) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8133), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8133) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8135), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8135) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8137), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8137) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8138), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8139) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8140), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8140) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8141), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8142) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8143), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8143) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8169), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8169) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8171), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8171) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8172), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8173) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8174), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8174) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8176), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8176) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8177), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8178) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8179), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8179) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8180), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8181) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8182), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8183) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8184), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8184) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8185), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8186) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8187), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8187) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8189), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8189) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8190), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8191) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8192), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8192) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8194), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8194) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8195), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8195) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8197), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8197) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8199), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8199) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8200), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8200) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8202), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8202) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8203), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8204) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8206), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8206) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8207), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8208) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8209), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8209) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8211), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8211) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8212), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8213) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8214), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8214) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8215), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8216) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8217), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8217) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8219), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8219) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8220), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8221) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8222), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8222) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8223), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8224) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8225), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8225) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8227), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8227) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8228), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8229) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8230), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8230) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8231), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8232) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8233), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8233) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8259), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8259) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8260), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8261) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8262), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8263) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8264), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8264) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8265), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8266) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8267), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8267) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8269), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8269) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8270), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8271) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8272), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8272) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8273), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8274) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8275), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8275) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8277), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8277) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8278), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8279) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8280), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8280) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8281), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8282) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8283), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8283) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8285), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8285) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8286), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8287) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8288), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8288) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8290), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8290) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8291), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8292) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8293), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8293) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8294), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8295) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8296), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8297) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8298), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8298) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8299), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8300) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8301), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8301) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8303), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8303) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8304), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8305) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8306), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8306) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8307), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8308) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8309), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8309) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8311), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8311) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8312), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8313) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8314), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8315), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8316) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8317), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8317) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8319), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8319) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8320), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8321) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8322), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8322) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8324), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8324) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8325), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8326) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8327), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8328), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8329) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8330), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8332), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8332) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8333), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8334) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8335), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8335) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8336), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8337) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8338), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8338) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8340), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8340) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8341), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8342) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8343), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8343) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8345), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8345) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8369), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8370) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8371), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8371) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8373), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8373) });

            migrationBuilder.UpdateData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8374), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8375) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8656), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8656) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8659), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8660) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8661), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8662) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8663), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8663) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8664), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8665) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8667), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8667) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8668), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8669) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8670), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8670) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8671), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8672) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8673), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8674) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8675), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8675) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8676), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8676) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8677), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8678) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8679), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8679) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8680), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8681) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8682), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8682) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8683), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8683) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8685), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8686) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8687), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8687) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8688), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8688) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8690), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8690) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8691), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8691) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8692), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8693) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8694), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8694) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8695), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8695) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8696), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8697) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8698), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8698) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8699), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8700) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8701), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8701) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8702), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8703) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8704), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8704) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8705), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8706) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8707), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8707) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8709), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8709) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8711), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8711) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8712), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8712) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8713), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8714) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8715), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8715) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8716), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8717) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8718), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8718) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8719), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8719) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8720), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8721) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8722), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8722) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8723), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8724) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8725), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8725) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8726), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8727) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8728), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8728) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8744), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8745) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8746), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8746) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8747), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8748) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8749), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8749) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8750), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8751) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8752), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8752) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8753), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8753) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8755), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8755) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8756), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8757) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8758), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8758) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8759), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8761), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8761) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8762), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8762) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8764), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8764) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8765), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8765) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8767), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8767) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8768), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8768) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8769), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8772), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8772) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8773), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8774) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8775), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8775) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8776), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8777) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8778), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8778) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8779), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8780) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8781), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8781) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8782), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8782) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8783), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8784) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8785), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8785) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8786), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8787) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8788), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8788) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8789), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8791), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8791) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8792), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8793) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8794), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8794) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8795), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8796) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8797), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8797) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8798), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8798) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8799), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8800) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8801), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8801) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8802), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8803) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8804), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8804) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8805), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8806) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8807), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8807) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8808), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8809) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8810), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8810) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8811), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8811) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8812), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8813) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8814), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8814) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8815), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8816) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8817), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8817) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8818), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8819) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8820), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8820) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8821), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8822) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8823), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8823) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8824), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8824) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8825), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8826) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8827), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8827) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8828), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8829) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8830), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8830) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8831), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8831) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8833), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8833) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8834), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8834) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8835), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8836) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8837), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8837) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8838), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8839) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8840), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8840) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8878), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8879) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8880), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8881), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8882) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8883), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8883) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8884), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8885) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8886), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8886) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8887), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8888) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8889), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8889) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8890), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8892), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8892) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8893), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8893) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8894), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8895) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8896), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8896) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8897), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8897) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8899), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8899) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8900), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8903), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8903) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8904), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8905) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8906), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8906) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8907), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8907) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8908), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8909) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8910), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8911), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8912) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8913), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8913) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8914), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8915) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8916), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8916) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8917), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8917) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8919), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8919) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8920), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8921) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8922), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8922) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8923), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8923) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8925), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8925) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8926), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8926) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8927), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8928) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8929), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8929) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8930), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8931) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8932), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8932) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8933), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8934) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8935), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8935) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8936), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8936) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8937), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8938) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8939), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8939) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8940), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8941) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8942), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8942) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8943), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8944) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8945), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8945) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8946), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8946) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8947), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8948) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8949), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8949) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8950), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8951) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8952), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8952) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8953), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8954) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8955), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8956), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8957) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8958), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8958) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8959), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8961), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8961) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8962), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8962) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8963), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(8964) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9164), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9164) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9166), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9166) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9167), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9168) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9169), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9169) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9170), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9171) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9172), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9172) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9173), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9173) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9174), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9175) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9176), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9176) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9177), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9178) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9179), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9179) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9180), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9180) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9182), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9182) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9183), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9183) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9184), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9185) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9186), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9186) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9187), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9188) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9189), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9189) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9190), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9191), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9192) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9193), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9193) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9194), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9195) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9196), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9196) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9197), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9197) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9198), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9199) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9200), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9200) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9201), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9202) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9203), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9203) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9204), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9205) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9206), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9206) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9207), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9207) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9208), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9209) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9210), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9210) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9211), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9212) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9213), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9213) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9214), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9215) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9216), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9216) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9217), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9217) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9218), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9219) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9220), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9220) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9221), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9222) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9223), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9223) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9224), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9225) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9226), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9226) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9228), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9228) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9229), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9229) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9230), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9231) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9232), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9232) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9233), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9234) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9235), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9235) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9236), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9237) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9238), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9238) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9239), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9239) });

            migrationBuilder.UpdateData(
                table: "Fights",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9240), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9241) });

            migrationBuilder.UpdateData(
                table: "MyDictionaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7734), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7737) });

            migrationBuilder.UpdateData(
                table: "MyDictionaries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7743), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7744) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7807), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7807) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7811), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7812) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7814), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7815) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7816), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7817) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7818), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7818) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7822), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7824), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7824) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7826), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7826) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7827), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7828) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7829), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7830) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7831), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7831) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7833), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7833) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7834), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7835) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7836), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7836) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7837), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7838) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7839), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7839) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7841), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7841) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7843), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7843) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7845), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7845) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7846), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7847) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7848), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7848) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7850), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7850) });

            migrationBuilder.UpdateData(
                table: "MyDictionaryItems",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7851), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(7851) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9402), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9403) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9406), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9406) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9408), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9408) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9409), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9410) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9411), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9411) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9413), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9414) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9415), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9415) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9416), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9417) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9418), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9418) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9420), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9420) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9422), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9422) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9423), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9423) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9425), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9425) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9426), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9427) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9428), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9428) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9429), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9430) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9431), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9431) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9433), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9434) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9435), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9435) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9436), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9437) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9438), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9438) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9439), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9440) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9441), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9441) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9442), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9443) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9444), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9444) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9446), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9446) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9447), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9448) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9449), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9449) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9450), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9451) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9452), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9452) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9453), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9454) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9455), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9455) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9456), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9457) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9458), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9459) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9460), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9461) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9462), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9462) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9463), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9464) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9465), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9465) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9491), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9492) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9493), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9493) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9495), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9495) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9496), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9497) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9498), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9498) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9499), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9500) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9501), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9501) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9502), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9503) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9504), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9504) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9506), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9506) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9507), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9508) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9509), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9509) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9510), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9511) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9512), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9512) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9513), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9514) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9515), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9515) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9516), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9517) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9518), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9518) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9519), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9520) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9521), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9521) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9522), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9523) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9524), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9524) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9525), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9526) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9527), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9527) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9529), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9529) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9530), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9531) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9532), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9532) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9534), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9535) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9536), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9536) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9537), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9538) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9539), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9539) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9540), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9541) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9542), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9542) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9543), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9544) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9545), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9545) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9547), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9547) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9548), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9550) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9551), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9551) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9552), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9553) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9554), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9554) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9556), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9556) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9557), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9558) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9559), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9559) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9560), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9561) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9562), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9562) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9563), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9564) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9565), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9565) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9566), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9567) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9568), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9568) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9570), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9570) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9571), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9572) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9573), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9573) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9574), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9575) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9600), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9600) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9601), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9602) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9603), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9604) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9605), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9605) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9606), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9607) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9608), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9608) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9610), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9610) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9611), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9611) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9613), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9613) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9614), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9614) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9616), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9616) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9617), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9617) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9619), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9619) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9620), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9620) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9622), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9622) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9623), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9623) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9625), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9625) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9626), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9626) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9628), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9628) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9629), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9630) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9631), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9631) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9632), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9633) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9634), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9634) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9636), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9636) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9637), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9637) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9639), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9639) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9640), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9642), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9642) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9643), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9644) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9645), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9645) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9646), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9647) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9648), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9648) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9649), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9650) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9651), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9651) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9652), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9653) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9654), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9654) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9655), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9656) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9657), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9657) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9660), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9660) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9661), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9662) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9663), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9663) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9664), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9665) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9666), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9666) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9667), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9668) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9669), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9669) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9698), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9698) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9699), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9699) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9701), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9701) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9702), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9703) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9704), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9704) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9705), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9706) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9707), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9707) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9708), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9709) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9710), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9710) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9711), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9712) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9713), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9713) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9715), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9715) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9716), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9716) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9718), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9718) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9720), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9720) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9721), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9721) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9723), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9723) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9724), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9724) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9726), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9726) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9727), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9728) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9729), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9729) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9730), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9731) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9732), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9732) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9733), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9734) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9735), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9736) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9737), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9737) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9739), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9739) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9740), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9740) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9742), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9742) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9743), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9743) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9745), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9745) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9746), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9747) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9748), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9748) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9749), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9750) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9751), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9751) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9752), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9753) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9754), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9754) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9755), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9756) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9757), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9757) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9759), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9759) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9760), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9762), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9762) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9763), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9764) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9765), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9765) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9766), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9767) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9768), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9768) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9769), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9770) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9771), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9771) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9772), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9773) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9774), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9774) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9775), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9776) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9777), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9777) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9778), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9779) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9780), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9781), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9782) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9783), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9783) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9784), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9785) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9786), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9786) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9787), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9788) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9789), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9790) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9815), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9815) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9817), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9817) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9818), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9818) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9820), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9820) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9821), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9822) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9823), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9823) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9825), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9825) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9826), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9827) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9828), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9828) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9829), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9830) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9831), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9831) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9832), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9833) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9834), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9834) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9835), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9836) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9837), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9837) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9838), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9839) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9840), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9840) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9841), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9842) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9843), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9843) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9845), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9845) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9846), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9846) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9848), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9848) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9849), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9849) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9851), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9851) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9852), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9853) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9854), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9854) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9855), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9856) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9857), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9857) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9859), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9859) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9860), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9860) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9862), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9862) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9863), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9863) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9865), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9865) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9866), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9867) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9868), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9868) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9869), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9870) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9871), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9871) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9872), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9873) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9874), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9874) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9876), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9876) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9877), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9878) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9879), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9879) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9880), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9881) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9882), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9882) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9884), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9884) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9885), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9886) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9887), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9887) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9888), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9889) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9890), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9890) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9892), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9892) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9893), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9893) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9895), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9895) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9896), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9896) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9898), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9898) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9899), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9900) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9901), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9901) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9902), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9903) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9904), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9904) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9905), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9906) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9907), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9907) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9923), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9923) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9926), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9926) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9927), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9928) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9929), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9930) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9931), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9931) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9932), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9933) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9934), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9935) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9936), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9936) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9937), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9938) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9939), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9939) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9940), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9941) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9942), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9942) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9944), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9944) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9945), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9945) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9947), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9947) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9948), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9948) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9950), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9950) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9951), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9952) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9953), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9953) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9954), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9956), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9956) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9957), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9958) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9959), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9959) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9960), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9961) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9962), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9962) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9963), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9964) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9965), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9965) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9967), new DateTime(2023, 12, 14, 17, 27, 25, 842, DateTimeKind.Utc).AddTicks(9967) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(4), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(4) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(6), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(6) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(8), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(9) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(11), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(11) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(12), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(13) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(14), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(14) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(15), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(16) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(17), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(17) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(18), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(19) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(20), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(20) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(21), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(22) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(23), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(23) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(24), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(25) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(26), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(26) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(28), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(28) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(29), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(30) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(31), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(31) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(32), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(33) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(34), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(34) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(35), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(36) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(37), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(37) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(38), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(39) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(40), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(40) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(41), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(42) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(43), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(43) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(44), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(45) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(46), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(46) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(47), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(48) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(49), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(49) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(51), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(51) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(52), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(52) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(54), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(54) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(55), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(55) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(57), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(57) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(58), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(58) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(60), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(60) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(61), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(61) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(63), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(63) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(64), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(65) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(66), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(66) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(67), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(68) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(69), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(69) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(70), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(71) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(72), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(72) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(73), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(73) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(75), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(75) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(76), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(77) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(78), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(78) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(79), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(80) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(81), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(81) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(82), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(83) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(84), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(84) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(85), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(86) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(87), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(87) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(88), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(89) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(90), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(90) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(92), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(92) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(93), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(94) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(95), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(95) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(96), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(97) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(98), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(98) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(130), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(131) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(132), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(132) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(134), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(134) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(135), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(135) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(137), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(137) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(138), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(139) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(140), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(140) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(141), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(142) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(143), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(143) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(144), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(145) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(146), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(146) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(147), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(148) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(149), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(149) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(150), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(151) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(152), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(152) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(153), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(153) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(155), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(155) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(156), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(156) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(158), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(158) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(159), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(159) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(161), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(161) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(162), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(163) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(164), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(164) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(165), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(166) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(167), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(167) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(168), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(169) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(170), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(170) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(171), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(172) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(173), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(173) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(174), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(175) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(176), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(176) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(177), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(179), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(179) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(180), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(181) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(182), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(182) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(183), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(184) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(185), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(185) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(186), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(187) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(188), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(188) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(189), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(190) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(191), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(191) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(192), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(193) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(194), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(194) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(195), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(196) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(197), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(197) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(198), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(199) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(200), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(200) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(201), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(202) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(203), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(203) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(204), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(205) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(206), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(206) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(207), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(208) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(209), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(209) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(210), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(211) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(212), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(212) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(213), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(214) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(215), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(215) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(216), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(217) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(218), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(218) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(219), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(220) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(247), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(248) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(249), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(249) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(251), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(252), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(254), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(254) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(255), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(256) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(257), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(257) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(258), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(259) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(260), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(260) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(261), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(262) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(263), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(263) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(264), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(265) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(266), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(266) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(267), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(268) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(269), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(269) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(270), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(271) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(272), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(273) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(274), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(274) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(276), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(276) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(277), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(277) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(279), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(279) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(280), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(280) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(282), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(282) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(283), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(283) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(285), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(285) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(286), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(286) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(288), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(288) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(289), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(290) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(291), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(291) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(292), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(293) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(294), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(294) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(295), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(296) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(297), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(297) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(298), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(299) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(300), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(300) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(301), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(302) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(303), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(303) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(305), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(305) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(306), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(306) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(308), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(308) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(309), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(309) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(311), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(311) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(312), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(312) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(314), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(314) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(315), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(315) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(317), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(317) });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(318), new DateTime(2023, 12, 14, 17, 27, 25, 843, DateTimeKind.Utc).AddTicks(318) });
        }
    }
}
