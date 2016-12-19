using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace delapp.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Fastfood = table.Column<string>(nullable: true),
                    Hotdish = table.Column<string>(nullable: true),
                    Other = table.Column<string>(nullable: true),
                    Pizza = table.Column<string>(nullable: true),
                    Salad = table.Column<string>(nullable: true),
                    Sushi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Adress = table.Column<string>(nullable: true),
                    Customer = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Restaurant",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Adress = table.Column<string>(nullable: true),
                    Categories = table.Column<string>(nullable: true),
                    Descryption = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurant", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dish",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Access = table.Column<bool>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    Descrypt = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PizzaSize = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    RestId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dish", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dish_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Dish_Restaurant_RestId",
                        column: x => x.RestId,
                        principalTable: "Restaurant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dish_CategoryId",
                table: "Dish",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Dish_RestId",
                table: "Dish",
                column: "RestId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dish");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Restaurant");
        }
    }
}
