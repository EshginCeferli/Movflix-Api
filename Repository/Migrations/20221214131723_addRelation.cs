using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class addRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "MovieCategory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 14, 13, 17, 23, 377, DateTimeKind.Utc).AddTicks(8848),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 14, 6, 49, 30, 863, DateTimeKind.Utc).AddTicks(9380));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Movie",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 14, 13, 17, 23, 377, DateTimeKind.Utc).AddTicks(6619),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 14, 6, 49, 30, 863, DateTimeKind.Utc).AddTicks(8349));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Movflix",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Movflix",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 14, 13, 17, 23, 364, DateTimeKind.Utc).AddTicks(9164),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 14, 6, 49, 30, 848, DateTimeKind.Utc).AddTicks(5449));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Comment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 14, 13, 17, 23, 371, DateTimeKind.Utc).AddTicks(6829),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 14, 6, 49, 30, 860, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "BlogImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 14, 13, 17, 23, 371, DateTimeKind.Utc).AddTicks(5030),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 14, 6, 49, 30, 859, DateTimeKind.Utc).AddTicks(9925));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Blog",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 14, 13, 17, 23, 368, DateTimeKind.Utc).AddTicks(4607),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 14, 6, 49, 30, 857, DateTimeKind.Utc).AddTicks(7628));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "MovieCategory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 14, 6, 49, 30, 863, DateTimeKind.Utc).AddTicks(9380),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 14, 13, 17, 23, 377, DateTimeKind.Utc).AddTicks(8848));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Movie",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 14, 6, 49, 30, 863, DateTimeKind.Utc).AddTicks(8349),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 14, 13, 17, 23, 377, DateTimeKind.Utc).AddTicks(6619));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Movflix",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Movflix",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 14, 6, 49, 30, 848, DateTimeKind.Utc).AddTicks(5449),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 14, 13, 17, 23, 364, DateTimeKind.Utc).AddTicks(9164));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Comment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 14, 6, 49, 30, 860, DateTimeKind.Utc).AddTicks(1355),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 14, 13, 17, 23, 371, DateTimeKind.Utc).AddTicks(6829));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "BlogImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 14, 6, 49, 30, 859, DateTimeKind.Utc).AddTicks(9925),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 14, 13, 17, 23, 371, DateTimeKind.Utc).AddTicks(5030));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Blog",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 14, 6, 49, 30, 857, DateTimeKind.Utc).AddTicks(7628),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 14, 13, 17, 23, 368, DateTimeKind.Utc).AddTicks(4607));
        }
    }
}
