using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConcesionarioVehiculo.Migrations
{
    /// <inheritdoc />
    public partial class RelacionMarcaVehiculo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MarcaId",
                table: "Vehiculo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Marcas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PaisOrigen = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcas", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_MarcaId",
                table: "Vehiculo",
                column: "MarcaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Marcas_MarcaId",
                table: "Vehiculo",
                column: "MarcaId",
                principalTable: "Marcas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Marcas_MarcaId",
                table: "Vehiculo");

            migrationBuilder.DropTable(
                name: "Marcas");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculo_MarcaId",
                table: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "MarcaId",
                table: "Vehiculo");
        }
    }
}
