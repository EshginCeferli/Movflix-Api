using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class addedReleaseYearColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "MovieCategory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 26, 9, 22, 40, 665, DateTimeKind.Utc).AddTicks(3472),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 26, 9, 20, 46, 312, DateTimeKind.Utc).AddTicks(7060));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Movie",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 26, 9, 22, 40, 665, DateTimeKind.Utc).AddTicks(2431),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 26, 9, 20, 46, 312, DateTimeKind.Utc).AddTicks(5851));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Movflix",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 26, 9, 22, 40, 656, DateTimeKind.Utc).AddTicks(6966),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 26, 9, 20, 46, 297, DateTimeKind.Utc).AddTicks(6723));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Comment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 26, 9, 22, 40, 661, DateTimeKind.Utc).AddTicks(2732),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 26, 9, 20, 46, 308, DateTimeKind.Utc).AddTicks(1688));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "BlogImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 26, 9, 22, 40, 661, DateTimeKind.Utc).AddTicks(1110),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 26, 9, 20, 46, 308, DateTimeKind.Utc).AddTicks(738));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Blog",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 26, 9, 22, 40, 660, DateTimeKind.Utc).AddTicks(8034),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 26, 9, 20, 46, 307, DateTimeKind.Utc).AddTicks(9285));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "MovieCategory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 26, 9, 20, 46, 312, DateTimeKind.Utc).AddTicks(7060),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 26, 9, 22, 40, 665, DateTimeKind.Utc).AddTicks(3472));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Movie",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 26, 9, 20, 46, 312, DateTimeKind.Utc).AddTicks(5851),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 26, 9, 22, 40, 665, DateTimeKind.Utc).AddTicks(2431));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Movflix",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 26, 9, 20, 46, 297, DateTimeKind.Utc).AddTicks(6723),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 26, 9, 22, 40, 656, DateTimeKind.Utc).AddTicks(6966));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Comment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 26, 9, 20, 46, 308, DateTimeKind.Utc).AddTicks(1688),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 26, 9, 22, 40, 661, DateTimeKind.Utc).AddTicks(2732));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "BlogImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 26, 9, 20, 46, 308, DateTimeKind.Utc).AddTicks(738),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 26, 9, 22, 40, 661, DateTimeKind.Utc).AddTicks(1110));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Blog",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 26, 9, 20, 46, 307, DateTimeKind.Utc).AddTicks(9285),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 26, 9, 22, 40, 660, DateTimeKind.Utc).AddTicks(8034));
        }
    }
}
