using Microsoft.EntityFrameworkCore.Migrations;

namespace MyNoteBook.Migrations
{
    public partial class changemodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Journal_Mood_Mood",
                table: "Journal");

            migrationBuilder.DropForeignKey(
                name: "FK_Journal_Notebook_Notebook",
                table: "Journal");

            migrationBuilder.DropForeignKey(
                name: "FK_Journal_Weather_Weather",
                table: "Journal");

            migrationBuilder.DropForeignKey(
                name: "FK_PhotoDiary_Template_Template",
                table: "PhotoDiary");

            migrationBuilder.DropIndex(
                name: "IX_PhotoDiary_Template",
                table: "PhotoDiary");

            migrationBuilder.DropIndex(
                name: "IX_Journal_Mood",
                table: "Journal");

            migrationBuilder.DropIndex(
                name: "IX_Journal_Notebook",
                table: "Journal");

            migrationBuilder.DropIndex(
                name: "IX_Journal_Weather",
                table: "Journal");

            migrationBuilder.DropColumn(
                name: "Template",
                table: "PhotoDiary");

            migrationBuilder.DropColumn(
                name: "Mood",
                table: "Journal");

            migrationBuilder.DropColumn(
                name: "Notebook",
                table: "Journal");

            migrationBuilder.DropColumn(
                name: "Weather",
                table: "Journal");

            migrationBuilder.AddColumn<int>(
                name: "TemplateId",
                table: "PhotoDiary",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PhotoDiary_TemplateId",
                table: "PhotoDiary",
                column: "TemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_Journal_MoodId",
                table: "Journal",
                column: "MoodId");

            migrationBuilder.CreateIndex(
                name: "IX_Journal_NotebookId",
                table: "Journal",
                column: "NotebookId");

            migrationBuilder.CreateIndex(
                name: "IX_Journal_WeatherId",
                table: "Journal",
                column: "WeatherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Journal_Mood_MoodId",
                table: "Journal",
                column: "MoodId",
                principalTable: "Mood",
                principalColumn: "MoodId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Journal_Notebook_NotebookId",
                table: "Journal",
                column: "NotebookId",
                principalTable: "Notebook",
                principalColumn: "NotebookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Journal_Weather_WeatherId",
                table: "Journal",
                column: "WeatherId",
                principalTable: "Weather",
                principalColumn: "WeatherId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhotoDiary_Template_TemplateId",
                table: "PhotoDiary",
                column: "TemplateId",
                principalTable: "Template",
                principalColumn: "TemplateId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Journal_Mood_MoodId",
                table: "Journal");

            migrationBuilder.DropForeignKey(
                name: "FK_Journal_Notebook_NotebookId",
                table: "Journal");

            migrationBuilder.DropForeignKey(
                name: "FK_Journal_Weather_WeatherId",
                table: "Journal");

            migrationBuilder.DropForeignKey(
                name: "FK_PhotoDiary_Template_TemplateId",
                table: "PhotoDiary");

            migrationBuilder.DropIndex(
                name: "IX_PhotoDiary_TemplateId",
                table: "PhotoDiary");

            migrationBuilder.DropIndex(
                name: "IX_Journal_MoodId",
                table: "Journal");

            migrationBuilder.DropIndex(
                name: "IX_Journal_NotebookId",
                table: "Journal");

            migrationBuilder.DropIndex(
                name: "IX_Journal_WeatherId",
                table: "Journal");

            migrationBuilder.DropColumn(
                name: "TemplateId",
                table: "PhotoDiary");

            migrationBuilder.AddColumn<int>(
                name: "Template",
                table: "PhotoDiary",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Mood",
                table: "Journal",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Notebook",
                table: "Journal",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Weather",
                table: "Journal",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PhotoDiary_Template",
                table: "PhotoDiary",
                column: "Template");

            migrationBuilder.CreateIndex(
                name: "IX_Journal_Mood",
                table: "Journal",
                column: "Mood");

            migrationBuilder.CreateIndex(
                name: "IX_Journal_Notebook",
                table: "Journal",
                column: "Notebook");

            migrationBuilder.CreateIndex(
                name: "IX_Journal_Weather",
                table: "Journal",
                column: "Weather");

            migrationBuilder.AddForeignKey(
                name: "FK_Journal_Mood_Mood",
                table: "Journal",
                column: "Mood",
                principalTable: "Mood",
                principalColumn: "MoodId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Journal_Notebook_Notebook",
                table: "Journal",
                column: "Notebook",
                principalTable: "Notebook",
                principalColumn: "NotebookId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Journal_Weather_Weather",
                table: "Journal",
                column: "Weather",
                principalTable: "Weather",
                principalColumn: "WeatherId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PhotoDiary_Template_Template",
                table: "PhotoDiary",
                column: "Template",
                principalTable: "Template",
                principalColumn: "TemplateId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
