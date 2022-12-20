using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class addedAnnotations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "MovieCategory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "MovieCategory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 14, 6, 49, 30, 863, DateTimeKind.Utc).AddTicks(9380),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 13, 19, 2, 37, 626, DateTimeKind.Utc).AddTicks(8386));

            migrationBuilder.AlterColumn<string>(
                name: "Poster",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Movie",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 14, 6, 49, 30, 863, DateTimeKind.Utc).AddTicks(8349),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 13, 19, 2, 37, 626, DateTimeKind.Utc).AddTicks(7078));

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<bool>(
                name: "SoftDeleted",
                table: "Movflix",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Movflix",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 14, 6, 49, 30, 848, DateTimeKind.Utc).AddTicks(5449),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 13, 19, 2, 37, 614, DateTimeKind.Utc).AddTicks(1613));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Comment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 14, 6, 49, 30, 860, DateTimeKind.Utc).AddTicks(1355),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 13, 19, 2, 37, 622, DateTimeKind.Utc).AddTicks(5679));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "BlogImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 14, 6, 49, 30, 859, DateTimeKind.Utc).AddTicks(9925),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 13, 19, 2, 37, 622, DateTimeKind.Utc).AddTicks(4445));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Blog",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 14, 6, 49, 30, 857, DateTimeKind.Utc).AddTicks(7628),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 13, 19, 2, 37, 619, DateTimeKind.Utc).AddTicks(7579));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Movie");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "MovieCategory",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "MovieCategory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 13, 19, 2, 37, 626, DateTimeKind.Utc).AddTicks(8386),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 14, 6, 49, 30, 863, DateTimeKind.Utc).AddTicks(9380));

            migrationBuilder.AlterColumn<string>(
                name: "Poster",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Movie",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 13, 19, 2, 37, 626, DateTimeKind.Utc).AddTicks(7078),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 14, 6, 49, 30, 863, DateTimeKind.Utc).AddTicks(8349));

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<bool>(
                name: "SoftDeleted",
                table: "Movflix",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Movflix",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 13, 19, 2, 37, 614, DateTimeKind.Utc).AddTicks(1613),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 14, 6, 49, 30, 848, DateTimeKind.Utc).AddTicks(5449));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Comment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 13, 19, 2, 37, 622, DateTimeKind.Utc).AddTicks(5679),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 14, 6, 49, 30, 860, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "BlogImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 13, 19, 2, 37, 622, DateTimeKind.Utc).AddTicks(4445),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 14, 6, 49, 30, 859, DateTimeKind.Utc).AddTicks(9925));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Blog",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 13, 19, 2, 37, 619, DateTimeKind.Utc).AddTicks(7579),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 14, 6, 49, 30, 857, DateTimeKind.Utc).AddTicks(7628));
        }
    }
}
