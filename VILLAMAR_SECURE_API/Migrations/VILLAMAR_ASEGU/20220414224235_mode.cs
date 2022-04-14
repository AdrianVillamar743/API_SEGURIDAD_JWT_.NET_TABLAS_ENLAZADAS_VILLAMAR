using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VILLAMAR_SECURE_API.Migrations.VILLAMAR_ASEGU
{
    public partial class mode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.CreateTable(
                name: "departamento",
                columns: table => new
                {
                    id_departamento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departamento", x => x.id_departamento);
                });

            
            migrationBuilder.CreateTable(
                name: "empleado",
                columns: table => new
                {
                    id_empleado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    id_departamento = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empleado", x => x.id_empleado);
                    table.ForeignKey(
                        name: "FK_empleado_departamento_id_departamento",
                        column: x => x.id_departamento,
                        principalTable: "departamento",
                        principalColumn: "id_departamento",
                        onDelete: ReferentialAction.Cascade);
                });

        
        

            migrationBuilder.CreateIndex(
                name: "IX_empleado_id_departamento",
                table: "empleado",
                column: "id_departamento");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        

            migrationBuilder.DropTable(
                name: "empleado");

 

            migrationBuilder.DropTable(
                name: "departamento");
        }
    }
}
