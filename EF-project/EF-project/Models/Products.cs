using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_project.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        [ForeignKey("categories")]
        public int CategoryId { get; set; }
        public virtual Categories categories { get; set; }
        public virtual List<Favorites> favorites { get;}=new List<Favorites>();

    }
}
//Products Table
//This table stores product details and references the category each product belongs to.
//Products ( ProductId, ProductName, Price, CategoryId);
