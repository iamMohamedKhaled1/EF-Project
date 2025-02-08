using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EF_project.Migrations
{
    /// <inheritdoc />
    public partial class v7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Price", "ProductName" },
                values: new object[,]
                {
                    { 26, 1, 21, "Green T-Shirt" },
                    { 27, 1, 22, "Yellow T-Shirt" },
                    { 28, 1, 19, "Purple T-Shirt" },
                    { 29, 1, 23, "Orange T-Shirt" },
                    { 30, 1, 18, "Pink T-Shirt" },
                    { 31, 1, 24, "Navy Blue T-Shirt" },
                    { 32, 1, 20, "Sky Blue T-Shirt" },
                    { 33, 1, 21, "Maroon T-Shirt" },
                    { 34, 1, 19, "Beige T-Shirt" },
                    { 35, 1, 22, "Olive T-Shirt" },
                    { 36, 1, 25, "Turquoise T-Shirt" },
                    { 37, 1, 20, "Teal T-Shirt" },
                    { 38, 1, 23, "Lime T-Shirt" },
                    { 39, 1, 19, "Coral T-Shirt" },
                    { 40, 1, 21, "Magenta T-Shirt" },
                    { 41, 1, 22, "Brown T-Shirt" },
                    { 42, 1, 18, "Charcoal T-Shirt" },
                    { 43, 1, 24, "Silver T-Shirt" },
                    { 44, 1, 26, "Gold T-Shirt" },
                    { 45, 1, 20, "Cyan T-Shirt" },
                    { 46, 2, 50, "Slim Fit Dark Gray Jeans" },
                    { 47, 2, 55, "Regular Fit Navy Jeans" },
                    { 48, 2, 60, "Skinny Fit Black Jeans" },
                    { 49, 2, 45, "Relaxed Fit Beige Jeans" },
                    { 50, 2, 48, "Straight Fit Light Gray Jeans" },
                    { 51, 2, 52, "Slim Fit White Jeans" },
                    { 52, 2, 56, "Regular Fit Olive Jeans" },
                    { 53, 2, 62, "Skinny Fit Dark Blue Jeans" },
                    { 54, 2, 47, "Relaxed Fit Brown Jeans" },
                    { 55, 2, 51, "Straight Fit Sky Blue Jeans" },
                    { 56, 2, 49, "Slim Fit Light Blue Jeans" },
                    { 57, 2, 53, "Regular Fit Indigo Jeans" },
                    { 58, 2, 61, "Skinny Fit Charcoal Jeans" },
                    { 59, 2, 46, "Relaxed Fit Stone Wash Jeans" },
                    { 60, 2, 50, "Straight Fit Vintage Blue Jeans" },
                    { 61, 2, 54, "Slim Fit Washed Black Jeans" },
                    { 62, 2, 57, "Regular Fit Classic Blue Jeans" },
                    { 63, 2, 63, "Skinny Fit Distressed Jeans" },
                    { 64, 2, 48, "Relaxed Fit Ripped Jeans" },
                    { 65, 2, 52, "Straight Fit Faded Jeans" },
                    { 66, 3, 38, "White Hoodie" },
                    { 67, 3, 36, "Blue Hoodie" },
                    { 68, 3, 41, "Yellow Hoodie" },
                    { 69, 3, 37, "Orange Hoodie" },
                    { 70, 3, 39, "Purple Hoodie" },
                    { 71, 3, 35, "Beige Hoodie" },
                    { 72, 3, 42, "Brown Hoodie" },
                    { 73, 3, 36, "Olive Hoodie" },
                    { 74, 3, 40, "Teal Hoodie" },
                    { 75, 3, 37, "Cyan Hoodie" },
                    { 76, 3, 38, "Dark Gray Hoodie" },
                    { 77, 3, 39, "Sky Blue Hoodie" },
                    { 78, 3, 35, "Lime Hoodie" },
                    { 79, 3, 41, "Coral Hoodie" },
                    { 80, 3, 38, "Maroon Hoodie" },
                    { 81, 3, 36, "Charcoal Hoodie" },
                    { 82, 3, 42, "Silver Hoodie" },
                    { 83, 3, 44, "Gold Hoodie" },
                    { 84, 3, 39, "Turquoise Hoodie" },
                    { 85, 3, 37, "Magenta Hoodie" },
                    { 86, 4, 89, "Hooded Jacket" },
                    { 87, 4, 159, "Trench Coat" },
                    { 88, 4, 139, "Peacoat" },
                    { 89, 4, 119, "Quilted Jacket" },
                    { 90, 4, 109, "Field Jacket" },
                    { 91, 4, 129, "Blazer Jacket" },
                    { 92, 4, 149, "Suede Jacket" },
                    { 93, 4, 99, "Varsity Jacket" },
                    { 94, 4, 79, "Cropped Jacket" },
                    { 95, 4, 139, "Puffer Jacket" },
                    { 96, 4, 69, "Fleece Jacket" },
                    { 97, 4, 89, "Track Jacket" },
                    { 98, 4, 119, "Military Jacket" },
                    { 99, 4, 79, "Rain Jacket" },
                    { 100, 4, 99, "Anorak Jacket" },
                    { 101, 4, 169, "Shearling Jacket" },
                    { 102, 4, 149, "Wool Jacket" },
                    { 103, 4, 89, "Coach Jacket" },
                    { 104, 4, 109, "Softshell Jacket" },
                    { 105, 4, 119, "Canvas Jacket" },
                    { 106, 5, 259, "Three-Piece Suit" },
                    { 107, 5, 299, "Tuxedo Suit" },
                    { 108, 5, 269, "Velvet Suit" },
                    { 109, 5, 199, "Linen Suit" },
                    { 110, 5, 229, "Wool Suit" },
                    { 111, 5, 239, "Pinstripe Suit" },
                    { 112, 5, 219, "Plaid Suit" },
                    { 113, 5, 249, "Herringbone Suit" },
                    { 114, 5, 209, "Checked Suit" },
                    { 115, 5, 189, "Cotton Suit" },
                    { 116, 5, 179, "Casual Suit" },
                    { 117, 5, 299, "Black Tie Suit" },
                    { 118, 5, 189, "Summer Suit" },
                    { 119, 5, 269, "Winter Suit" },
                    { 120, 5, 219, "Business Suit" },
                    { 121, 5, 199, "Casual Blazer Suit" },
                    { 122, 5, 239, "Modern Fit Suit" },
                    { 123, 5, 229, "Stretch Suit" },
                    { 124, 5, 279, "Zoot Suit" },
                    { 125, 5, 189, "Seersucker Suit" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 125);
        }
    }
}
