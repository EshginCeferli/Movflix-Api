using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class addedPricingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Servise",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/10/2023 17:26:28",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/10/2023 15:12:10");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "MovieCategory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/10/2023 17:26:28",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/10/2023 15:12:10");

            migrationBuilder.AlterColumn<byte[]>(
                name: "Photo",
                table: "Movie",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/10/2023 17:26:28",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/10/2023 15:12:10");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Movflix",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/10/2023 17:26:28",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/10/2023 15:12:10");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Contact",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/10/2023 17:26:28",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/10/2023 15:12:10");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "BlogImage",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/10/2023 17:26:28",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/10/2023 15:12:10");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Banner",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/10/2023 17:26:28",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/10/2023 15:12:10");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Servise",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/10/2023 15:12:10",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/10/2023 17:26:28");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "MovieCategory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/10/2023 15:12:10",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/10/2023 17:26:28");

            migrationBuilder.AlterColumn<byte[]>(
                name: "Photo",
                table: "Movie",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/10/2023 15:12:10",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/10/2023 17:26:28");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Movflix",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/10/2023 15:12:10",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/10/2023 17:26:28");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Contact",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/10/2023 15:12:10",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/10/2023 17:26:28");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "BlogImage",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/10/2023 15:12:10",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/10/2023 17:26:28");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Banner",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/10/2023 15:12:10",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/10/2023 17:26:28");
        }
    }
}
