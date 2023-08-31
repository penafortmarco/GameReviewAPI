using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameReview.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class RequiredProblemSolved : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Review",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 13, 10, 51, 507, DateTimeKind.Local).AddTicks(3896),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 9, 58, 53, 243, DateTimeKind.Local).AddTicks(2892));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Review",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 9, 58, 53, 243, DateTimeKind.Local).AddTicks(2892),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 13, 10, 51, 507, DateTimeKind.Local).AddTicks(3896));
        }
    }
}
