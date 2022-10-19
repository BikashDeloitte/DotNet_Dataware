using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace SystemManagementService.Models
{
    public class Pallets
    {
        [Key]
        public string PalletId { get; set; }
        public string ProductId { get; set; }
        public string LPNId { get; set; }
        public int Quantity { get; set; }
    }
}