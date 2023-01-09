using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class BlogPhoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "MovieComment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Monday, January 9, 2023",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Sunday, January 8, 2023");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "MovieCategory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/09/2023 11:37:22",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/08/2023 14:00:28");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/09/2023 11:37:22",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/08/2023 14:00:28");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Movflix",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/09/2023 11:37:22",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/08/2023 14:00:28");

            migrationBuilder.AlterColumn<bool>(
                name: "SoftDeleted",
                table: "Contact",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Contact",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/09/2023 11:37:22",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/08/2023 14:00:28");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Comment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Monday, January 9, 2023",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Sunday, January 8, 2023");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "BlogImage",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/09/2023 11:37:22",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/08/2023 14:00:28");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Blog",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Monday, January 9, 2023",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Sunday, January 8, 2023");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "MovieComment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Sunday, January 8, 2023",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Monday, January 9, 2023");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "MovieCategory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/08/2023 14:00:28",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/09/2023 11:37:22");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/08/2023 14:00:28",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/09/2023 11:37:22");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Movflix",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/08/2023 14:00:28",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/09/2023 11:37:22");

            migrationBuilder.AlterColumn<bool>(
                name: "SoftDeleted",
                table: "Contact",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Contact",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/08/2023 14:00:28",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/09/2023 11:37:22");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Comment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Sunday, January 8, 2023",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Monday, January 9, 2023");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "BlogImage",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/08/2023 14:00:28",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/09/2023 11:37:22");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Blog",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Sunday, January 8, 2023",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Monday, January 9, 2023");
        }
    }
}
