using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SystemManagementService.Models
{
    public class Nodes
    {
        public string NodeId { get; set; }
        public string NodeWarehouseName { get; set; }
        public int NodeWarehouseNumber { get; set; }
        //use enum
        public string StorageArea { get; set; }
    }
}