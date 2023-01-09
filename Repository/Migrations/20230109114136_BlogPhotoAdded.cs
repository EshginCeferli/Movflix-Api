using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class BlogPhotoAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "MovieCategory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/09/2023 11:41:36",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/09/2023 11:37:22");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/09/2023 11:41:36",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/09/2023 11:37:22");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Movflix",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/09/2023 11:41:36",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/09/2023 11:37:22");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Contact",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/09/2023 11:41:36",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/09/2023 11:37:22");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "BlogImage",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/09/2023 11:41:36",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/09/2023 11:37:22");

            migrationBuilder.AddColumn<byte[]>(
                name: "Photo",
                table: "Blog",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Blog");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "MovieCategory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/09/2023 11:37:22",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/09/2023 11:41:36");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/09/2023 11:37:22",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/09/2023 11:41:36");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Movflix",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/09/2023 11:37:22",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/09/2023 11:41:36");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Contact",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/09/2023 11:37:22",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/09/2023 11:41:36");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "BlogImage",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/09/2023 11:37:22",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/09/2023 11:41:36");
        }
    }
}
