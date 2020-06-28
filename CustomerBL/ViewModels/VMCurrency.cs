using System.ComponentModel.DataAnnotations;

namespace CustomerBL.ViewModels
{
    public class VMCurrency
    {
        [Key]
        [StringLength(3)]
        public string CurrencyID { get; set; }

        [StringLength(100)]
        public string Currency { get; set; }
    }
}
