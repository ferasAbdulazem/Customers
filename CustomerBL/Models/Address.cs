using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBL.Models
{
    public class Address
    {
        [Key]
        public int AddressID { get; set; }

        [StringLength(100)]
        public string Street { get; set; }

        [StringLength(20)]
        public string StreetNr { get; set; }

        [Required, StringLength(10), ForeignKey("City"), Column(Order = 0)]
        public string Zip { get; set; }

        [Required, StringLength(2), ForeignKey("City"), Column(Order = 1)]
        public string CountryID { get; set; }

        [Required]
        public int CustomerID { get; set; }

        public virtual City City { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<Order> DeliveryOrders { get; set; }
        public virtual ICollection<Order> BillingOrders { get; set; }

    }
}