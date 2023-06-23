using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WatchList.Data.Migrations
{
    public partial class dependencyInjectionsFilmListController : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ModeleVueFilm",
                newName: "IdFilm");

            migrationBuilder.AlterColumn<int>(
                name: "IdMyUser",
                table: "FilmUsers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdFilm",
                table: "ModeleVueFilm",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "IdMyUser",
                table: "FilmUsers",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
