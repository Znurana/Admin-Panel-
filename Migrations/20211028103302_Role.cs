using Microsoft.EntityFrameworkCore.Migrations;

namespace Test_AdminPanel.Migrations
{
    public partial class Role : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Map_UserRoles_roles_RoleID",
                table: "Map_UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_Map_UserRoles_Users_UserID",
                table: "Map_UserRoles");


            migrationBuilder.DropPrimaryKey(
                name: "PK_roles",
                table: "roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Map_UserRoles",
                table: "Map_UserRoles");

            migrationBuilder.RenameTable(
                name: "roles",
                newName: "Roles");

            migrationBuilder.RenameTable(
                name: "Map_UserRoles",
                newName: "UserRoles");

            migrationBuilder.RenameIndex(
                name: "IX_Map_UserRoles_UserID",
                table: "UserRoles",
                newName: "IX_UserRoles_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Map_UserRoles_RoleID",
                table: "UserRoles",
                newName: "IX_UserRoles_RoleID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                table: "Roles",
                column: "RoleID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles",
                column: "UserRoleID");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Roles_RoleID",
                table: "UserRoles",
                column: "RoleID",
                principalTable: "Roles",
                principalColumn: "RoleID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Users_UserID",
                table: "UserRoles",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Roles_RoleID",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Users_UserID",
                table: "UserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                table: "Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles");

            migrationBuilder.RenameTable(
                name: "Roles",
                newName: "roles");

            migrationBuilder.RenameTable(
                name: "UserRoles",
                newName: "Map_UserRoles");

            migrationBuilder.RenameIndex(
                name: "IX_UserRoles_UserID",
                table: "Map_UserRoles",
                newName: "IX_Map_UserRoles_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_UserRoles_RoleID",
                table: "Map_UserRoles",
                newName: "IX_Map_UserRoles_RoleID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_roles",
                table: "roles",
                column: "RoleID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Map_UserRoles",
                table: "Map_UserRoles",
                column: "UserRoleID");

          

            migrationBuilder.AddForeignKey(
                name: "FK_Map_UserRoles_roles_RoleID",
                table: "Map_UserRoles",
                column: "RoleID",
                principalTable: "roles",
                principalColumn: "RoleID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Map_UserRoles_Users_UserID",
                table: "Map_UserRoles",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
