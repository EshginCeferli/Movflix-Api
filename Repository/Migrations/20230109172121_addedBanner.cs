using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class addedBanner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "MovieCategory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/09/2023 17:21:20",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/09/2023 11:46:17");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/09/2023 17:21:20",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/09/2023 11:46:17");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Movflix",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/09/2023 17:21:20",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/09/2023 11:46:17");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Contact",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/09/2023 17:21:20",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/09/2023 11:46:17");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "BlogImage",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/09/2023 17:21:20",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/09/2023 11:46:17");

            migrationBuilder.CreateTable(
                name: "Banner",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreateDate = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "01/09/2023 17:21:20")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banner", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Banner");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "MovieCategory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/09/2023 11:46:17",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/09/2023 17:21:20");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/09/2023 11:46:17",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/09/2023 17:21:20");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Movflix",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/09/2023 11:46:17",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/09/2023 17:21:20");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Contact",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/09/2023 11:46:17",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/09/2023 17:21:20");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "BlogImage",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/09/2023 11:46:17",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/09/2023 17:21:20");
        }
    }
}
