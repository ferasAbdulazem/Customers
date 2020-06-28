using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBL.ViewModels
{
    public class VMCustomer
    {
        [Key]
        public int CustomerID { get; set; }

        [StringLength(100)]
        public string FullName { get; set; }

        public bool IsActive { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime BirthDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Created { get; set; }

        [StringLength(20)]
        public string Title { get; set; }

        public decimal Discount { get; set; }

        [StringLength(1), MinLength(1), Required]
        public string GenderID { get; set; }

        [StringLength(3), MinLength(3)]
        public string CurrencyID { get; set; }
    }
}
