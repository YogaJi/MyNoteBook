using Microsoft.EntityFrameworkCore.Migrations;

namespace MyNoteBook.Migrations
{
    public partial class addweatherIdmoodIdandweatherId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MoodId",
                table: "Journal",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NotebookId",
                table: "Journal",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WeatherId",
                table: "Journal",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MoodId",
                table: "Journal");

            migrationBuilder.DropColumn(
                name: "NotebookId",
                table: "Journal");

            migrationBuilder.DropColumn(
                name: "WeatherId",
                table: "Journal");
        }
    }
}
