using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProniaAppProject.Migrations
{
    /// <inheritdoc />
    public partial class AddProductImagePathsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductImagePath_NewProducts_NewProductId",
                table: "ProductImagePath");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImagePath_Products_ProductId",
                table: "ProductImagePath");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Category_CategoryId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductImagePath",
                table: "ProductImagePath");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "ProductImagePath",
                newName: "ProductImagePaths");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categories");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImagePath_ProductId",
                table: "ProductImagePaths",
                newName: "IX_ProductImagePaths_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImagePath_NewProductId",
                table: "ProductImagePaths",
                newName: "IX_ProductImagePaths_NewProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductImagePaths",
                table: "ProductImagePaths",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImagePaths_NewProducts_NewProductId",
                table: "ProductImagePaths",
                column: "NewProductId",
                principalTable: "NewProducts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImagePaths_Products_ProductId",
                table: "ProductImagePaths",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductImagePaths_NewProducts_NewProductId",
                table: "ProductImagePaths");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImagePaths_Products_ProductId",
                table: "ProductImagePaths");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductImagePaths",
                table: "ProductImagePaths");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "ProductImagePaths",
                newName: "ProductImagePath");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Category");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImagePaths_ProductId",
                table: "ProductImagePath",
                newName: "IX_ProductImagePath_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImagePaths_NewProductId",
                table: "ProductImagePath",
                newName: "IX_ProductImagePath_NewProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductImagePath",
                table: "ProductImagePath",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImagePath_NewProducts_NewProductId",
                table: "ProductImagePath",
                column: "NewProductId",
                principalTable: "NewProducts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImagePath_Products_ProductId",
                table: "ProductImagePath",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Category_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id");
        }
    }
}
