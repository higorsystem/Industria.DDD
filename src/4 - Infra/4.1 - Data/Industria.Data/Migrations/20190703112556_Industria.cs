using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Industria.Data.Migrations
{
    public partial class Industria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Industria");

            migrationBuilder.CreateTable(
                name: "tbIndustria",
                schema: "Industria",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Codigo = table.Column<string>(type: "VARCHAR(6)", nullable: false),
                    Descricao = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Tipo = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbIndustria", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbIndustria_Codigo",
                schema: "Industria",
                table: "tbIndustria",
                column: "Codigo",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbIndustria",
                schema: "Industria");
        }
    }
}
