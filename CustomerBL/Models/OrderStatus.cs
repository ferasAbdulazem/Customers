using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CustomerBL.Models
{
    public class OrderStatus
    {
        [Key]
        public int StatusID { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(200)]
        public string Note { get; set; }

        public virtual ICollection<OrderItemAmount> OrderItemAmounts { get; set; }
    }
}