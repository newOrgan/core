using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace delapp.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dish_Category_CategoryId",
                table: "Dish");

            migrationBuilder.DropForeignKey(
                name: "FK_Dish_Restaurant_RestId",
                table: "Dish");

            migrationBuilder.DropIndex(
                name: "IX_Dish_CategoryId",
                table: "Dish");

            migrationBuilder.DropIndex(
                name: "IX_Dish_RestId",
                table: "Dish");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Dish");

            migrationBuilder.DropColumn(
                name: "Descrypt",
                table: "Dish");

            migrationBuilder.DropColumn(
                name: "RestId",
                table: "Dish");

            migrationBuilder.AddColumn<string>(
                name: "Anything",
                table: "Dish",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Anything",
                table: "Dish");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Dish",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Descrypt",
                table: "Dish",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RestId",
                table: "Dish",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Dish_CategoryId",
                table: "Dish",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Dish_RestId",
                table: "Dish",
                column: "RestId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dish_Category_CategoryId",
                table: "Dish",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dish_Restaurant_RestId",
                table: "Dish",
                column: "RestId",
                principalTable: "Restaurant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
