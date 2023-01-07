using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class addedMovieCommentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "MovieCategory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/06/2023 10:52:57",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/05/2023 13:59:29");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/06/2023 10:52:57",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/05/2023 13:59:29");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Movflix",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/06/2023 10:52:57",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/05/2023 13:59:29");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Comment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Friday, January 6, 2023",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Thursday, January 5, 2023");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "BlogImage",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/06/2023 10:52:57",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/05/2023 13:59:29");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Blog",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Friday, January 6, 2023",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Thursday, January 5, 2023");

            migrationBuilder.CreateTable(
                name: "MovieComment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    By = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Context = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreateDate = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "Friday, January 6, 2023")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieComment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovieComment_Movie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieComment_MovieId",
                table: "MovieComment",
                column: "MovieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieComment");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "MovieCategory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/05/2023 13:59:29",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/06/2023 10:52:57");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/05/2023 13:59:29",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/06/2023 10:52:57");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Movflix",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/05/2023 13:59:29",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/06/2023 10:52:57");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Comment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Thursday, January 5, 2023",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Friday, January 6, 2023");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "BlogImage",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/05/2023 13:59:29",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/06/2023 10:52:57");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Blog",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Thursday, January 5, 2023",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Friday, January 6, 2023");
        }
    }
}
