using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerBL.Models
{
    public class OrderItem
    {

        [Key, Column(Order = 0)]
        public int OrderID { get; set; }

        [Key, Column(Order = 1)]
        public int ItemNumber { get; set; }

        [Required]
        public int ProductID { get; set; }

        [Column(TypeName = "dateTime2")]
        public DateTime DeliveryDate { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        public float Discount { get; set; }

        public bool IsPartial { get; set; }


        public virtual Product Product { get; set; }
    }
}