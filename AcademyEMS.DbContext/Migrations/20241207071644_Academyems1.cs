using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcademyEMS.CoreDbContext.Migrations
{
    /// <inheritdoc />
    public partial class Academyems1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "address_id",
                table: "user_detail",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "address_id",
                table: "user_detail");
        }
    }
}
