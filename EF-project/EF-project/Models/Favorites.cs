using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_project.Models
{
    [PrimaryKey(nameof(UserId),nameof(ProductId))]
    public class Favorites
    {
        [ForeignKey(nameof(user))]
        public int UserId { get; set; }
        [ForeignKey(nameof(products))]
        public int ProductId { get; set; }
        public virtual User user { get; set; }

        public virtual Products products { get; set; }
    }
}
//Favorites Table
//This table stores the products a user has marked as their favorites.
//CREATE TABLE Favorites (UserId, ProductId);