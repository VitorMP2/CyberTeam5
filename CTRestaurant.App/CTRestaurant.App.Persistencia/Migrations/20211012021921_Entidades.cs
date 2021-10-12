using Microsoft.EntityFrameworkCore.Migrations;

namespace CTRestaurant.App.Persistencia.Migrations
{
    public partial class Entidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Restaurante_RestauranteId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_RestauranteId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "RestauranteId",
                table: "Personas");

            migrationBuilder.AddColumn<int>(
                name: "RestauranteId",
                table: "Turno",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Turno_RestauranteId",
                table: "Turno",
                column: "RestauranteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Turno_Restaurante_RestauranteId",
                table: "Turno",
                column: "RestauranteId",
                principalTable: "Restaurante",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Turno_Restaurante_RestauranteId",
                table: "Turno");

            migrationBuilder.DropIndex(
                name: "IX_Turno_RestauranteId",
                table: "Turno");

            migrationBuilder.DropColumn(
                name: "RestauranteId",
                table: "Turno");

            migrationBuilder.AddColumn<int>(
                name: "RestauranteId",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personas_RestauranteId",
                table: "Personas",
                column: "RestauranteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Restaurante_RestauranteId",
                table: "Personas",
                column: "RestauranteId",
                principalTable: "Restaurante",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
