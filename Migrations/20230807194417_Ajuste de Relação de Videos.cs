using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiDeVideos.Migrations
{
    /// <inheritdoc />
    public partial class AjustedeRelaçãodeVideos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_videos_CategoriasId",
                table: "videos");

            migrationBuilder.CreateIndex(
                name: "IX_videos_CategoriasId",
                table: "videos",
                column: "CategoriasId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_videos_CategoriasId",
                table: "videos");

            migrationBuilder.CreateIndex(
                name: "IX_videos_CategoriasId",
                table: "videos",
                column: "CategoriasId",
                unique: true);
        }
    }
}
