using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Totem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AdjustBranch_V6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Branch_Operations_Id",
                table: "Branch");

            migrationBuilder.DropForeignKey(
                name: "FK_Taxpayers_Operations_Id",
                table: "Taxpayers");

            migrationBuilder.AlterColumn<Guid>(
                name: "TaxpayerId",
                table: "Operations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Operations_BranchId",
                table: "Operations",
                column: "BranchId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Operations_TaxpayerId",
                table: "Operations",
                column: "TaxpayerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Operations_Branch_BranchId",
                table: "Operations",
                column: "BranchId",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Operations_Taxpayers_TaxpayerId",
                table: "Operations",
                column: "TaxpayerId",
                principalTable: "Taxpayers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Operations_Branch_BranchId",
                table: "Operations");

            migrationBuilder.DropForeignKey(
                name: "FK_Operations_Taxpayers_TaxpayerId",
                table: "Operations");

            migrationBuilder.DropIndex(
                name: "IX_Operations_BranchId",
                table: "Operations");

            migrationBuilder.DropIndex(
                name: "IX_Operations_TaxpayerId",
                table: "Operations");

            migrationBuilder.AlterColumn<Guid>(
                name: "TaxpayerId",
                table: "Operations",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_Branch_Operations_Id",
                table: "Branch",
                column: "Id",
                principalTable: "Operations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Taxpayers_Operations_Id",
                table: "Taxpayers",
                column: "Id",
                principalTable: "Operations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
