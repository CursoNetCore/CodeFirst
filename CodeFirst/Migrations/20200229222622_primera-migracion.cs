using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirst.Migrations
{
    public partial class primeramigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categoria",
                columns: table => new
                {
                    idCategoria = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    descripcion = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    estado = table.Column<bool>(nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categoria", x => x.idCategoria);
                });

            migrationBuilder.CreateTable(
                name: "producto",
                columns: table => new
                {
                    idProducto = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idCategoria = table.Column<int>(nullable: false),
                    codigo = table.Column<string>(unicode: false, maxLength: 64, nullable: true),
                    nombre = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    precio_venta = table.Column<decimal>(type: "decimal(11,2)", nullable: false),
                    stock = table.Column<int>(nullable: false),
                    descripcion = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    estado = table.Column<bool>(nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_producto", x => x.idProducto);
                    table.ForeignKey(
                        name: "FK_producto_categoria",
                        column: x => x.idCategoria,
                        principalTable: "categoria",
                        principalColumn: "idCategoria",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_producto_idCategoria",
                table: "producto",
                column: "idCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_producto_nombre",
                table: "producto",
                column: "nombre",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "producto");

            migrationBuilder.DropTable(
                name: "categoria");
        }
    }
}
