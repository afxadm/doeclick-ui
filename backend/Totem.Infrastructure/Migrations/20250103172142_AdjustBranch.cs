using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Totem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AdjustBranch : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Branch_CodeBranch",
                table: "Branch",
                column: "CodeBranch",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Branch_CodeBranch",
                table: "Branch");
        }
    }
}
