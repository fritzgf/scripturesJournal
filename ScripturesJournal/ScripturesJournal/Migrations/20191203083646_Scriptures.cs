using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ScripturesJournal.Migrations
{
    public partial class Scriptures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Scripture",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 60, nullable: false),
                    Book = table.Column<string>(maxLength: 30, nullable: false),
                    Chapters = table.Column<string>(maxLength: 30, nullable: false),
                    Verses = table.Column<string>(maxLength: 30, nullable: false),
                    Note = table.Column<string>(maxLength: 500, nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scripture", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Scripture");
        }
    }
}
