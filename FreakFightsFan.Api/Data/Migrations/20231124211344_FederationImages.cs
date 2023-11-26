using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FreakFightsFan.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class FederationImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FederationId",
                table: "Images",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Images_FederationId",
                table: "Images",
                column: "FederationId",
                unique: true,
                filter: "[FederationId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Federations_FederationId",
                table: "Images",
                column: "FederationId",
                principalTable: "Federations",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Federations_FederationId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_FederationId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "FederationId",
                table: "Images");
        }
    }
}
