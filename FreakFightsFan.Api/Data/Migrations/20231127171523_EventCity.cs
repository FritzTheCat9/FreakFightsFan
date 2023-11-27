using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FreakFightsFan.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class EventCity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Events",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Events_CityId",
                table: "Events",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_MyDictionaryItems_CityId",
                table: "Events",
                column: "CityId",
                principalTable: "MyDictionaryItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_MyDictionaryItems_CityId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_CityId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Events");
        }
    }
}
