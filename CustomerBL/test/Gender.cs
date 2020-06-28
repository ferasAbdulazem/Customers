using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CustomerBL.Models
{
    public class Gender
    {
        [Key]
        [StringLength(1)]
        public string GenderID { get; set; }

        [Required]
        public string Titel { get; set; }

        [StringLength(500)]
        public string Notes { get; set; }

        public ICollection<Customer> Custtomers { get; set; }
    }
}