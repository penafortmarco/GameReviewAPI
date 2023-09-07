using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameReview.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UserOnDeleteBehaviorChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Review",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 14, 12, 13, 566, DateTimeKind.Local).AddTicks(1438),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 10, 48, 22, 566, DateTimeKind.Local).AddTicks(980));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Review",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 6, 10, 48, 22, 566, DateTimeKind.Local).AddTicks(980),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 6, 14, 12, 13, 566, DateTimeKind.Local).AddTicks(1438));
        }
    }
}
