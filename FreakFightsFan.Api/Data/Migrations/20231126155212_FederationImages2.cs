using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FreakFightsFan.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class FederationImages2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Federations_FederationId",
                table: "Images");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Federations_FederationId",
                table: "Images",
                column: "FederationId",
                principalTable: "Federations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Federations_FederationId",
                table: "Images");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Federations_FederationId",
                table: "Images",
                column: "FederationId",
                principalTable: "Federations",
                principalColumn: "Id");
        }
    }
}
