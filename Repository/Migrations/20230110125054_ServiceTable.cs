using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class ServiceTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "MovieComment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Tuesday, January 10, 2023",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Monday, January 9, 2023");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "MovieCategory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/10/2023 12:50:54",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/09/2023 17:21:20");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/10/2023 12:50:54",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/09/2023 17:21:20");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Movflix",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/10/2023 12:50:54",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/09/2023 17:21:20");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Contact",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/10/2023 12:50:54",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/09/2023 17:21:20");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Comment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Tuesday, January 10, 2023",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Monday, January 9, 2023");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "BlogImage",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/10/2023 12:50:54",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/09/2023 17:21:20");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Blog",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Blog",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Blog",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Tuesday, January 10, 2023",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Monday, January 9, 2023");

            migrationBuilder.AlterColumn<string>(
                name: "By",
                table: "Blog",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Banner",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/10/2023 12:50:54",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/09/2023 17:21:20");

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreateDate = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "01/10/2023 12:50:54")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "MovieComment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Monday, January 9, 2023",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Tuesday, January 10, 2023");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "MovieCategory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/09/2023 17:21:20",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/10/2023 12:50:54");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/09/2023 17:21:20",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/10/2023 12:50:54");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Movflix",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/09/2023 17:21:20",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/10/2023 12:50:54");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Contact",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/09/2023 17:21:20",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/10/2023 12:50:54");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Comment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Monday, January 9, 2023",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Tuesday, January 10, 2023");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "BlogImage",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/09/2023 17:21:20",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/10/2023 12:50:54");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Blog",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Blog",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Blog",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Monday, January 9, 2023",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Tuesday, January 10, 2023");

            migrationBuilder.AlterColumn<string>(
                name: "By",
                table: "Blog",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Banner",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/09/2023 17:21:20",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/10/2023 12:50:54");
        }
    }
}
