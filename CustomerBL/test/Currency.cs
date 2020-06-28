using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CustomerBL.Models
{
    public class Currency
    {
        [Key]
        [StringLength(3)]
        public string CurrencyID { get; set; }

        [StringLength(100)]
        [Required]
        public string Name { get; set; }

        public string CurrencySymbol { get; set; }

        public ICollection<Customer> Customers { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}