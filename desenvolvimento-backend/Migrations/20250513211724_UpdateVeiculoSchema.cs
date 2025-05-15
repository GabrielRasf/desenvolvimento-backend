using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace desenvolvimento_backend.Migrations
{
    /// <inheritdoc />
    public partial class UpdateVeiculoSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AnoFacricacao",
                table: "Veiculos",
                newName: "AnoFabricacao");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AnoFabricacao",
                table: "Veiculos",
                newName: "AnoFacricacao");
        }
    }
}
