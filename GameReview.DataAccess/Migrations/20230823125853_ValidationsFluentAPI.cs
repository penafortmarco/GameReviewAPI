using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameReview.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ValidationsFluentAPI : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Reviews_ReviewId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_UserId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Likes_Reviews_ReviewId",
                table: "Likes");

            migrationBuilder.DropForeignKey(
                name: "FK_Likes_Users_UserId",
                table: "Likes");

            migrationBuilder.DropForeignKey(
                name: "FK_Operations_Modules_ModuleId",
                table: "Operations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Users_UserId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_RolOperation_Operations_OperationId",
                table: "RolOperation");

            migrationBuilder.DropForeignKey(
                name: "FK_RolOperation_Rols_RolId",
                table: "RolOperation");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Rols_RolId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rols",
                table: "Rols");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RolOperation",
                table: "RolOperation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Operations",
                table: "Operations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Modules",
                table: "Modules");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Likes",
                table: "Likes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comments",
                table: "Comments");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "Rols",
                newName: "Rol");

            migrationBuilder.RenameTable(
                name: "RolOperation",
                newName: "Rol_Operation");

            migrationBuilder.RenameTable(
                name: "Reviews",
                newName: "Review");

            migrationBuilder.RenameTable(
                name: "Operations",
                newName: "Operation");

            migrationBuilder.RenameTable(
                name: "Modules",
                newName: "Module");

            migrationBuilder.RenameTable(
                name: "Likes",
                newName: "Like");

            migrationBuilder.RenameTable(
                name: "Comments",
                newName: "Comment");

            migrationBuilder.RenameIndex(
                name: "IX_Users_RolId",
                table: "User",
                newName: "IX_User_RolId");

            migrationBuilder.RenameIndex(
                name: "IX_RolOperation_RolId",
                table: "Rol_Operation",
                newName: "IX_Rol_Operation_RolId");

            migrationBuilder.RenameIndex(
                name: "IX_RolOperation_OperationId",
                table: "Rol_Operation",
                newName: "IX_Rol_Operation_OperationId");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_UserId",
                table: "Review",
                newName: "IX_Review_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Operations_ModuleId",
                table: "Operation",
                newName: "IX_Operation_ModuleId");

            migrationBuilder.RenameIndex(
                name: "IX_Likes_UserId",
                table: "Like",
                newName: "IX_Like_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Likes_ReviewId",
                table: "Like",
                newName: "IX_Like_ReviewId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_UserId",
                table: "Comment",
                newName: "IX_Comment_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_ReviewId",
                table: "Comment",
                newName: "IX_Comment_ReviewId");

            migrationBuilder.AlterColumn<int>(
                name: "RolId",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 2,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "User",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(36)",
                oldMaxLength: 36);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Review",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Review",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Review",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(850)",
                oldMaxLength: 850);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Review",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 9, 58, 53, 243, DateTimeKind.Local).AddTicks(2892),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rol",
                table: "Rol",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rol_Operation",
                table: "Rol_Operation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Review",
                table: "Review",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Operation",
                table: "Operation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Module",
                table: "Module",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Like",
                table: "Like",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comment",
                table: "Comment",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Review_ReviewId",
                table: "Comment",
                column: "ReviewId",
                principalTable: "Review",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_User_UserId",
                table: "Comment",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Like_Review_ReviewId",
                table: "Like",
                column: "ReviewId",
                principalTable: "Review",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Like_User_UserId",
                table: "Like",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Operation_Module_ModuleId",
                table: "Operation",
                column: "ModuleId",
                principalTable: "Module",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_User_UserId",
                table: "Review",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rol_Operation_Operation_OperationId",
                table: "Rol_Operation",
                column: "OperationId",
                principalTable: "Operation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rol_Operation_Rol_RolId",
                table: "Rol_Operation",
                column: "RolId",
                principalTable: "Rol",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Rol_RolId",
                table: "User",
                column: "RolId",
                principalTable: "Rol",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Review_ReviewId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Comment_User_UserId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Like_Review_ReviewId",
                table: "Like");

            migrationBuilder.DropForeignKey(
                name: "FK_Like_User_UserId",
                table: "Like");

            migrationBuilder.DropForeignKey(
                name: "FK_Operation_Module_ModuleId",
                table: "Operation");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_User_UserId",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Rol_Operation_Operation_OperationId",
                table: "Rol_Operation");

            migrationBuilder.DropForeignKey(
                name: "FK_Rol_Operation_Rol_RolId",
                table: "Rol_Operation");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Rol_RolId",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rol_Operation",
                table: "Rol_Operation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rol",
                table: "Rol");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Review",
                table: "Review");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Operation",
                table: "Operation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Module",
                table: "Module");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Like",
                table: "Like");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comment",
                table: "Comment");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "Rol_Operation",
                newName: "RolOperation");

            migrationBuilder.RenameTable(
                name: "Rol",
                newName: "Rols");

            migrationBuilder.RenameTable(
                name: "Review",
                newName: "Reviews");

            migrationBuilder.RenameTable(
                name: "Operation",
                newName: "Operations");

            migrationBuilder.RenameTable(
                name: "Module",
                newName: "Modules");

            migrationBuilder.RenameTable(
                name: "Like",
                newName: "Likes");

            migrationBuilder.RenameTable(
                name: "Comment",
                newName: "Comments");

            migrationBuilder.RenameIndex(
                name: "IX_User_RolId",
                table: "Users",
                newName: "IX_Users_RolId");

            migrationBuilder.RenameIndex(
                name: "IX_Rol_Operation_RolId",
                table: "RolOperation",
                newName: "IX_RolOperation_RolId");

            migrationBuilder.RenameIndex(
                name: "IX_Rol_Operation_OperationId",
                table: "RolOperation",
                newName: "IX_RolOperation_OperationId");

            migrationBuilder.RenameIndex(
                name: "IX_Review_UserId",
                table: "Reviews",
                newName: "IX_Reviews_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Operation_ModuleId",
                table: "Operations",
                newName: "IX_Operations_ModuleId");

            migrationBuilder.RenameIndex(
                name: "IX_Like_UserId",
                table: "Likes",
                newName: "IX_Likes_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Like_ReviewId",
                table: "Likes",
                newName: "IX_Likes_ReviewId");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_UserId",
                table: "Comments",
                newName: "IX_Comments_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_ReviewId",
                table: "Comments",
                newName: "IX_Comments_ReviewId");

            migrationBuilder.AlterColumn<int>(
                name: "RolId",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Reviews",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Reviews",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Reviews",
                type: "nvarchar(850)",
                maxLength: 850,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 9, 58, 53, 243, DateTimeKind.Local).AddTicks(2892));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RolOperation",
                table: "RolOperation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rols",
                table: "Rols",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Operations",
                table: "Operations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Modules",
                table: "Modules",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Likes",
                table: "Likes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comments",
                table: "Comments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Reviews_ReviewId",
                table: "Comments",
                column: "ReviewId",
                principalTable: "Reviews",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Users_UserId",
                table: "Comments",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_Reviews_ReviewId",
                table: "Likes",
                column: "ReviewId",
                principalTable: "Reviews",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_Users_UserId",
                table: "Likes",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Operations_Modules_ModuleId",
                table: "Operations",
                column: "ModuleId",
                principalTable: "Modules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Users_UserId",
                table: "Reviews",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RolOperation_Operations_OperationId",
                table: "RolOperation",
                column: "OperationId",
                principalTable: "Operations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RolOperation_Rols_RolId",
                table: "RolOperation",
                column: "RolId",
                principalTable: "Rols",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Rols_RolId",
                table: "Users",
                column: "RolId",
                principalTable: "Rols",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
