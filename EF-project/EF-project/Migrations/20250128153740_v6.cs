using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EF_project.Migrations
{
    /// <inheritdoc />
    public partial class v6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Price", "ProductName" },
                values: new object[,]
                {
                    { 1, 1, 19, "Black T-Shirt" },
                    { 2, 1, 15, "White T-Shirt" },
                    { 3, 1, 17, "Blue T-Shirt" },
                    { 4, 1, 18, "Gray T-Shirt" },
                    { 5, 1, 20, "Red T-Shirt" },
                    { 6, 2, 49, "Slim Fit Blue Jeans" },
                    { 7, 2, 54, "Regular Fit Black Jeans" },
                    { 8, 2, 59, "Skinny Fit Gray Jeans" },
                    { 9, 2, 44, "Relaxed Fit Light Blue Jeans" },
                    { 10, 2, 49, "Straight Fit Dark Blue Jeans" },
                    { 11, 3, 39, "Black Hoodie" },
                    { 12, 3, 34, "Gray Hoodie" },
                    { 13, 3, 37, "Navy Hoodie" },
                    { 14, 3, 35, "Green Hoodie" },
                    { 15, 3, 40, "Red Hoodie" },
                    { 16, 4, 99, "Bomber Jacket" },
                    { 17, 4, 149, "Leather Jacket" },
                    { 18, 4, 79, "Denim Jacket" },
                    { 19, 4, 129, "Parka Jacket" },
                    { 20, 4, 69, "Windbreaker Jacket" },
                    { 21, 5, 199, "Single-Breasted Suit" },
                    { 22, 5, 249, "Double-Breasted Suit" },
                    { 23, 5, 219, "Slim Fit Suit" },
                    { 24, 5, 189, "Classic Fit Suit" },
                    { 25, 5, 179, "Two-Piece Suit" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25);
        }
    }
}
