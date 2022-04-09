using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FuelStation.EF.Migrations
{
    public partial class Auth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authentications",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AdminPass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManagerPass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StaffPass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CashierPass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authentications", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Authentications");
        }
    }
}
