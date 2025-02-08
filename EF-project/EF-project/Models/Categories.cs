using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_project.Models
{
    public class Categories
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<Products> products { get;}= new List<Products>();

        public override string ToString()
        {
            return $"{CategoryName}";
        }
    }
    
}
//Categories Table
//This table stores product categories (e.g., Electronics, Clothing).
//Categories ( CategoryId, CategoryName );