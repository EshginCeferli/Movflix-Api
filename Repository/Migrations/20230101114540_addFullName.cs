using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class addFullName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "MovieCategory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/01/2023 11:45:40",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/01/2023 11:42:37");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/01/2023 11:45:40",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/01/2023 11:42:37");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Movflix",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/01/2023 11:45:40",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/01/2023 11:42:37");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Comment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/01/2023 11:45:40",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/01/2023 11:42:37");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "BlogImage",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/01/2023 11:45:40",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/01/2023 11:42:37");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "MovieCategory",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/01/2023 11:42:37",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/01/2023 11:45:40");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/01/2023 11:42:37",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/01/2023 11:45:40");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Movflix",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/01/2023 11:42:37",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/01/2023 11:45:40");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Comment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/01/2023 11:42:37",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/01/2023 11:45:40");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "BlogImage",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/01/2023 11:42:37",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/01/2023 11:45:40");
        }
    }
}
