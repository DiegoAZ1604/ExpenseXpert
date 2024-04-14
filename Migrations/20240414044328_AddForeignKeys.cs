using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpenseXpertCRUD.Migrations
{
    /// <inheritdoc />
    public partial class AddForeignKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Ingresos_CategoriaID",
                table: "Ingresos",
                column: "CategoriaID");

            migrationBuilder.CreateIndex(
                name: "IX_Ingresos_UsuarioID",
                table: "Ingresos",
                column: "UsuarioID");

            migrationBuilder.CreateIndex(
                name: "IX_Gastos_CategoriaID",
                table: "Gastos",
                column: "CategoriaID");

            migrationBuilder.CreateIndex(
                name: "IX_Gastos_UsuarioID",
                table: "Gastos",
                column: "UsuarioID");

            migrationBuilder.AddForeignKey(
                name: "FK_Gastos_Categorias_CategoriaID",
                table: "Gastos",
                column: "CategoriaID",
                principalTable: "Categorias",
                principalColumn: "CategoriaID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Gastos_Usuarios_UsuarioID",
                table: "Gastos",
                column: "UsuarioID",
                principalTable: "Usuarios",
                principalColumn: "UsuarioID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ingresos_Categorias_CategoriaID",
                table: "Ingresos",
                column: "CategoriaID",
                principalTable: "Categorias",
                principalColumn: "CategoriaID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ingresos_Usuarios_UsuarioID",
                table: "Ingresos",
                column: "UsuarioID",
                principalTable: "Usuarios",
                principalColumn: "UsuarioID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gastos_Categorias_CategoriaID",
                table: "Gastos");

            migrationBuilder.DropForeignKey(
                name: "FK_Gastos_Usuarios_UsuarioID",
                table: "Gastos");

            migrationBuilder.DropForeignKey(
                name: "FK_Ingresos_Categorias_CategoriaID",
                table: "Ingresos");

            migrationBuilder.DropForeignKey(
                name: "FK_Ingresos_Usuarios_UsuarioID",
                table: "Ingresos");

            migrationBuilder.DropIndex(
                name: "IX_Ingresos_CategoriaID",
                table: "Ingresos");

            migrationBuilder.DropIndex(
                name: "IX_Ingresos_UsuarioID",
                table: "Ingresos");

            migrationBuilder.DropIndex(
                name: "IX_Gastos_CategoriaID",
                table: "Gastos");

            migrationBuilder.DropIndex(
                name: "IX_Gastos_UsuarioID",
                table: "Gastos");
        }
    }
}
