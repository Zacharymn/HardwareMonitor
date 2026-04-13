using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HardwareMonitor.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddSensorReadingsAndSnakeCase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_sensorreadings_devices_deviceid1",
                table: "sensorreadings");

            migrationBuilder.RenameColumn(
                name: "deviceid1",
                table: "sensorreadings",
                newName: "device_id1");

            migrationBuilder.RenameColumn(
                name: "deviceid",
                table: "sensorreadings",
                newName: "device_id");

            migrationBuilder.RenameIndex(
                name: "IX_sensorreadings_deviceid1",
                table: "sensorreadings",
                newName: "IX_sensorreadings_device_id1");

            migrationBuilder.RenameColumn(
                name: "sublocation",
                table: "devices",
                newName: "sub_location");

            migrationBuilder.RenameColumn(
                name: "deviceid",
                table: "devices",
                newName: "device_id");

            migrationBuilder.AddForeignKey(
                name: "FK_sensorreadings_devices_device_id1",
                table: "sensorreadings",
                column: "device_id1",
                principalTable: "devices",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_sensorreadings_devices_device_id1",
                table: "sensorreadings");

            migrationBuilder.RenameColumn(
                name: "device_id1",
                table: "sensorreadings",
                newName: "deviceid1");

            migrationBuilder.RenameColumn(
                name: "device_id",
                table: "sensorreadings",
                newName: "deviceid");

            migrationBuilder.RenameIndex(
                name: "IX_sensorreadings_device_id1",
                table: "sensorreadings",
                newName: "IX_sensorreadings_deviceid1");

            migrationBuilder.RenameColumn(
                name: "sub_location",
                table: "devices",
                newName: "sublocation");

            migrationBuilder.RenameColumn(
                name: "device_id",
                table: "devices",
                newName: "deviceid");

            migrationBuilder.AddForeignKey(
                name: "FK_sensorreadings_devices_deviceid1",
                table: "sensorreadings",
                column: "deviceid1",
                principalTable: "devices",
                principalColumn: "id");
        }
    }
}
