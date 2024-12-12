using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManager_V01.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class init02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskAssignee_Tasks_TaskId",
                table: "TaskAssignee");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskAssignee_UserAccounts_UserAccountID",
                table: "TaskAssignee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaskAssignee",
                table: "TaskAssignee");

            migrationBuilder.RenameTable(
                name: "TaskAssignee",
                newName: "TaskAssignees");

            migrationBuilder.RenameIndex(
                name: "IX_TaskAssignee_UserAccountID",
                table: "TaskAssignees",
                newName: "IX_TaskAssignees_UserAccountID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaskAssignees",
                table: "TaskAssignees",
                columns: new[] { "TaskId", "UserAccountID" });

            migrationBuilder.AddForeignKey(
                name: "FK_TaskAssignees_Tasks_TaskId",
                table: "TaskAssignees",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "TaskId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskAssignees_UserAccounts_UserAccountID",
                table: "TaskAssignees",
                column: "UserAccountID",
                principalTable: "UserAccounts",
                principalColumn: "AccountID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskAssignees_Tasks_TaskId",
                table: "TaskAssignees");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskAssignees_UserAccounts_UserAccountID",
                table: "TaskAssignees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaskAssignees",
                table: "TaskAssignees");

            migrationBuilder.RenameTable(
                name: "TaskAssignees",
                newName: "TaskAssignee");

            migrationBuilder.RenameIndex(
                name: "IX_TaskAssignees_UserAccountID",
                table: "TaskAssignee",
                newName: "IX_TaskAssignee_UserAccountID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaskAssignee",
                table: "TaskAssignee",
                columns: new[] { "TaskId", "UserAccountID" });

            migrationBuilder.AddForeignKey(
                name: "FK_TaskAssignee_Tasks_TaskId",
                table: "TaskAssignee",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "TaskId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskAssignee_UserAccounts_UserAccountID",
                table: "TaskAssignee",
                column: "UserAccountID",
                principalTable: "UserAccounts",
                principalColumn: "AccountID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
