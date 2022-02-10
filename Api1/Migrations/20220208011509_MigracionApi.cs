using Microsoft.EntityFrameworkCore.Migrations;

namespace Api1.Migrations
{
    public partial class MigracionApi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripción = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    Fecha_fabricación = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fecha_validez = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cod_proveedor = table.Column<int>(type: "int", nullable: false),
                    Descripción_proveedor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelefonoProveedor = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Codigo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Productos");
        }
    }
}
