using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace University.Active.Manager.Storage.Migrations
{
    /// <inheritdoc />
    public partial class EditSpecialityAsStringConversion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Specialty",
                table: "Institutes",
                type: "TEXT",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Specialty",
                table: "Institutes",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 256);
        }
    }
}
