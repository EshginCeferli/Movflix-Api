using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class addedMovieCategoryTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Movflix",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 13, 19, 2, 37, 614, DateTimeKind.Utc).AddTicks(1613),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 13, 18, 59, 56, 373, DateTimeKind.Utc).AddTicks(8429));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Comment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 13, 19, 2, 37, 622, DateTimeKind.Utc).AddTicks(5679),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 13, 18, 59, 56, 382, DateTimeKind.Utc).AddTicks(7824));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "BlogImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 13, 19, 2, 37, 622, DateTimeKind.Utc).AddTicks(4445),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 13, 18, 59, 56, 382, DateTimeKind.Utc).AddTicks(6930));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Blog",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 13, 19, 2, 37, 619, DateTimeKind.Utc).AddTicks(7579),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 13, 18, 59, 56, 379, DateTimeKind.Utc).AddTicks(5202));

            migrationBuilder.CreateTable(
                name: "MovieCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 12, 13, 19, 2, 37, 626, DateTimeKind.Utc).AddTicks(8386))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Poster = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Length = table.Column<int>(type: "int", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MovieCategoryId = table.Column<int>(type: "int", nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 12, 13, 19, 2, 37, 626, DateTimeKind.Utc).AddTicks(7078))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movie_MovieCategory_MovieCategoryId",
                        column: x => x.MovieCategoryId,
                        principalTable: "MovieCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movie_MovieCategoryId",
                table: "Movie",
                column: "MovieCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie");

            migrationBuilder.DropTable(
                name: "MovieCategory");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Movflix",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 13, 18, 59, 56, 373, DateTimeKind.Utc).AddTicks(8429),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 13, 19, 2, 37, 614, DateTimeKind.Utc).AddTicks(1613));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Comment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 13, 18, 59, 56, 382, DateTimeKind.Utc).AddTicks(7824),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 13, 19, 2, 37, 622, DateTimeKind.Utc).AddTicks(5679));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "BlogImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 13, 18, 59, 56, 382, DateTimeKind.Utc).AddTicks(6930),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 13, 19, 2, 37, 622, DateTimeKind.Utc).AddTicks(4445));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Blog",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 13, 18, 59, 56, 379, DateTimeKind.Utc).AddTicks(5202),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 13, 19, 2, 37, 619, DateTimeKind.Utc).AddTicks(7579));
        }
    }
}
