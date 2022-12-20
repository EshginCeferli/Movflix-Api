using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class addMovieMovieCategoryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Movflix",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 13, 18, 56, 3, 187, DateTimeKind.Utc).AddTicks(1172),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 13, 17, 34, 53, 644, DateTimeKind.Utc).AddTicks(5103));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Comment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 13, 18, 56, 3, 190, DateTimeKind.Utc).AddTicks(4178),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 13, 17, 34, 53, 649, DateTimeKind.Utc).AddTicks(3776));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "BlogImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 13, 18, 56, 3, 190, DateTimeKind.Utc).AddTicks(3479),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 13, 17, 34, 53, 647, DateTimeKind.Utc).AddTicks(4719));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Blog",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 13, 18, 56, 3, 189, DateTimeKind.Utc).AddTicks(1725),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 13, 17, 34, 53, 645, DateTimeKind.Utc).AddTicks(5512));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Movflix",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 13, 17, 34, 53, 644, DateTimeKind.Utc).AddTicks(5103),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 13, 18, 56, 3, 187, DateTimeKind.Utc).AddTicks(1172));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Comment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 13, 17, 34, 53, 649, DateTimeKind.Utc).AddTicks(3776),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 13, 18, 56, 3, 190, DateTimeKind.Utc).AddTicks(4178));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "BlogImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 13, 17, 34, 53, 647, DateTimeKind.Utc).AddTicks(4719),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 13, 18, 56, 3, 190, DateTimeKind.Utc).AddTicks(3479));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Blog",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 13, 17, 34, 53, 645, DateTimeKind.Utc).AddTicks(5512),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 13, 18, 56, 3, 189, DateTimeKind.Utc).AddTicks(1725));
        }
    }
}
