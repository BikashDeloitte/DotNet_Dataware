using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SystemManagementService.Context;
using SystemManagementService.Models;

namespace SystemManagementService.Repository
{
    public class PalletRepository
    {
        private readonly PalletsContext _palletContext = null;

        public PalletRepository(PalletsContext context)
        {
            _palletContext = context;
        }

        //add pallet data to database
        public string AddPallet(Pallets pallets)
        {
            var newPallet = new Pallets()
            {
                ProductId = pallets.ProductId,
                LPNId = pallets.LPNId,
                Quantity = pallets.Quantity
            };

            _palletContext.pallets.Add(newPallet);
            _palletContext.SaveChanges();

            return newPallet.PalletId;
        }

    }
}