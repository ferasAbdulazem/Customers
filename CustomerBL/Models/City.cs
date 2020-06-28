using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBL.Models
{
    public class City
    {
        [Key, Column(Order = 0), StringLength(10)]
        public string Zip { get; set; }

        [Key, Column(Order = 1), StringLength(2)]
        public string CountryID { get; set; }

        [StringLength(100)]
        public string LocalName { get; set; }

        [StringLength(100)]
        public string IntName { get; set; }


        public virtual Country Country { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
    }
}

