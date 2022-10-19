using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SystemManagementService.Models
{
    public class Product
    {
        [Key]
        public string ProductId { get; set; }
        public long ProductNumber { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
    }
}