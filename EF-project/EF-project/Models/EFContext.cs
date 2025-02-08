using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_project.Models
{
    public class EFContext :DbContext
    {
        //DbSet
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Favorites> Favorites { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MOHAMEDKHALED\\SQLEXPRESS;Database=EF-Project;Trusted_Connection=True; TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>().HasData(
            new Categories { CategoryId = 1, CategoryName = "T-Shirt" },
            new Categories { CategoryId = 2, CategoryName = "Jeans" },
            new Categories { CategoryId = 3, CategoryName = "Hoodie" },
            new Categories { CategoryId = 4, CategoryName = "Jacket" },
            new Categories { CategoryId = 5, CategoryName = "Suit" }
         );
            modelBuilder.Entity<Products>().HasData(

            new Products { ProductId = 1, ProductName = "Black T-Shirt", Price = 19, CategoryId = 1 },
            new Products { ProductId = 2, ProductName = "White T-Shirt", Price = 15, CategoryId = 1 },
            new Products { ProductId = 3, ProductName = "Blue T-Shirt", Price = 17, CategoryId = 1 },
            new Products { ProductId = 4, ProductName = "Gray T-Shirt", Price = 18, CategoryId = 1 },
            new Products { ProductId = 5, ProductName = "Red T-Shirt", Price = 20, CategoryId = 1 },
            new Products { ProductId = 26, ProductName = "Green T-Shirt", Price = 21, CategoryId = 1 },
            new Products { ProductId = 27, ProductName = "Yellow T-Shirt", Price = 22, CategoryId = 1 },
            new Products { ProductId = 28, ProductName = "Purple T-Shirt", Price = 19, CategoryId = 1 },
            new Products { ProductId = 29, ProductName = "Orange T-Shirt", Price = 23, CategoryId = 1 },
            new Products { ProductId = 30, ProductName = "Pink T-Shirt", Price = 18, CategoryId = 1 },
            new Products { ProductId = 31, ProductName = "Navy Blue T-Shirt", Price = 24, CategoryId = 1 },
            new Products { ProductId = 32, ProductName = "Sky Blue T-Shirt", Price = 20, CategoryId = 1 },
            new Products { ProductId = 33, ProductName = "Maroon T-Shirt", Price = 21, CategoryId = 1 },
            new Products { ProductId = 34, ProductName = "Beige T-Shirt", Price = 19, CategoryId = 1 },
            new Products { ProductId = 35, ProductName = "Olive T-Shirt", Price = 22, CategoryId = 1 },
            new Products { ProductId = 36, ProductName = "Turquoise T-Shirt", Price = 25, CategoryId = 1 },
            new Products { ProductId = 37, ProductName = "Teal T-Shirt", Price = 20, CategoryId = 1 },
            new Products { ProductId = 38, ProductName = "Lime T-Shirt", Price = 23, CategoryId = 1 },
            new Products { ProductId = 39, ProductName = "Coral T-Shirt", Price = 19, CategoryId = 1 },
            new Products { ProductId = 40, ProductName = "Magenta T-Shirt", Price = 21, CategoryId = 1 },
            new Products { ProductId = 41, ProductName = "Brown T-Shirt", Price = 22, CategoryId = 1 },
            new Products { ProductId = 42, ProductName = "Charcoal T-Shirt", Price = 18, CategoryId = 1 },
            new Products { ProductId = 43, ProductName = "Silver T-Shirt", Price = 24, CategoryId = 1 },
            new Products { ProductId = 44, ProductName = "Gold T-Shirt", Price = 26, CategoryId = 1 },
            new Products { ProductId = 45, ProductName = "Cyan T-Shirt", Price = 20, CategoryId = 1 },


            new Products { ProductId = 6, ProductName = "Slim Fit Blue Jeans", Price = 49, CategoryId = 2 },
            new Products { ProductId = 7, ProductName = "Regular Fit Black Jeans", Price = 54, CategoryId = 2 },
            new Products { ProductId = 8, ProductName = "Skinny Fit Gray Jeans", Price = 59, CategoryId = 2 },
            new Products { ProductId = 9, ProductName = "Relaxed Fit Light Blue Jeans", Price = 44, CategoryId = 2 },
            new Products { ProductId = 10, ProductName = "Straight Fit Dark Blue Jeans", Price = 49, CategoryId = 2 },
            new Products { ProductId = 46, ProductName = "Slim Fit Dark Gray Jeans", Price = 50, CategoryId = 2 },
            new Products { ProductId = 47, ProductName = "Regular Fit Navy Jeans", Price = 55, CategoryId = 2 },
            new Products { ProductId = 48, ProductName = "Skinny Fit Black Jeans", Price = 60, CategoryId = 2 },
            new Products { ProductId = 49, ProductName = "Relaxed Fit Beige Jeans", Price = 45, CategoryId = 2 },
            new Products { ProductId = 50, ProductName = "Straight Fit Light Gray Jeans", Price = 48, CategoryId = 2 },
            new Products { ProductId = 51, ProductName = "Slim Fit White Jeans", Price = 52, CategoryId = 2 },
            new Products { ProductId = 52, ProductName = "Regular Fit Olive Jeans", Price = 56, CategoryId = 2 },
            new Products { ProductId = 53, ProductName = "Skinny Fit Dark Blue Jeans", Price = 62, CategoryId = 2 },
            new Products { ProductId = 54, ProductName = "Relaxed Fit Brown Jeans", Price = 47, CategoryId = 2 },
            new Products { ProductId = 55, ProductName = "Straight Fit Sky Blue Jeans", Price = 51, CategoryId = 2 },
            new Products { ProductId = 56, ProductName = "Slim Fit Light Blue Jeans", Price = 49, CategoryId = 2 },
            new Products { ProductId = 57, ProductName = "Regular Fit Indigo Jeans", Price = 53, CategoryId = 2 },
            new Products { ProductId = 58, ProductName = "Skinny Fit Charcoal Jeans", Price = 61, CategoryId = 2 },
            new Products { ProductId = 59, ProductName = "Relaxed Fit Stone Wash Jeans", Price = 46, CategoryId = 2 },
            new Products { ProductId = 60, ProductName = "Straight Fit Vintage Blue Jeans", Price = 50, CategoryId = 2 },
            new Products { ProductId = 61, ProductName = "Slim Fit Washed Black Jeans", Price = 54, CategoryId = 2 },
            new Products { ProductId = 62, ProductName = "Regular Fit Classic Blue Jeans", Price = 57, CategoryId = 2 },
            new Products { ProductId = 63, ProductName = "Skinny Fit Distressed Jeans", Price = 63, CategoryId = 2 },
            new Products { ProductId = 64, ProductName = "Relaxed Fit Ripped Jeans", Price = 48, CategoryId = 2 },
            new Products { ProductId = 65, ProductName = "Straight Fit Faded Jeans", Price = 52, CategoryId = 2 },


            new Products { ProductId = 11, ProductName = "Black Hoodie", Price = 39, CategoryId = 3 },
            new Products { ProductId = 12, ProductName = "Gray Hoodie", Price = 34, CategoryId = 3 },
            new Products { ProductId = 13, ProductName = "Navy Hoodie", Price = 37, CategoryId = 3 },
            new Products { ProductId = 14, ProductName = "Green Hoodie", Price = 35, CategoryId = 3 },
            new Products { ProductId = 15, ProductName = "Red Hoodie", Price = 40, CategoryId = 3 },
            new Products { ProductId = 66, ProductName = "White Hoodie", Price = 38, CategoryId = 3 },
            new Products { ProductId = 67, ProductName = "Blue Hoodie", Price = 36, CategoryId = 3 },
            new Products { ProductId = 68, ProductName = "Yellow Hoodie", Price = 41, CategoryId = 3 },
            new Products { ProductId = 69, ProductName = "Orange Hoodie", Price = 37, CategoryId = 3 },
            new Products { ProductId = 70, ProductName = "Purple Hoodie", Price = 39, CategoryId = 3 },
            new Products { ProductId = 71, ProductName = "Beige Hoodie", Price = 35, CategoryId = 3 },
            new Products { ProductId = 72, ProductName = "Brown Hoodie", Price = 42, CategoryId = 3 },
            new Products { ProductId = 73, ProductName = "Olive Hoodie", Price = 36, CategoryId = 3 },
            new Products { ProductId = 74, ProductName = "Teal Hoodie", Price = 40, CategoryId = 3 },
            new Products { ProductId = 75, ProductName = "Cyan Hoodie", Price = 37, CategoryId = 3 },
            new Products { ProductId = 76, ProductName = "Dark Gray Hoodie", Price = 38, CategoryId = 3 },
            new Products { ProductId = 77, ProductName = "Sky Blue Hoodie", Price = 39, CategoryId = 3 },
            new Products { ProductId = 78, ProductName = "Lime Hoodie", Price = 35, CategoryId = 3 },
            new Products { ProductId = 79, ProductName = "Coral Hoodie", Price = 41, CategoryId = 3 },
            new Products { ProductId = 80, ProductName = "Maroon Hoodie", Price = 38, CategoryId = 3 },
            new Products { ProductId = 81, ProductName = "Charcoal Hoodie", Price = 36, CategoryId = 3 },
            new Products { ProductId = 82, ProductName = "Silver Hoodie", Price = 42, CategoryId = 3 },
            new Products { ProductId = 83, ProductName = "Gold Hoodie", Price = 44, CategoryId = 3 },
            new Products { ProductId = 84, ProductName = "Turquoise Hoodie", Price = 39, CategoryId = 3 },
            new Products { ProductId = 85, ProductName = "Magenta Hoodie", Price = 37, CategoryId = 3 },


            new Products { ProductId = 16, ProductName = "Bomber Jacket", Price = 99, CategoryId = 4 },
            new Products { ProductId = 17, ProductName = "Leather Jacket", Price = 149, CategoryId = 4 },
            new Products { ProductId = 18, ProductName = "Denim Jacket", Price = 79, CategoryId = 4 },
            new Products { ProductId = 19, ProductName = "Parka Jacket", Price = 129, CategoryId = 4 },
            new Products { ProductId = 20, ProductName = "Windbreaker Jacket", Price = 69, CategoryId = 4 },
            new Products { ProductId = 86, ProductName = "Hooded Jacket", Price = 89, CategoryId = 4 },
            new Products { ProductId = 87, ProductName = "Trench Coat", Price = 159, CategoryId = 4 },
            new Products { ProductId = 88, ProductName = "Peacoat", Price = 139, CategoryId = 4 },
            new Products { ProductId = 89, ProductName = "Quilted Jacket", Price = 119, CategoryId = 4 },
            new Products { ProductId = 90, ProductName = "Field Jacket", Price = 109, CategoryId = 4 },
            new Products { ProductId = 91, ProductName = "Blazer Jacket", Price = 129, CategoryId = 4 },
            new Products { ProductId = 92, ProductName = "Suede Jacket", Price = 149, CategoryId = 4 },
            new Products { ProductId = 93, ProductName = "Varsity Jacket", Price = 99, CategoryId = 4 },
            new Products { ProductId = 94, ProductName = "Cropped Jacket", Price = 79, CategoryId = 4 },
            new Products { ProductId = 95, ProductName = "Puffer Jacket", Price = 139, CategoryId = 4 },
            new Products { ProductId = 96, ProductName = "Fleece Jacket", Price = 69, CategoryId = 4 },
            new Products { ProductId = 97, ProductName = "Track Jacket", Price = 89, CategoryId = 4 },
            new Products { ProductId = 98, ProductName = "Military Jacket", Price = 119, CategoryId = 4 },
            new Products { ProductId = 99, ProductName = "Rain Jacket", Price = 79, CategoryId = 4 },
            new Products { ProductId = 100, ProductName = "Anorak Jacket", Price = 99, CategoryId = 4 },
            new Products { ProductId = 101, ProductName = "Shearling Jacket", Price = 169, CategoryId = 4 },
            new Products { ProductId = 102, ProductName = "Wool Jacket", Price = 149, CategoryId = 4 },
            new Products { ProductId = 103, ProductName = "Coach Jacket", Price = 89, CategoryId = 4 },
            new Products { ProductId = 104, ProductName = "Softshell Jacket", Price = 109, CategoryId = 4 },
            new Products { ProductId = 105, ProductName = "Canvas Jacket", Price = 119, CategoryId = 4 },


            new Products { ProductId = 21, ProductName = "Single-Breasted Suit", Price = 199, CategoryId = 5 },
            new Products { ProductId = 22, ProductName = "Double-Breasted Suit", Price = 249, CategoryId = 5 },
            new Products { ProductId = 23, ProductName = "Slim Fit Suit", Price = 219, CategoryId = 5 },
            new Products { ProductId = 24, ProductName = "Classic Fit Suit", Price = 189, CategoryId = 5 },
            new Products { ProductId = 25, ProductName = "Two-Piece Suit", Price = 179, CategoryId = 5 },
            new Products { ProductId = 106, ProductName = "Three-Piece Suit", Price = 259, CategoryId = 5 },
            new Products { ProductId = 107, ProductName = "Tuxedo Suit", Price = 299, CategoryId = 5 },
            new Products { ProductId = 108, ProductName = "Velvet Suit", Price = 269, CategoryId = 5 },
            new Products { ProductId = 109, ProductName = "Linen Suit", Price = 199, CategoryId = 5 },
            new Products { ProductId = 110, ProductName = "Wool Suit", Price = 229, CategoryId = 5 },
            new Products { ProductId = 111, ProductName = "Pinstripe Suit", Price = 239, CategoryId = 5 },
            new Products { ProductId = 112, ProductName = "Plaid Suit", Price = 219, CategoryId = 5 },
            new Products { ProductId = 113, ProductName = "Herringbone Suit", Price = 249, CategoryId = 5 },
            new Products { ProductId = 114, ProductName = "Checked Suit", Price = 209, CategoryId = 5 },
            new Products { ProductId = 115, ProductName = "Cotton Suit", Price = 189, CategoryId = 5 },
            new Products { ProductId = 116, ProductName = "Casual Suit", Price = 179, CategoryId = 5 },
            new Products { ProductId = 117, ProductName = "Black Tie Suit", Price = 299, CategoryId = 5 },
            new Products { ProductId = 118, ProductName = "Summer Suit", Price = 189, CategoryId = 5 },
            new Products { ProductId = 119, ProductName = "Winter Suit", Price = 269, CategoryId = 5 },
            new Products { ProductId = 120, ProductName = "Business Suit", Price = 219, CategoryId = 5 },
            new Products { ProductId = 121, ProductName = "Casual Blazer Suit", Price = 199, CategoryId = 5 },
            new Products { ProductId = 122, ProductName = "Modern Fit Suit", Price = 239, CategoryId = 5 },
            new Products { ProductId = 123, ProductName = "Stretch Suit", Price = 229, CategoryId = 5 },
            new Products { ProductId = 124, ProductName = "Zoot Suit", Price = 279, CategoryId = 5 },
            new Products { ProductId = 125, ProductName = "Seersucker Suit", Price = 189, CategoryId = 5 }
            );



        }
    }
}

//Database Design
//1. Database Schema
//You will need to create a database with the following tables:
//Users Table
//This table stores user credentials for login and registration.
//Users ( UserId, Username, Password, Email, Age, Address, Role-- Admin or User );
//Categories Table
//This table stores product categories (e.g., Electronics, Clothing).
//Categories ( CategoryId, CategoryName );
//Products Table
//This table stores product details and references the category each product belongs to.
//Products ( ProductId, ProductName, Price, CategoryId);
//Favorites Table
//This table stores the products a user has marked as their favorites.
//CREATE TABLE Favorites (UserId, ProductId);



//Relationships:
//Each product belongs to one category.
//Each category can have many products.
//Each user can have many favorite products.

