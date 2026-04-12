using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HardwareMonitor.Api.Migrations
{
    /// <inheritdoc />
    public partial class LowercaseTableNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Devices",
                table: "Devices");

            migrationBuilder.RenameTable(
                name: "Devices",
                newName: "devices");

            migrationBuilder.RenameColumn(
                name: "Value",
                table: "devices",
                newName: "value");

            migrationBuilder.RenameColumn(
                name: "Timestamp",
                table: "devices",
                newName: "timestamp");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "devices",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Location",
                table: "devices",
                newName: "location");

            migrationBuilder.RenameColumn(
                name: "DeviceId",
                table: "devices",
                newName: "deviceid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "devices",
                newName: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_devices",
                table: "devices",
                column: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_devices",
                table: "devices");

            migrationBuilder.RenameTable(
                name: "devices",
                newName: "Devices");

            migrationBuilder.RenameColumn(
                name: "value",
                table: "Devices",
                newName: "Value");

            migrationBuilder.RenameColumn(
                name: "timestamp",
                table: "Devices",
                newName: "Timestamp");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Devices",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "location",
                table: "Devices",
                newName: "Location");

            migrationBuilder.RenameColumn(
                name: "deviceid",
                table: "Devices",
                newName: "DeviceId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Devices",
                newName: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Devices",
                table: "Devices",
                column: "Id");
        }
    }
}
