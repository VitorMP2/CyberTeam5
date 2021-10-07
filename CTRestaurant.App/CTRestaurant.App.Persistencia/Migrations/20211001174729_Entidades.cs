using Microsoft.EntityFrameworkCore.Migrations;

namespace CTRestaurant.App.Persistencia.Migrations
{
    public partial class Entidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Turno",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Turno_ClienteId",
                table: "Turno",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Turno_Personas_ClienteId",
                table: "Turno",
                column: "ClienteId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Turno_Personas_ClienteId",
                table: "Turno");

            migrationBuilder.DropIndex(
                name: "IX_Turno_ClienteId",
                table: "Turno");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Turno");
        }
    }
}
