using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SystemManagementService.Context;
using SystemManagementService.Models;

namespace SystemManagementService.Repository
{
    public class LPNRepository
    {
        private readonly LPNContext _lpnContent = null;

        public LPNRepository(LPNContext context)
        {
            _lpnContent = context;
        }

        //add LPN data to database
        public string AddLPN(LPN LPNs)
        {
            var newLPN = new LPN()
            {
                NodeId = LPNs.NodeId
            };

            _lpnContent.LPNs.Add(newLPN);
            _lpnContent.SaveChanges();

            return newLPN.LPNId;
        }

    }
}