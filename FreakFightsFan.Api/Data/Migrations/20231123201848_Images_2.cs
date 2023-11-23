using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FreakFightsFan.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class Images_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Data",
                table: "Images");

            migrationBuilder.RenameColumn(
                name: "ContentType",
                table: "Images",
                newName: "Url");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Images",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Images");

            migrationBuilder.RenameColumn(
                name: "Url",
                table: "Images",
                newName: "ContentType");

            migrationBuilder.AddColumn<byte[]>(
                name: "Data",
                table: "Images",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}
