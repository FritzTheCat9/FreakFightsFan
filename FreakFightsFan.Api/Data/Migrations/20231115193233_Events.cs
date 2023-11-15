using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FreakFightsFan.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class Events : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FederationId",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Events_FederationId",
                table: "Events",
                column: "FederationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Federations_FederationId",
                table: "Events",
                column: "FederationId",
                principalTable: "Federations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Federations_FederationId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_FederationId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "FederationId",
                table: "Events");
        }
    }
}
