using Microsoft.EntityFrameworkCore.Migrations;

namespace MyNoteBook.Migrations
{
    public partial class ChangeJournalandNoteBookmodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notebook_Journal_Journal",
                table: "Notebook");

            migrationBuilder.DropIndex(
                name: "IX_Notebook_Journal",
                table: "Notebook");

            migrationBuilder.DropColumn(
                name: "Journal",
                table: "Notebook");

            migrationBuilder.AddColumn<string>(
                name: "BackgroundColor",
                table: "Journal",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Notebook",
                table: "Journal",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Journal_Notebook",
                table: "Journal",
                column: "Notebook");

            migrationBuilder.AddForeignKey(
                name: "FK_Journal_Notebook_Notebook",
                table: "Journal",
                column: "Notebook",
                principalTable: "Notebook",
                principalColumn: "NotebookId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Journal_Notebook_Notebook",
                table: "Journal");

            migrationBuilder.DropIndex(
                name: "IX_Journal_Notebook",
                table: "Journal");

            migrationBuilder.DropColumn(
                name: "BackgroundColor",
                table: "Journal");

            migrationBuilder.DropColumn(
                name: "Notebook",
                table: "Journal");

            migrationBuilder.AddColumn<int>(
                name: "Journal",
                table: "Notebook",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Notebook_Journal",
                table: "Notebook",
                column: "Journal");

            migrationBuilder.AddForeignKey(
                name: "FK_Notebook_Journal_Journal",
                table: "Notebook",
                column: "Journal",
                principalTable: "Journal",
                principalColumn: "JournalId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
