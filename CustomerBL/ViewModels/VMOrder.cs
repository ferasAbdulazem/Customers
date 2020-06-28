using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBL.ViewModels
{
    public class VMOrder
    {
        [Key]
        public int OrderID { get; set; }

        public DateTime OrderDate { get; set; }

        public bool IsActive { get; set; }

        public float Discount { get; set; }

        [Required]
        public string Currency { get; set; }

        public bool IsPartial { get; set; }

        public string DeliveryAdd { get; set; }

        public string BillingAdd { get; set; }

        public decimal TotalSum { get; set; }

        public int TotalAmount { get; set; }
    }
}
