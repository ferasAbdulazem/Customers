using System.ComponentModel.DataAnnotations;

namespace CustomerBL.ViewModels
{
    public class VMGenders
    {
        [Key]
        [StringLength(1)]
        public string GenderID { get; set; }

        [Required]
        public string Titel { get; set; }
    }
}
