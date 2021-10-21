using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Test_AdminPanel.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "kassas",
                columns: table => new
                {
                    KassaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KassaIP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KassaNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MonitorIP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KompIP = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kassas", x => x.KassaID);
                });

            migrationBuilder.CreateTable(
                name: "stations",
                columns: table => new
                {
                    StationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StationName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stations", x => x.StationID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserFatherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    UserPassword = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    StationID = table.Column<int>(type: "int", nullable: true),
                    KassaID = table.Column<int>(type: "int", nullable: true),
                    UserCreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_Users_kassas_KassaID",
                        column: x => x.KassaID,
                        principalTable: "kassas",
                        principalColumn: "KassaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_stations_StationID",
                        column: x => x.StationID,
                        principalTable: "stations",
                        principalColumn: "StationID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_KassaID",
                table: "Users",
                column: "KassaID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_StationID",
                table: "Users",
                column: "StationID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "kassas");

            migrationBuilder.DropTable(
                name: "stations");
        }
    }
}
