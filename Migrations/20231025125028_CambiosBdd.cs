using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MauroSalguero_1P.Migrations
{
    public partial class CambiosBdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MauroSalguero_tabla",
                columns: table => new
                {
                    msName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    msID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    msUdlaStudent = table.Column<bool>(type: "bit", nullable: false),
                    msEdad = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    msDateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    msGrade = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MauroSalguero_tabla", x => x.msName);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MauroSalguero_tabla");
        }
    }
}
