using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBL.Models
{
    public class Country
    {
        [Key, StringLength(2)]
        public string CountryID { get; set; }

        [StringLength(100)]
        public string LocalName { get; set; }

        [StringLength(100)]
        public string IntName { get; set; }

        [StringLength(3)]
        public string ShortName { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}