using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HardwareMonitor.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddReadingField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "value",
                table: "sensor_readings",
                type: "text",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldNullable: true);

            migrationBuilder.AddColumn<double>(
                name: "reading",
                table: "sensor_readings",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "reading",
                table: "sensor_readings");

            migrationBuilder.AlterColumn<double>(
                name: "value",
                table: "sensor_readings",
                type: "double precision",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }
    }
}
