﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilmesAPI.Migrations
{
    /// <inheritdoc />
    public partial class cinemaeendereconovo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EnderecoId",
                table: "Cinemas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cinemas_EnderecoId",
                table: "Cinemas",
                column: "EnderecoId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cinemas_Enderecos_EnderecoId",
                table: "Cinemas",
                column: "EnderecoId",
                principalTable: "Enderecos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cinemas_Enderecos_EnderecoId",
                table: "Cinemas");

            migrationBuilder.DropIndex(
                name: "IX_Cinemas_EnderecoId",
                table: "Cinemas");

            migrationBuilder.DropColumn(
                name: "EnderecoId",
                table: "Cinemas");
        }
    }
}
