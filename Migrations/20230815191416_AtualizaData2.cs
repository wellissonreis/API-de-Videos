using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Alura_Challenge_Backend_Semana_1.Migrations
{
    /// <inheritdoc />
    public partial class AtualizaData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DataNascimento",
                table: "AspNetUsers",
                type: "text",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateOnly>(
                name: "DataNascimento",
                table: "AspNetUsers",
                type: "date",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}
