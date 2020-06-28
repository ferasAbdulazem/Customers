using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBL.ViewModels
{
    public class VMOrderItem
    {
        [Key, Column(Order = 0)]
        public int OrderID { get; set; }

        [Key, Column(Order = 1)]
        public int ItemNumber { get; set; }

        [Required]
        public string Product { get; set; }

        [Column(TypeName = "dateTime2")]
        public DateTime DeliveryDate { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        public float Discount { get; set; }

        public bool IsPartial { get; set; }

        public decimal Sum { get; set; }
    }
}
