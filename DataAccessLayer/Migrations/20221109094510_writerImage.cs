using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class writerImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WriterImage",
                table: "Writers");

            migrationBuilder.DropColumn(
                name: "BlogThumbnailImageName",
                table: "Blogs");

            migrationBuilder.AddColumn<string>(
                name: "WriterImageName",
                table: "Writers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WriterImageName",
                table: "Writers");

            migrationBuilder.AddColumn<string>(
                name: "WriterImage",
                table: "Writers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BlogThumbnailImageName",
                table: "Blogs",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
