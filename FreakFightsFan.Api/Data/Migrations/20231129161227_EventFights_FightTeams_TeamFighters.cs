using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FreakFightsFan.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class EventFights_FightTeams_TeamFighters : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FightId",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "Fights",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TeamFighters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FighterId = table.Column<int>(type: "int", nullable: false),
                    TeamId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamFighters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeamFighters_Fighters_FighterId",
                        column: x => x.FighterId,
                        principalTable: "Fighters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeamFighters_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Teams_FightId",
                table: "Teams",
                column: "FightId");

            migrationBuilder.CreateIndex(
                name: "IX_Fights_EventId",
                table: "Fights",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamFighters_FighterId",
                table: "TeamFighters",
                column: "FighterId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamFighters_TeamId",
                table: "TeamFighters",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fights_Events_EventId",
                table: "Fights",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Fights_FightId",
                table: "Teams",
                column: "FightId",
                principalTable: "Fights",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fights_Events_EventId",
                table: "Fights");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Fights_FightId",
                table: "Teams");

            migrationBuilder.DropTable(
                name: "TeamFighters");

            migrationBuilder.DropIndex(
                name: "IX_Teams_FightId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Fights_EventId",
                table: "Fights");

            migrationBuilder.DropColumn(
                name: "FightId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "Fights");
        }
    }
}
