using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class dateTypeChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "MovieCategory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "12/26/2022 09:39:58",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 26, 9, 22, 40, 665, DateTimeKind.Utc).AddTicks(3472));

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "12/26/2022 09:39:58",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 26, 9, 22, 40, 665, DateTimeKind.Utc).AddTicks(2431));

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Movflix",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "12/26/2022 09:39:58",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 26, 9, 22, 40, 656, DateTimeKind.Utc).AddTicks(6966));

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Comment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "12/26/2022 09:39:58",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 26, 9, 22, 40, 661, DateTimeKind.Utc).AddTicks(2732));

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "BlogImage",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "12/26/2022 09:39:58",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 26, 9, 22, 40, 661, DateTimeKind.Utc).AddTicks(1110));

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Blog",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Monday, December 26, 2022",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 26, 9, 22, 40, 660, DateTimeKind.Utc).AddTicks(8034));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "MovieCategory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 26, 9, 22, 40, 665, DateTimeKind.Utc).AddTicks(3472),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "12/26/2022 09:39:58");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Movie",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 26, 9, 22, 40, 665, DateTimeKind.Utc).AddTicks(2431),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "12/26/2022 09:39:58");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Movflix",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 26, 9, 22, 40, 656, DateTimeKind.Utc).AddTicks(6966),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "12/26/2022 09:39:58");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Comment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 26, 9, 22, 40, 661, DateTimeKind.Utc).AddTicks(2732),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "12/26/2022 09:39:58");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "BlogImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 26, 9, 22, 40, 661, DateTimeKind.Utc).AddTicks(1110),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "12/26/2022 09:39:58");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Blog",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 26, 9, 22, 40, 660, DateTimeKind.Utc).AddTicks(8034),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Monday, December 26, 2022");
        }
    }
}
