using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HardwareMonitor.Api.Migrations
{
    /// <inheritdoc />
    public partial class RedoStructure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "value",
                table: "devices",
                newName: "sublocation");

            migrationBuilder.AddColumn<string>(
                name: "measurement",
                table: "devices",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "unit",
                table: "devices",
                type: "character varying(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "sensorreadings",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    deviceid = table.Column<Guid>(type: "uuid", nullable: false),
                    deviceid1 = table.Column<int>(type: "integer", nullable: true),
                    value = table.Column<double>(type: "double precision", nullable: true),
                    timestamp = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sensorreadings", x => x.id);
                    table.ForeignKey(
                        name: "FK_sensorreadings_devices_deviceid1",
                        column: x => x.deviceid1,
                        principalTable: "devices",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_sensorreadings_deviceid1",
                table: "sensorreadings",
                column: "deviceid1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sensorreadings");

            migrationBuilder.DropColumn(
                name: "measurement",
                table: "devices");

            migrationBuilder.DropColumn(
                name: "unit",
                table: "devices");

            migrationBuilder.RenameColumn(
                name: "sublocation",
                table: "devices",
                newName: "value");
        }
    }
}
