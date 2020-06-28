using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerBL.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [StringLength(100), Required]
        public string Title { get; set; }

        [Column(TypeName = "money"), Required]
        public decimal Price { get; set; }

        public float Discount { get; set; }


        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}