using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WellHeader.Migrations
{
    /// <inheritdoc />
    public partial class SeedWell : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Wells",
                columns: new[] { "WellID", "APINumber", "FieldID", "Lat", "Long", "WellName" },
                values: new object[] { 1, "42000011110000", 0, null, null, "My Sample Well #1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Wells",
                keyColumn: "WellID",
                keyValue: 1);
        }
    }
}
