using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class imageAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BlogThumbnailImageName",
                table: "Blogs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BloglImageName",
                table: "Blogs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BlogThumbnailImageName",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "BloglImageName",
                table: "Blogs");
        }
    }
}
