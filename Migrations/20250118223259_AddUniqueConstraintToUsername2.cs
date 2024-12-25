using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Airline.Migrations
{
    /// <inheritdoc />
    public partial class AddUniqueConstraintToUsername2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Time",
                table: "Flights",
                newName: "DateTime");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "Flights",
                newName: "Time");
        }
    }
}
