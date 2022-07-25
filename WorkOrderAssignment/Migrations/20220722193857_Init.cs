using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkOrderAssignment.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TC",
                columns: table => new
                {
                    TId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TC", x => x.TId);
                });

            migrationBuilder.CreateTable(
                name: "WO",
                columns: table => new
                {
                    OId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PostalAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    technicianTId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WO", x => x.OId);
                    table.ForeignKey(
                        name: "FK_WO_TC_technicianTId",
                        column: x => x.technicianTId,
                        principalTable: "TC",
                        principalColumn: "TId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WO_technicianTId",
                table: "WO",
                column: "technicianTId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WO");

            migrationBuilder.DropTable(
                name: "TC");
        }
    }
}
