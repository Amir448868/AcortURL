using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcortURL.Migrations
{
    /// <inheritdoc />
    public partial class migration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UrlCorta",
                table: "Urls",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Urls",
                keyColumn: "Id",
                keyValue: 1,
                column: "UrlCorta",
                value: null);

            migrationBuilder.UpdateData(
                table: "Urls",
                keyColumn: "Id",
                keyValue: 2,
                column: "UrlCorta",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UrlCorta",
                table: "Urls");
        }
    }
}
