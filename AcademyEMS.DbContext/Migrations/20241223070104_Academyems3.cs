using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcademyEMS.CoreDbContext.Migrations
{
    /// <inheritdoc />
    public partial class Academyems3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_batch_detail_BatchStatus_batch_statusid",
                table: "batch_detail");

            migrationBuilder.DropIndex(
                name: "IX_batch_detail_batch_statusid",
                table: "batch_detail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BatchStatus",
                table: "BatchStatus");

            migrationBuilder.RenameTable(
                name: "BatchStatus",
                newName: "batch_status");

            migrationBuilder.AddColumn<int>(
                name: "status_id",
                table: "batch",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_batch_status",
                table: "batch_status",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_batch_status_id",
                table: "batch",
                column: "status_id");

            migrationBuilder.AddForeignKey(
                name: "FK_batch_batch_status_status_id",
                table: "batch",
                column: "status_id",
                principalTable: "batch_status",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_batch_batch_status_status_id",
                table: "batch");

            migrationBuilder.DropIndex(
                name: "IX_batch_status_id",
                table: "batch");

            migrationBuilder.DropPrimaryKey(
                name: "PK_batch_status",
                table: "batch_status");

            migrationBuilder.DropColumn(
                name: "status_id",
                table: "batch");

            migrationBuilder.RenameTable(
                name: "batch_status",
                newName: "BatchStatus");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BatchStatus",
                table: "BatchStatus",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_batch_detail_batch_statusid",
                table: "batch_detail",
                column: "batch_statusid");

            migrationBuilder.AddForeignKey(
                name: "FK_batch_detail_BatchStatus_batch_statusid",
                table: "batch_detail",
                column: "batch_statusid",
                principalTable: "BatchStatus",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
