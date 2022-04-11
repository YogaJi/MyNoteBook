using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyNoteBook.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mood",
                columns: table => new
                {
                    MoodId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MoodPic = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mood", x => x.MoodId);
                });

            migrationBuilder.CreateTable(
                name: "Template",
                columns: table => new
                {
                    TemplateId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Template", x => x.TemplateId);
                });

            migrationBuilder.CreateTable(
                name: "Weather",
                columns: table => new
                {
                    WeatherId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WeatherPic = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weather", x => x.WeatherId);
                });

            migrationBuilder.CreateTable(
                name: "PhotoDiary",
                columns: table => new
                {
                    PhotoDiaryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    FirstContent = table.Column<string>(nullable: true),
                    secondContent = table.Column<string>(nullable: true),
                    Template = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhotoDiary", x => x.PhotoDiaryId);
                    table.ForeignKey(
                        name: "FK_PhotoDiary_Template_Template",
                        column: x => x.Template,
                        principalTable: "Template",
                        principalColumn: "TemplateId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Journal",
                columns: table => new
                {
                    JournalId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Weather = table.Column<int>(nullable: true),
                    Mood = table.Column<int>(nullable: true),
                    Content = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Journal", x => x.JournalId);
                    table.ForeignKey(
                        name: "FK_Journal_Mood_Mood",
                        column: x => x.Mood,
                        principalTable: "Mood",
                        principalColumn: "MoodId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Journal_Weather_Weather",
                        column: x => x.Weather,
                        principalTable: "Weather",
                        principalColumn: "WeatherId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Notebook",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Journal = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notebook", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notebook_Journal_Journal",
                        column: x => x.Journal,
                        principalTable: "Journal",
                        principalColumn: "JournalId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Journal_Mood",
                table: "Journal",
                column: "Mood");

            migrationBuilder.CreateIndex(
                name: "IX_Journal_Weather",
                table: "Journal",
                column: "Weather");

            migrationBuilder.CreateIndex(
                name: "IX_Notebook_Journal",
                table: "Notebook",
                column: "Journal");

            migrationBuilder.CreateIndex(
                name: "IX_PhotoDiary_Template",
                table: "PhotoDiary",
                column: "Template");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notebook");

            migrationBuilder.DropTable(
                name: "PhotoDiary");

            migrationBuilder.DropTable(
                name: "Journal");

            migrationBuilder.DropTable(
                name: "Template");

            migrationBuilder.DropTable(
                name: "Mood");

            migrationBuilder.DropTable(
                name: "Weather");
        }
    }
}
