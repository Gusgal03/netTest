using Microsoft.EntityFrameworkCore.Migrations;

namespace netTest.Migrations
{
    public partial class Migracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Catalogo",
                columns: table => new
                {
                    IdCatalogo = table.Column<int>(nullable: false) //es primary key
                        .Annotation("SqlServer:Identity", "1, 1"), //aumentará 1 por 1
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalogo", x => x.IdCatalogo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Catalogo");
        }
    }
}
