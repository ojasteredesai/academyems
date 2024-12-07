using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcademyEMS.CoreDbContext.Migrations
{
    /// <inheritdoc />
    public partial class Academyems2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_user_detail_address_id",
                table: "user_detail",
                column: "address_id");

            migrationBuilder.AddForeignKey(
                name: "FK_user_detail_address_address_id",
                table: "user_detail",
                column: "address_id",
                principalTable: "address",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_user_detail_address_address_id",
                table: "user_detail");

            migrationBuilder.DropIndex(
                name: "IX_user_detail_address_id",
                table: "user_detail");
        }
    }
}
