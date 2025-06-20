﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fantasydg.Migrations
{
    /// <inheritdoc />
    public partial class defaultweight : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Weight",
                table: "Tournaments",
                type: "float",
                nullable: false,
                defaultValue: 1.0,
                oldClrType: typeof(double),
                oldType: "float");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Weight",
                table: "Tournaments",
                type: "float",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float",
                oldDefaultValue: 1.0);
        }
    }
}
