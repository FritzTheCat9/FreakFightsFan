using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FreakFightsFan.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class FighterImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FighterId",
                table: "Images",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Images_FighterId",
                table: "Images",
                column: "FighterId",
                unique: true,
                filter: "[FighterId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Fighters_FighterId",
                table: "Images",
                column: "FighterId",
                principalTable: "Fighters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Fighters_FighterId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_FighterId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "FighterId",
                table: "Images");
        }
    }
}
