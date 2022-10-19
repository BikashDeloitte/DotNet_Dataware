using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SystemManagementService.Models
{
    public class LPN
    {

        [Key]
        public string LPNId { get; set; }
        public string NodeId { get; set; }

    }
}