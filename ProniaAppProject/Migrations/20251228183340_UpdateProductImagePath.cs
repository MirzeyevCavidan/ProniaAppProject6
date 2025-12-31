using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProniaAppProject.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProductImagePath : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrimaryImagePath",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SecondaryImagePath",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "PrimaryImagePath",
                table: "NewProducts");

            migrationBuilder.DropColumn(
                name: "SecondaryImagePath",
                table: "NewProducts");

            migrationBuilder.CreateTable(
                name: "ProductImagePath",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPrimary = table.Column<bool>(type: "bit", nullable: false),
                    IsSecondary = table.Column<bool>(type: "bit", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    NewProductId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImagePath", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImagePath_NewProducts_NewProductId",
                        column: x => x.NewProductId,
                        principalTable: "NewProducts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductImagePath_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductImagePath_NewProductId",
                table: "ProductImagePath",
                column: "NewProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImagePath_ProductId",
                table: "ProductImagePath",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImagePath");

            migrationBuilder.AddColumn<string>(
                name: "PrimaryImagePath",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SecondaryImagePath",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PrimaryImagePath",
                table: "NewProducts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SecondaryImagePath",
                table: "NewProducts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
