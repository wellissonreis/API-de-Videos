using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Alura_Challenge_Backend_Semana_1.Migrations
{
    /// <inheritdoc />
    public partial class AtualizacaodeEntidades : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_categorias_videos_VideosId",
                table: "categorias");

            migrationBuilder.DropIndex(
                name: "IX_categorias_VideosId",
                table: "categorias");

            migrationBuilder.DropColumn(
                name: "VideosId",
                table: "categorias");

            migrationBuilder.RenameColumn(
                name: "CategoriaId",
                table: "videos",
                newName: "CategoriasId");

            migrationBuilder.CreateIndex(
                name: "IX_videos_CategoriasId",
                table: "videos",
                column: "CategoriasId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_videos_categorias_CategoriasId",
                table: "videos",
                column: "CategoriasId",
                principalTable: "categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_videos_categorias_CategoriasId",
                table: "videos");

            migrationBuilder.DropIndex(
                name: "IX_videos_CategoriasId",
                table: "videos");

            migrationBuilder.RenameColumn(
                name: "CategoriasId",
                table: "videos",
                newName: "CategoriaId");

            migrationBuilder.AddColumn<int>(
                name: "VideosId",
                table: "categorias",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_categorias_VideosId",
                table: "categorias",
                column: "VideosId");

            migrationBuilder.AddForeignKey(
                name: "FK_categorias_videos_VideosId",
                table: "categorias",
                column: "VideosId",
                principalTable: "videos",
                principalColumn: "Id");
        }
    }
}
