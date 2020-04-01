using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyecto3erModulo.Data.Migrations
{
    public partial class Segunda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FotoPerfi",
                table: "Usuario");

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "Vendedor",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FotoPerfil",
                table: "Usuario",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "Usuario",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vendedor_IdentityUserId",
                table: "Vendedor",
                column: "IdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_IdentityUserId",
                table: "Usuario",
                column: "IdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_AspNetUsers_IdentityUserId",
                table: "Usuario",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vendedor_AspNetUsers_IdentityUserId",
                table: "Vendedor",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_AspNetUsers_IdentityUserId",
                table: "Usuario");

            migrationBuilder.DropForeignKey(
                name: "FK_Vendedor_AspNetUsers_IdentityUserId",
                table: "Vendedor");

            migrationBuilder.DropIndex(
                name: "IX_Vendedor_IdentityUserId",
                table: "Vendedor");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_IdentityUserId",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "Vendedor");

            migrationBuilder.DropColumn(
                name: "FotoPerfil",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "Usuario");

            migrationBuilder.AddColumn<string>(
                name: "FotoPerfi",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
