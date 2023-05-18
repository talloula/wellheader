using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WellHeader.Migrations
{
    /// <inheritdoc />
    public partial class Wells0519 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Wells",
                columns: table => new
                {
                    WellID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WellName = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    FieldID = table.Column<int>(type: "int", nullable: false),
                    APINumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lat = table.Column<double>(type: "float", nullable: true),
                    Long = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Wells__E955CC1C76D95E60", x => x.WellID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Wells");
        }
    }
}
