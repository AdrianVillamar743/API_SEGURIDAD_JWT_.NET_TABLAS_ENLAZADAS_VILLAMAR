using Microsoft.EntityFrameworkCore.Migrations;

namespace VILLAMAR_SECURE_API.Migrations
{
    public partial class ModeloNuevoAsegurado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Departamentos_id_departamento",
                table: "Empleados");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Empleados",
                table: "Empleados");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departamentos",
                table: "Departamentos");

            migrationBuilder.RenameTable(
                name: "Empleados",
                newName: "empleado");

            migrationBuilder.RenameTable(
                name: "Departamentos",
                newName: "departamento");

            migrationBuilder.RenameIndex(
                name: "IX_Empleados_id_departamento",
                table: "empleado",
                newName: "IX_empleado_id_departamento");

            migrationBuilder.AddPrimaryKey(
                name: "PK_empleado",
                table: "empleado",
                column: "id_empleado");

            migrationBuilder.AddPrimaryKey(
                name: "PK_departamento",
                table: "departamento",
                column: "id_departamento");

            migrationBuilder.AddForeignKey(
                name: "FK_empleado_departamento_id_departamento",
                table: "empleado",
                column: "id_departamento",
                principalTable: "departamento",
                principalColumn: "id_departamento",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_empleado_departamento_id_departamento",
                table: "empleado");

            migrationBuilder.DropPrimaryKey(
                name: "PK_empleado",
                table: "empleado");

            migrationBuilder.DropPrimaryKey(
                name: "PK_departamento",
                table: "departamento");

            migrationBuilder.RenameTable(
                name: "empleado",
                newName: "Empleados");

            migrationBuilder.RenameTable(
                name: "departamento",
                newName: "Departamentos");

            migrationBuilder.RenameIndex(
                name: "IX_empleado_id_departamento",
                table: "Empleados",
                newName: "IX_Empleados_id_departamento");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Empleados",
                table: "Empleados",
                column: "id_empleado");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departamentos",
                table: "Departamentos",
                column: "id_departamento");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Departamentos_id_departamento",
                table: "Empleados",
                column: "id_departamento",
                principalTable: "Departamentos",
                principalColumn: "id_departamento",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
