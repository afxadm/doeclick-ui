using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Totem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AdjustBranch_V4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Causes_Operations_OperationId",
                table: "Causes");

            migrationBuilder.DropIndex(
                name: "IX_Causes_OperationId",
                table: "Causes");

            migrationBuilder.DropColumn(
                name: "OperationId",
                table: "Causes");

            migrationBuilder.AddForeignKey(
                name: "FK_Causes_Operations_Id",
                table: "Causes",
                column: "Id",
                principalTable: "Operations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Causes_Operations_Id",
                table: "Causes");

            migrationBuilder.AddColumn<Guid>(
                name: "OperationId",
                table: "Causes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Causes_OperationId",
                table: "Causes",
                column: "OperationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Causes_Operations_OperationId",
                table: "Causes",
                column: "OperationId",
                principalTable: "Operations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
