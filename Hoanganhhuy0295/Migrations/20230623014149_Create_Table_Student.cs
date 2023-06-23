using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hoanganhhuy0295.Migrations
{
    /// <inheritdoc />
    public partial class Create_Table_Student : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Masinhvien = table.Column<string>(type: "TEXT", nullable: false),
                    Hoten = table.Column<string>(type: "TEXT", nullable: false),
                    Tuoi = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Masinhvien);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
