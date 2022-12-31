using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class addedReleaseYearColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "MovieCategory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 26, 9, 20, 46, 312, DateTimeKind.Utc).AddTicks(7060),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 14, 13, 17, 23, 377, DateTimeKind.Utc).AddTicks(8848));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Movie",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 26, 9, 20, 46, 312, DateTimeKind.Utc).AddTicks(5851),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 14, 13, 17, 23, 377, DateTimeKind.Utc).AddTicks(6619));

            migrationBuilder.AddColumn<int>(
                name: "ReleaseYear",
                table: "Movie",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Movflix",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 26, 9, 20, 46, 297, DateTimeKind.Utc).AddTicks(6723),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 14, 13, 17, 23, 364, DateTimeKind.Utc).AddTicks(9164));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Comment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 26, 9, 20, 46, 308, DateTimeKind.Utc).AddTicks(1688),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 14, 13, 17, 23, 371, DateTimeKind.Utc).AddTicks(6829));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "BlogImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 26, 9, 20, 46, 308, DateTimeKind.Utc).AddTicks(738),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 14, 13, 17, 23, 371, DateTimeKind.Utc).AddTicks(5030));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Blog",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 26, 9, 20, 46, 307, DateTimeKind.Utc).AddTicks(9285),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 14, 13, 17, 23, 368, DateTimeKind.Utc).AddTicks(4607));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReleaseYear",
                table: "Movie");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "MovieCategory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 14, 13, 17, 23, 377, DateTimeKind.Utc).AddTicks(8848),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 26, 9, 20, 46, 312, DateTimeKind.Utc).AddTicks(7060));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Movie",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 14, 13, 17, 23, 377, DateTimeKind.Utc).AddTicks(6619),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 26, 9, 20, 46, 312, DateTimeKind.Utc).AddTicks(5851));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Movflix",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 14, 13, 17, 23, 364, DateTimeKind.Utc).AddTicks(9164),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 26, 9, 20, 46, 297, DateTimeKind.Utc).AddTicks(6723));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Comment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 14, 13, 17, 23, 371, DateTimeKind.Utc).AddTicks(6829),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 26, 9, 20, 46, 308, DateTimeKind.Utc).AddTicks(1688));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "BlogImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 14, 13, 17, 23, 371, DateTimeKind.Utc).AddTicks(5030),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 26, 9, 20, 46, 308, DateTimeKind.Utc).AddTicks(738));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Blog",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 14, 13, 17, 23, 368, DateTimeKind.Utc).AddTicks(4607),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 26, 9, 20, 46, 307, DateTimeKind.Utc).AddTicks(9285));
        }
    }
}
