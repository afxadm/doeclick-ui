using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Totem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AlterColumn_V4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Causes_Operations_Id",
                table: "Causes");

            migrationBuilder.AddColumn<Guid>(
                name: "OperationsId",
                table: "Causes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Causes_OperationsId",
                table: "Causes",
                column: "OperationsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Causes_Operations_OperationsId",
                table: "Causes",
                column: "OperationsId",
                principalTable: "Operations",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Causes_Operations_OperationsId",
                table: "Causes");

            migrationBuilder.DropIndex(
                name: "IX_Causes_OperationsId",
                table: "Causes");

            migrationBuilder.DropColumn(
                name: "OperationsId",
                table: "Causes");

            migrationBuilder.AddForeignKey(
                name: "FK_Causes_Operations_Id",
                table: "Causes",
                column: "Id",
                principalTable: "Operations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
