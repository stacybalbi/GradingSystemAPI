using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GradingSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Gradingdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "rating",
                table: "Score",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "rating",
                table: "Score");
        }
    }
}
