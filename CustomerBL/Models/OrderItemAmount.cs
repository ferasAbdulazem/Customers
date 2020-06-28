using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBL.Models
{
    public class OrderItemAmount
    {
        [Key]
        public int AmountID { get; set; }

        [ForeignKey("OrderItem"), Column(Order = 0)]
        public int OrderID { get; set; }

        [ForeignKey("OrderItem"), Column(Order = 1)]
        public int OrderItemNumber { get; set; }

        [Required]
        public int Amount { get; set; }

        public int StatusID { get; set; }

        public virtual OrderItem OrderItem { get; set; }
        public virtual OrderStatus Status { get; set; }
    }
}