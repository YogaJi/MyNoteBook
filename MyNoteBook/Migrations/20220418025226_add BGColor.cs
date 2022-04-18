using Microsoft.EntityFrameworkCore.Migrations;

namespace MyNoteBook.Migrations
{
    public partial class addBGColor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BackgroundColor",
                table: "Journal");

            migrationBuilder.AddColumn<int>(
                name: "BGColorBGId",
                table: "Journal",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BGId",
                table: "Journal",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "BGColor",
                columns: table => new
                {
                    BGId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BGString = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BGColor", x => x.BGId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Journal_BGColorBGId",
                table: "Journal",
                column: "BGColorBGId");

            migrationBuilder.AddForeignKey(
                name: "FK_Journal_BGColor_BGColorBGId",
                table: "Journal",
                column: "BGColorBGId",
                principalTable: "BGColor",
                principalColumn: "BGId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Journal_BGColor_BGColorBGId",
                table: "Journal");

            migrationBuilder.DropTable(
                name: "BGColor");

            migrationBuilder.DropIndex(
                name: "IX_Journal_BGColorBGId",
                table: "Journal");

            migrationBuilder.DropColumn(
                name: "BGColorBGId",
                table: "Journal");

            migrationBuilder.DropColumn(
                name: "BGId",
                table: "Journal");

            migrationBuilder.AddColumn<string>(
                name: "BackgroundColor",
                table: "Journal",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
