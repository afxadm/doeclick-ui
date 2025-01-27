using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Totem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodeBranch",
                table: "User");

            migrationBuilder.RenameColumn(
                name: "PositionId",
                table: "User",
                newName: "BranchId");

            migrationBuilder.AddColumn<string>(
                name: "JobDescription",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Branch",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CodeBranch = table.Column<long>(type: "bigint", maxLength: 6, nullable: false),
                    NameBranch = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Telephone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branch", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_BranchId",
                table: "User",
                column: "BranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Branch_BranchId",
                table: "User",
                column: "BranchId",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Branch_BranchId",
                table: "User");

            migrationBuilder.DropTable(
                name: "Branch");

            migrationBuilder.DropIndex(
                name: "IX_User_BranchId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "JobDescription",
                table: "User");

            migrationBuilder.RenameColumn(
                name: "BranchId",
                table: "User",
                newName: "PositionId");

            migrationBuilder.AddColumn<Guid>(
                name: "CodeBranch",
                table: "User",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
