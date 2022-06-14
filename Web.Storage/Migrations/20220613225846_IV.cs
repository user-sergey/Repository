using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Storage.Migrations
{
    public partial class IV : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commentaries_News_newsId",
                table: "Commentaries");

            migrationBuilder.DropForeignKey(
                name: "FK_News_Categories_categoryId",
                table: "News");

            migrationBuilder.DropForeignKey(
                name: "FK_News_Countries_countryId",
                table: "News");

            migrationBuilder.DropForeignKey(
                name: "FK_News_Publishers_publisherId",
                table: "News");

            migrationBuilder.DropForeignKey(
                name: "FK_News_Sources_sourceId",
                table: "News");

            migrationBuilder.DropForeignKey(
                name: "FK_PublisherCountries_Countries_countryId",
                table: "PublisherCountries");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Countries_countryId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_News",
                table: "News");

            migrationBuilder.RenameTable(
                name: "News",
                newName: "NewsNamespace");

            migrationBuilder.RenameIndex(
                name: "IX_News_sourceId",
                table: "NewsNamespace",
                newName: "IX_NewsNamespace_sourceId");

            migrationBuilder.RenameIndex(
                name: "IX_News_publisherId",
                table: "NewsNamespace",
                newName: "IX_NewsNamespace_publisherId");

            migrationBuilder.RenameIndex(
                name: "IX_News_countryId",
                table: "NewsNamespace",
                newName: "IX_NewsNamespace_countryId");

            migrationBuilder.RenameIndex(
                name: "IX_News_categoryId",
                table: "NewsNamespace",
                newName: "IX_NewsNamespace_categoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NewsNamespace",
                table: "NewsNamespace",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Commentaries_NewsNamespace_newsId",
                table: "Commentaries",
                column: "newsId",
                principalTable: "NewsNamespace",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NewsNamespace_Categories_categoryId",
                table: "NewsNamespace",
                column: "categoryId",
                principalTable: "Categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NewsNamespace_NewsNamespace_countryId",
                table: "NewsNamespace",
                column: "countryId",
                principalTable: "NewsNamespace",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NewsNamespace_Publishers_publisherId",
                table: "NewsNamespace",
                column: "publisherId",
                principalTable: "Publishers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NewsNamespace_Sources_sourceId",
                table: "NewsNamespace",
                column: "sourceId",
                principalTable: "Sources",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commentaries_NewsNamespace_newsId",
                table: "Commentaries");

            migrationBuilder.DropForeignKey(
                name: "FK_NewsNamespace_Categories_categoryId",
                table: "NewsNamespace");

            migrationBuilder.DropForeignKey(
                name: "FK_NewsNamespace_NewsNamespace_countryId",
                table: "NewsNamespace");

            migrationBuilder.DropForeignKey(
                name: "FK_NewsNamespace_Publishers_publisherId",
                table: "NewsNamespace");

            migrationBuilder.DropForeignKey(
                name: "FK_NewsNamespace_Sources_sourceId",
                table: "NewsNamespace");

            migrationBuilder.DropForeignKey(
                name: "FK_PublisherCountries_NewsNamespace_countryId",
                table: "PublisherCountries");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_NewsNamespace_countryId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NewsNamespace",
                table: "NewsNamespace");

            migrationBuilder.RenameTable(
                name: "NewsNamespace",
                newName: "News");

            migrationBuilder.RenameIndex(
                name: "IX_NewsNamespace_sourceId",
                table: "News",
                newName: "IX_News_sourceId");

            migrationBuilder.RenameIndex(
                name: "IX_NewsNamespace_publisherId",
                table: "News",
                newName: "IX_News_publisherId");

            migrationBuilder.RenameIndex(
                name: "IX_NewsNamespace_countryId",
                table: "News",
                newName: "IX_News_countryId");

            migrationBuilder.RenameIndex(
                name: "IX_NewsNamespace_categoryId",
                table: "News",
                newName: "IX_News_categoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_News",
                table: "News",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Commentaries_News_newsId",
                table: "Commentaries",
                column: "newsId",
                principalTable: "News",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_News_Categories_categoryId",
                table: "News",
                column: "categoryId",
                principalTable: "Categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_News_Countries_countryId",
                table: "News",
                column: "countryId",
                principalTable: "Countries",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_News_Publishers_publisherId",
                table: "News",
                column: "publisherId",
                principalTable: "Publishers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_News_Sources_sourceId",
                table: "News",
                column: "sourceId",
                principalTable: "Sources",
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
    }
}
