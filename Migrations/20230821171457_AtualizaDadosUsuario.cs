using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiDeVideos.Migrations
{
    /// <inheritdoc />
    public partial class AtualizaDadosUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PerfilUsuario",
                table: "AspNetUsers",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PerfilUsuario",
                table: "AspNetUsers");
        }
    }
}
