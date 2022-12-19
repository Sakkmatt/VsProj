using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VsProj.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PartnerInfos",
                columns: table => new
                {
                    PARTNERID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PARTNERNEV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IRANYITOSZAM = table.Column<int>(type: "int", nullable: false),
                    VAROS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UTCA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ROGZIDO = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartnerInfos", x => x.PARTNERID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PartnerInfos");
        }
    }
}
