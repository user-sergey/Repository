using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Storage.Migrations
{
    public partial class V : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "NewsNamespace",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "NewsNamespace");
        }
    }
}
