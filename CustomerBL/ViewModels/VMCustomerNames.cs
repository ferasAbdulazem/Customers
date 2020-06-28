using System.ComponentModel.DataAnnotations;

namespace CustomerBL.ViewModels
{
    public class VMCustomerNames
    {
        [Key]
        public int CustomerID { get; set; }

        [StringLength(210)]
        public string FullName { get; set; }
    }
}
