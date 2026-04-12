using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HardwareMonitor.Api.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDeviceValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "value",
                table: "devices",
                type: "text",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "devices",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "description",
                table: "devices");

            migrationBuilder.AlterColumn<double>(
                name: "value",
                table: "devices",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }
    }
}
