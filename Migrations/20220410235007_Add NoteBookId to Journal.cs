using Microsoft.EntityFrameworkCore.Migrations;

namespace MyNoteBook.Migrations
{
    public partial class AddNoteBookIdtoJournal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Notebook",
                table: "Notebook");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Notebook");

            migrationBuilder.AddColumn<int>(
                name: "NotebookId",
                table: "Notebook",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "NoteBookId",
                table: "Journal",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Notebook",
                table: "Notebook",
                column: "NotebookId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Notebook",
                table: "Notebook");

            migrationBuilder.DropColumn(
                name: "NotebookId",
                table: "Notebook");

            migrationBuilder.DropColumn(
                name: "NoteBookId",
                table: "Journal");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Notebook",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Notebook",
                table: "Notebook",
                column: "Id");
        }
    }
}
