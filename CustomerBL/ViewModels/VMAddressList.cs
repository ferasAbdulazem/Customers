using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBL.ViewModels
{
    public class VMAddressList
    {
        [Key]
        public int AddressID { get; set; }

        public string FullAddress { get; set; }
    }
}
