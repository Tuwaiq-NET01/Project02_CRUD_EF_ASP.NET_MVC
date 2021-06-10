﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Models.Migrations
{
    public partial class ModifiedPokemonModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Pokemon",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Pokemon");
        }
    }
}
