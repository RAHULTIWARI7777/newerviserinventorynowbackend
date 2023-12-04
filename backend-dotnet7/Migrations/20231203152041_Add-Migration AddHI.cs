using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend_dotnet7.Migrations
{
    /// <inheritdoc />
    public partial class AddMigrationAddHI : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AssetTag",
                table: "HardwareInfos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AssignedBy",
                table: "HardwareInfos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AssignedDate",
                table: "HardwareInfos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "HardwareInfos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Condition",
                table: "HardwareInfos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DisposalMethod",
                table: "HardwareInfos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastServiceDate",
                table: "HardwareInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "HardwareInfos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MaintenanceSchedule",
                table: "HardwareInfos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Manufacturer",
                table: "HardwareInfos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "HardwareInfos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "HardwareInfos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PurchaseDate",
                table: "HardwareInfos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PurchaseOrderNumber",
                table: "HardwareInfos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ReplacementDate",
                table: "HardwareInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RetiredDate",
                table: "HardwareInfos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SerialNo",
                table: "HardwareInfos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SupportContact",
                table: "HardwareInfos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WarrantyEndDate",
                table: "HardwareInfos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AssetTag",
                table: "HardwareInfos");

            migrationBuilder.DropColumn(
                name: "AssignedBy",
                table: "HardwareInfos");

            migrationBuilder.DropColumn(
                name: "AssignedDate",
                table: "HardwareInfos");

            migrationBuilder.DropColumn(
                name: "Brand",
                table: "HardwareInfos");

            migrationBuilder.DropColumn(
                name: "Condition",
                table: "HardwareInfos");

            migrationBuilder.DropColumn(
                name: "DisposalMethod",
                table: "HardwareInfos");

            migrationBuilder.DropColumn(
                name: "LastServiceDate",
                table: "HardwareInfos");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "HardwareInfos");

            migrationBuilder.DropColumn(
                name: "MaintenanceSchedule",
                table: "HardwareInfos");

            migrationBuilder.DropColumn(
                name: "Manufacturer",
                table: "HardwareInfos");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "HardwareInfos");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "HardwareInfos");

            migrationBuilder.DropColumn(
                name: "PurchaseDate",
                table: "HardwareInfos");

            migrationBuilder.DropColumn(
                name: "PurchaseOrderNumber",
                table: "HardwareInfos");

            migrationBuilder.DropColumn(
                name: "ReplacementDate",
                table: "HardwareInfos");

            migrationBuilder.DropColumn(
                name: "RetiredDate",
                table: "HardwareInfos");

            migrationBuilder.DropColumn(
                name: "SerialNo",
                table: "HardwareInfos");

            migrationBuilder.DropColumn(
                name: "SupportContact",
                table: "HardwareInfos");

            migrationBuilder.DropColumn(
                name: "WarrantyEndDate",
                table: "HardwareInfos");
        }
    }
}
