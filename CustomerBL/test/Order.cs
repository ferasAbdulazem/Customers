using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerBL.Models
{
    //K[Key, column(order = 0)]
    //[ForeignKey("NAme"), Column(order = )]
    //orderposiion
    // oder auch unten

    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime OrderDate { get; set; }

        [Required]
        public int CustomerID { get; set; }

        public bool IsActive { get; set; }

        public float Discount { get; set; }

        [Required]
        public string CurrencyID { get; set; }

        public bool IsPartial { get; set; }

        public virtual Currency Currency { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
