using Microsoft.EntityFrameworkCore.Migrations;

namespace MyNoteBook.Migrations
{
    public partial class NewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NoteBookId",
                table: "Journal");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NoteBookId",
                table: "Journal",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
