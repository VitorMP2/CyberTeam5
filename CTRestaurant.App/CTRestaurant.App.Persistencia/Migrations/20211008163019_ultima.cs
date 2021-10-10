using Microsoft.EntityFrameworkCore.Migrations;

namespace CTRestaurant.App.Persistencia.Migrations
{
    public partial class ultima : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Turno_Personas_ClienteId",
                table: "Turno");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Turno",
                newName: "Clienteid");

            migrationBuilder.RenameIndex(
                name: "IX_Turno_ClienteId",
                table: "Turno",
                newName: "IX_Turno_Clienteid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Personas",
                newName: "id");

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "apellido",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Turno_Personas_Clienteid",
                table: "Turno",
                column: "Clienteid",
                principalTable: "Personas",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Turno_Personas_Clienteid",
                table: "Turno");

            migrationBuilder.RenameColumn(
                name: "Clienteid",
                table: "Turno",
                newName: "ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Turno_Clienteid",
                table: "Turno",
                newName: "IX_Turno_ClienteId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Personas",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "apellido",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_Turno_Personas_ClienteId",
                table: "Turno",
                column: "ClienteId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
