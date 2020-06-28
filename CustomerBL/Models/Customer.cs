using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerBL.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [StringLength(100)]
        public string FName { get; set; }

        [StringLength(100)]
        public string LName { get; set; }

        public bool IsActive { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime BirthDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Created { get; set; }

        [StringLength(20)]
        public string Title { get; set; }

        public float Discount { get; set; }

        [StringLength(1), MinLength(1), Required]
        public string GenderID { get; set; }

        [StringLength(3), MinLength(3)]
        public string CurrencyID { get; set; }

        public virtual Gender Gender { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
    }
}