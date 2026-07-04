using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstApp.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "phone",
                table: "Students",
                newName: "stuphone");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Students",
                newName: "stuname");

            migrationBuilder.RenameColumn(
                name: "gender",
                table: "Students",
                newName: "stugen");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Students",
                newName: "stuemail");

            migrationBuilder.RenameColumn(
                name: "dob",
                table: "Students",
                newName: "studob");

            migrationBuilder.RenameColumn(
                name: "sid",
                table: "Students",
                newName: "stuid");

            migrationBuilder.AlterColumn<string>(
                name: "stuphone",
                table: "Students",
                type: "varchar(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "stuname",
                table: "Students",
                type: "varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "stugen",
                table: "Students",
                type: "varchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "stuemail",
                table: "Students",
                type: "varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "stuphone",
                table: "Students",
                newName: "phone");

            migrationBuilder.RenameColumn(
                name: "stuname",
                table: "Students",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "stugen",
                table: "Students",
                newName: "gender");

            migrationBuilder.RenameColumn(
                name: "stuemail",
                table: "Students",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "studob",
                table: "Students",
                newName: "dob");

            migrationBuilder.RenameColumn(
                name: "stuid",
                table: "Students",
                newName: "sid");

            migrationBuilder.AlterColumn<string>(
                name: "phone",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "gender",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldNullable: true);
        }
    }
}
