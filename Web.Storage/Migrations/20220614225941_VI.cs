using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Storage.Migrations
{
    public partial class VI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NewsNamespace_NewsNamespace_countryId",
                table: "NewsNamespace");

            migrationBuilder.DropForeignKey(
                name: "FK_PublisherCountries_NewsNamespace_countryId",
                table: "PublisherCountries");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_NewsNamespace_countryId",
                table: "Users");

            migrationBuilder.AddForeignKey(
                name: "FK_NewsNamespace_Countries_countryId",
                table: "NewsNamespace",
                column: "countryId",
                principalTable: "Countries",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PublisherCountries_Countries_countryId",
                table: "PublisherCountries",
                column: "countryId",
                principalTable: "Countries",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Countries_countryId",
                table: "Users",
                column: "countryId",
                principalTable: "Countries",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NewsNamespace_Countries_countryId",
                table: "NewsNamespace");

            migrationBuilder.DropForeignKey(
                name: "FK_PublisherCountries_Countries_countryId",
                table: "PublisherCountries");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Countries_countryId",
                table: "Users");

            migrationBuilder.AddForeignKey(
                name: "FK_NewsNamespace_NewsNamespace_countryId",
                table: "NewsNamespace",
                column: "countryId",
                principalTable: "NewsNamespace",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PublisherCountries_NewsNamespace_countryId",
                table: "PublisherCountries",
                column: "countryId",
                principalTable: "NewsNamespace",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_NewsNamespace_countryId",
                table: "Users",
                column: "countryId",
                principalTable: "NewsNamespace",
                principalColumn: "Id");
        }
    }
}
