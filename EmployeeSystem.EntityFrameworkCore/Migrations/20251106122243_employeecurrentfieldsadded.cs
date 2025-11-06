using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeSystem.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class employeecurrentfieldsadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StreetAddress",
                table: "Employees",
                newName: "CurrentStreetAddress");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Employees",
                newName: "CurrentTehsil");

            migrationBuilder.RenameColumn(
                name: "Mohallah",
                table: "Employees",
                newName: "CurrentMohallah");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Employees",
                newName: "CurrentCity");

            migrationBuilder.AddColumn<string>(
                name: "CurrentDistrict",
                table: "Employees",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CurrentState",
                table: "Employees",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentDistrict",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "CurrentState",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "CurrentTehsil",
                table: "Employees",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "CurrentStreetAddress",
                table: "Employees",
                newName: "StreetAddress");

            migrationBuilder.RenameColumn(
                name: "CurrentMohallah",
                table: "Employees",
                newName: "Mohallah");

            migrationBuilder.RenameColumn(
                name: "CurrentCity",
                table: "Employees",
                newName: "City");
        }
    }
}
